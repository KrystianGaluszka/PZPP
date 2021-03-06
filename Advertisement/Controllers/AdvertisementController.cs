using Advertisement.Data;
using Advertisement.Models;
using Advertisement.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
        private readonly SignInManager<IdentityUser> _signInManager;

        public AdvertisementController(IWebHostEnvironment environment, ApplicationDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _env = environment;
            _dir = _env.WebRootPath;
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult EditAdvertisement(int id)
        {
            var advertisements = _context.Advertisements.FirstOrDefault(x => x.Id == id);
            EditAdViewModel editAdViewModel = new EditAdViewModel
            {
                Id = advertisements.Id,
                Title = advertisements.Title,
                Description = advertisements.Description,
                AdTypes = advertisements.AdTypes
            };
            return View(editAdViewModel);
        }
        [HttpPost]
        public IActionResult EditAdvertisement(EditAdViewModel model)
        {
                var advertisement = _context.Advertisements.FirstOrDefault(x => x.Id == model.Id);
                if (advertisement == null)
                {
                    return View();
                }
                else
                {
                    advertisement.Id = model.Id;
                    advertisement.Description = model.Description;
                    advertisement.Title = model.Title;
                    advertisement.AdTypes = model.AdTypes;
                    _context.SaveChanges();
                return RedirectToAction("UserAds");
                }
        }
        [Authorize]
        [HttpGet]
        public IActionResult AddAd()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult AddAd(AdvertisementViewModel adModel)
        {
            var pictures = new Pictures();
            var files = HttpContext.Request.Form.Files;
            if(files.Count != 0 || files != null)
            {
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
            }
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var advertisement = new Advertisements
            {
                Title = adModel.Title,
                Description = adModel.Description,
                AdTypes = adModel.AdTypes,
                UserId = userId,
                PicturesCol = adModel.PicturesCol,
                Active = true,
                CreatedOn = DateTime.Now,
                Views = 0
            };
            _context.Advertisements.Add(advertisement);
            _context.SaveChanges();
            int id = _context.Advertisements.OrderBy(x => x.Id).LastOrDefault().Id;
            return RedirectToAction(nameof(AdvertisementDisplay), new {id = id, adName = adModel.Title });
        }
        public IActionResult AdvertisementDisplay(int id, string adName)
        {
            //licznik wyświetleń
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (Url.Action("UserAds", "Advertisement", null, Request.Scheme) != Request.Headers["Referer"] || Request.Headers["Referer"] != Url.Action("AddAd", "Advertisement", null, Request.Scheme))
            {
                if (userId != _context.Advertisements.Where(x => x.Id == id).FirstOrDefault().UserId)
                {
                    _context.Advertisements.Where(x => x.Id == id).FirstOrDefault().Views += 1;
                    _context.SaveChanges();
                }
            }

            var adList = _context.Advertisements.ToList();
            var picList = _context.Pictures.ToList();
            ViewBag.PicList = picList;
            ViewBag.List = adList;
            ViewBag.Id = id;
            ViewBag.Name = adName;
            return View();
        }
        [Authorize]
        public IActionResult UserAds()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var con = _context.Advertisements;
            var model = con.Select(x => new Advertisements
            {
                Id = x.Id,
                UserId = x.UserId,
                Active = x.Active,
                AdTypes = x.AdTypes,
                Title = x.Title,
                Description = x.Description,
                PicturesCol = x.PicturesCol,
                CreatedOn = x.CreatedOn,
                Views = x.Views
            }).Where(x=>x.UserId == userId).ToList();


            ViewBag.UserId = userId;

            return View(model);
        }
        public IActionResult DeleteAd(int id)
        {
            var ad = _context.Advertisements.Where(x => x.Id == id).FirstOrDefault();
            _context.Advertisements.Remove(ad);
            _context.SaveChanges();
            return RedirectToAction(nameof(UserAds));
        }
        public IActionResult Deactivate(int id)
        {
            var ad = new Advertisements()
            {
                Id = id,
                Active = false
            };
            _context.Entry(ad).Property(x => x.Active).IsModified = true;
            _context.SaveChanges();
            return RedirectToAction(nameof(UserAds));
        }
        public IActionResult Activate(int id)
        {
            var ad = new Advertisements()
            {
                Id = id,
                Active = true
            };
            _context.Entry(ad).Property(x => x.Active).IsModified = true;
            _context.SaveChanges();
            return RedirectToAction(nameof(UserAds));
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
