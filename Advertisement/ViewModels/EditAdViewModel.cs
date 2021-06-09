using Advertisement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advertisement.ViewModels
{
    public class EditAdViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Tytuł")]
        public string Title { get; set; }
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Display(Name = "Kategoria")]
        public AdType AdTypes { get; set; }
    }
}
