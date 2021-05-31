using Advertisement.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advertisement.Models.Validators
{
    public class AddAdValidator : AbstractValidator<AdvertisementViewModel>
    {
        public AddAdValidator()
        {
            RuleFor(x => x.Title).NotEmpty().Length(10, 70);
            RuleFor(x => x.Description).NotEmpty().Length(20, 1000);
            RuleFor(x => x.AdTypes).NotEmpty();
            //RuleFor(x=>x.PicturesCol).
        }
    }
}
