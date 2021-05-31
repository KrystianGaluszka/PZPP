using Advertisement.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advertisement.Models.Validators
{
    public class RegisterValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Login).NotEmpty();
            RuleFor(x => x.Password).NotEmpty().Length(6,40);
            RuleFor(x => x.ConfrirmPassword).NotEmpty().Equal(x=>x.Password);
        }
    }
}
