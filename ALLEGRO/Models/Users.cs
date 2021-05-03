using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ALLEGRO.Models
{
    public class Users
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Wpisz Imie")]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Wpisz Nazwisko")]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Wpisz Login")]
        [Remote("CheckLogin", "Register", ErrorMessage = "Użytkownik o podanym loginie już istnieje")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Wpisz Hasło")]
        //[StringLength(25, ErrorMessage = "{0} musi być przynajmniej {2}  i maksymalnie {1} znaków.", MinimumLength = 6)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{6,}$", ErrorMessage = "Hasło musi zawierać min. 6 znaków, 1 duża litere, cyfre, znak specjalny")]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Potwierdz Hasło")]
        [Compare("Password", ErrorMessage = "Hasła muszą być takie same")]
        [Display(Name = "Potwierdź hasło")]
        public string ConfirmPassword { get; set; }

        
        [Required(ErrorMessage = "Wpisz Email")]
        [Remote("CheckEmail", "Register", ErrorMessage = "Użytkownik o podanym mailu już istnieje")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail nie poprawny")]
        public string Email { get; set; }

        [Display(Name = "Zdjęcie Profilowe")]
        public string PicPath { get; set; }
    }
}
