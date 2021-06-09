using Advertisement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advertisement.ViewModels
{
    public class EditAdViewModel
    {
        public string UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public AdType AdTypes { get; set; }
    }
}
