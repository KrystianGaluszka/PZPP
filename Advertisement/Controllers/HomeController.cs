using Advertisement.Data;
using Advertisement.Models;
using Advertisement.ViewModels;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            var getData = _context.Advertisements;
            var data = new HomeIndexViewModel
            {
                AdvertiseList = getData.Select(x => new AdvertisementViewModel
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
