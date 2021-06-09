using Advertisement.Data;
using Advertisement.Models;
using Advertisement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Advertisement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }



        public IActionResult Index(string SearchText = "")
        {
            //if (SearchText != "" && SearchText != null)
            //{
            //    Title = _context.Advertisements.Where(x => x.Title.Contains(SearchText)).ToList();
            //}

            var getData = _context.Advertisements;
            var searchedData = getData.Where(x => x.Title.ToLower().Contains(SearchText.ToLower()));

            var data = new HomeIndexViewModel();
            if (SearchText != "" && SearchText != null)
            {
                data = new HomeIndexViewModel
                {
                    AdvertiseList = searchedData.Where(x => x.Active == true).Select(x => new AdvertisementViewModel
                    {
                        Title = x.Title,
                        PicturesCol = x.PicturesCol,
                        AdTypes = x.AdTypes,
                        Description = x.Description,
                        Id = x.Id
                    })
                };
                
                return View(data);
            }
            else
            {
                data = new HomeIndexViewModel
                {
                    AdvertiseList = getData.Where(x => x.Active == true).Select(x => new AdvertisementViewModel
                    {
                        Title = x.Title,
                        PicturesCol = x.PicturesCol,
                        AdTypes = x.AdTypes,
                        Description = x.Description,
                        Id = x.Id
                    })
                };
                return View(data);
            }
            
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //public IActionResult OnGetPartial() =>
        //    new PartialViewResult
        //    {
        //        ViewData = _context.Advertisements,
        //        ViewName = "_advertiseList"
        //    };
    }
}
