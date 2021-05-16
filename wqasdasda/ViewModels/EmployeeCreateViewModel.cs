using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using wqasdasda.Models;

namespace wqasdasda.ViewModels
{
    public class EmployeeCreateViewModel
    {

        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 chars")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Office Email")]
        [RegularExpression(@"^[a-zA-z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9.]+$", ErrorMessage = "Invalid email")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public IFormFile Photos{ get; set; }
    }
}
