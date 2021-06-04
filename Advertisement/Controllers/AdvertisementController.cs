using Advertisement.Data;
using Advertisement.Models;
using Advertisement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Advertisement.Controllers
{
    public class AdvertisementController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IWebHostEnvironment _env;
        private string _dir;
        private readonly UserManager<IdentityUser> _userManager;

        public AdvertisementController(IWebHostEnvironment environment, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            this._env = environment;
            _dir = _env.WebRootPath;
            _context = context;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult AddAd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAd(AdvertisementViewModel adModel)
        {
            var pictures = new Pictures();
            var files = HttpContext.Request.Form.Files;
            foreach (var file in files)
            {
                if (!(fileValid(file.FileName)))
                {
                    TempData["imgMsg"] = "Plik musi być zdjęciem";
                    return RedirectToAction(nameof(AddAd));
                }
                if (file != null)
                {
                    string folderPath = Path.Combine(_dir, $"AdPictures");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    string filePath = Path.Combine(folderPath, file.FileName);
                    pictures = new Pictures() { Name = file.FileName, PicturePath = filePath };
                    adModel.PicturesCol.Add(pictures);
                    using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        file.CopyTo(fs);
                    }
                }
            }
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var advertisement = new Advertisements
            {
                Title = adModel.Title,
                Description = adModel.Description,
                AdTypes = adModel.AdTypes,
                UserId = userId,
                PicturesCol = adModel.PicturesCol
            };
            _context.Advertisements.Add(advertisement);
            _context.SaveChanges();
            int id = _context.Advertisements.OrderBy(x => x.Id).LastOrDefault().Id;
            return RedirectToAction(nameof(AdvertisementDisplay), new {id = id, adName = adModel.Title });
        }
        public IActionResult AdvertisementDisplay(int id, string adName)
        {
            var adList = _context.Advertisements.ToList();
            var picList = _context.Pictures.ToList();
            ViewBag.PicList = picList;
            ViewBag.List = adList;
            ViewBag.Id = id;
            ViewBag.Name = adName;
            return View();
        }
        bool fileValid(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                case ".png":
                    return true;
                case ".bmp":
                    return true;
                default:
                    return false;
            }
        }
    }
}
