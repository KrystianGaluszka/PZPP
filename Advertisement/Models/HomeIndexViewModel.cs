using Advertisement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advertisement.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<AdvertisementViewModel> AdvertiseList { get; set; }
    }
}
