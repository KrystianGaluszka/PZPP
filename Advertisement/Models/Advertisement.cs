using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advertisement.Models
{
    public class Advertisements
    {
        public string UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Pictures> PicturesCol { get; set; }
        public AdType AdTypes { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
    public class Pictures
    {
    public int Id { get; set; }
    public int AdvertisementId { get; set; }
    public string Name { get; set; }
    public string PicturePath { get; set; }
    public virtual Advertisements Advertisements { get; set; }

    }
    public enum AdType
    {
        Motoryzacja,
        Sport,
        Dom,
        Ogród,
        Usługi,
        Turystyka,
        Elektronika,
        Zdrowie
    }
}
