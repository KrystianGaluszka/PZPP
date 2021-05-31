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
    public class LoginValidatorTests
    {
        [Test]
        public void ShouldValidateIfLoginAndPasswordAreProvided()
        {
            var loginVM = new LoginViewModel
            {
                Login = "LoginTest",
                Password = "Test12#"
            };
            var validator = new LoginValidator();

            var result = validator.Validate(loginVM);

            Assert.IsTrue(result.IsValid);
        }

        [Test]
        public void ShouldNotValidateIfLoginIsNotProvided()
        {
            var loginVM = new LoginViewModel
            {
                Password = "test123"
            };
            var validator = new LoginValidator();

            var result = validator.Validate(loginVM);

            Assert.IsFalse(result.IsValid);
        }

        [Test]
        public void ShouldNotValidateIfPasswordIsNotProvided()
        {
            var loginVM = new LoginViewModel
            {
                Login = "LoginTest",
            };
            var validator = new LoginValidator();

            var result = validator.Validate(loginVM);

            Assert.IsFalse(result.IsValid);
        }

    }
}
