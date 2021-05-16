using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wqasdasda.Models
{
    public class AdType
    {
        public int Id { get; set; }
        public string TypeOfCat { get; set; }
        public virtual ICollection<AdvertisementModel> AdvertisementModels { get; set; }

    }
}
