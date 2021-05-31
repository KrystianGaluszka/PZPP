using Advertisement.Models.Validators;
using Advertisement.ViewModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advertisement.AdvertisementTest
{
    [TestFixture]
    public class RegisterValidatorTests
    {
        [Test]
        public void ShouldValidateIfAllRequiredPropertiesAreProvided()
        {
            var userVM = new RegisterViewModel
            {
                FirstName = "Stachu",
                LastName = "Wdomu",
                Email = "Stachu@house.pl",
                Login = "Staszek12",
                Password = "Test12#",
                ConfrirmPassword = "Test12#"
            };
            var validator = new RegisterValidator();
            var result = validator.Validate(userVM);
            Assert.IsTrue(result.IsValid);
        }

        [Test]
        public void ShouldNotValidateIfFirstNameIsNotProvided()
        {
            var userVM = new RegisterViewModel
            {
                LastName = "Wdomu",
                Email = "Stachu@house.pl",
                Login = "Staszek12",
                Password = "Test12#",
                ConfrirmPassword = "Test12#"
            };
            var validator = new RegisterValidator();
            var result = validator.Validate(userVM);
            Assert.IsFalse(result.IsValid);
        }
        [Test]
        public void ShouldNotValidateIfLastNameIsNotProvided()
        {
            var userVM = new RegisterViewModel
            {
                FirstName = "Stachu",
                Email = "Stachu@house.pl",
                Login = "Staszek12",
                Password = "Test12#",
                ConfrirmPassword = "Test12#"
            };
            var validator = new RegisterValidator();
            var result = validator.Validate(userVM);
            Assert.IsFalse(result.IsValid);
        }
        [Test]
        public void ShouldNotValidateIfEmailIsNotProvided()
        {
            var userVM = new RegisterViewModel
            {
                FirstName = "Stachu",
                LastName = "Wdomu",
                Login = "Staszek12",
                Password = "Test12#",
                ConfrirmPassword = "Test12#"
            };
            var validator = new RegisterValidator();
            var result = validator.Validate(userVM);
            Assert.IsFalse(result.IsValid);
        }
        [Test]
        public void ShouldNotValidateIfLoginIsNotProvided()
        {
            var userVM = new RegisterViewModel
            {
                FirstName = "Stachu",
                LastName = "Wdomu",
                Email = "Stachu@house.pl",
                Password = "Test12#",
                ConfrirmPassword = "Test12#"
            };
            var validator = new RegisterValidator();
            var result = validator.Validate(userVM);
            Assert.IsFalse(result.IsValid);
        }
        [Test]
        public void ShouldNotValidateIfPasswordIsNotProvided()
        {
            var userVM = new RegisterViewModel
            {
                FirstName = "Stachu",
                LastName = "Wdomu",
                Email = "Stachu@house.pl",
                Login = "Staszek12"
            };
            var validator = new RegisterValidator();
            var result = validator.Validate(userVM);
            Assert.IsFalse(result.IsValid);
        }
        public void ShouldNotValidateIfPasswordIsNotEqual()
        {
            var userVM = new RegisterViewModel
            {
                LastName = "Wdomu",
                Email = "Stachu@house.pl",
                Login = "Staszek12",
                Password = "Test12#",
                ConfrirmPassword = "Test12222#"
            };
            var validator = new RegisterValidator();
            var result = validator.Validate(userVM);
            Assert.IsFalse(result.IsValid);
        }
    }
}
