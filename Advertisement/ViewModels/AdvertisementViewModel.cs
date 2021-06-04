﻿using Advertisement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advertisement.ViewModels
{
    public class AdvertisementViewModel
    {

        public int Id { get; set; }
        [Display(Name = "Tytuł")]
        [Required(ErrorMessage = "To pole musi być wypełnione")]
        public string Title { get; set; }

        [Display(Name = "Opis")]
        [Required(ErrorMessage = "To pole musi być wypełnione")]
        public string Description { get; set; }

        [Display(Name = "Zdjęcia")]
        [Required(ErrorMessage = "To pole musi być wypełnione")]
        public virtual ICollection<Pictures> PicturesCol { get; set; }

        [Display(Name = "Kategoria")]
        [Required(ErrorMessage = "To pole musi być wypełnione")]
        public AdType AdTypes { get; set; }

    }
}
