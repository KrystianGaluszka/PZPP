using ALLEGRO.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ALLEGRO.Controllers
{
    public class AdvertisementController : Controller
    {
        private static List<AdvertisementViewModel> _advertisements = new List<AdvertisementViewModel>();
        private IWebHostEnvironment _env;
        private string _dir;

        public AdvertisementController(IWebHostEnvironment environment)
        {
            this._env = environment;
            _dir = _env.WebRootPath;
        }
        public IActionResult AddAd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAd(AdvertisementViewModel adModel)
        {
            TempData["imgMsg"] = "";
            if (ModelState.IsValid)
            {
                // Upload zdjęć
                foreach (var file in adModel.Picture)
                {
                    if (!(fileValid(file.FileName)))
                    {
                        TempData["imgMsg"] = "Plik musi być zdjęciem";
                        return RedirectToAction(nameof(AddAd));
                    }
                    if (adModel.Picture != null)
                    {
                        string folderPath = Path.Combine(_dir, "AdPictures");
                        string filePath = Path.Combine(folderPath, file.FileName);
                        file.CopyTo(new FileStream(filePath, FileMode.Create));
                    }
                }

                _advertisements.Add(adModel);
                //return RedirectToAction("Create", "Register");
                TempData["msg"] = "GITUWAAA";
                return RedirectToAction(nameof(AddAd));
            }
            TempData["msg"] = "GÓNWO";
            return RedirectToAction(nameof(AddAd));
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
