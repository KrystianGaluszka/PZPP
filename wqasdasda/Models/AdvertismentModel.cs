using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wqasdasda.Models
{
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

        public class AdvertisementModel
        {
            [Display(Name = "Nazwa przedmiotu")]
            [Required(ErrorMessage = "Nazwa musi mieć min. 6 znaków")]
            public string Title { get; set; }

            [Display(Name = "Opis przedmiotu")]
            [Required(ErrorMessage = "Opis musi zawierać min. 30 znaków")]
            public string Description { get; set; }

            public IEnumerable<IFormFile> Picture { get; set; }

            [Display(Name = "Kategoria")]
            public AdType? Category { get; set; }
        }
    }

