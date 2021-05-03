using ALLEGRO.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ALLEGRO.Controllers
{
    public class RegisterController : Controller
    {
        private static List<Users> _users = new List<Users>();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Users users)
        {
            var response = this.Request.Form["g-recaptcha-response"];
            string secretKey = "6LfSsKUaAAAAAByKyixdMRmE5fUsVYODflwK-Zs9";
            var client = new WebClient();
            var result = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretKey, response));
            var obj = JObject.Parse(result);
            var status = (bool)obj.SelectToken("success");
            ViewBag.Message = status ? " GIT" : " Wypełnij Captche";
            if (ModelState.IsValid && status)
            {
                _users.Add(users);
                using (var context = new AppContext())
                {
                    context.Database.EnsureCreated();
                    foreach (var item in _users)
                    {
                        context.Users.Add(new Users
                        {

                            FirstName = item.FirstName,
                            LastName = item.LastName,
                            Email = item.Email,
                            Login = item.Login,
                            Password = item.Password

                        });
                    }
                    context.SaveChanges();
                }
            }

            return View();
        }
        public IActionResult CheckEmail(string Email)
        {
            //var emails = new List<string>
            //{
            //    "okidoki",
            //    "nieoki"
            //};

            //bool emailExists = emails.Contains(Email);
            using(var context = new AppContext())
            {
                context.Database.EnsureCreated();
                var emails = context.Users.ToList();

                var emailExists = emails.Exists(x => x.Email == Email);

                return Json(!emailExists);
            }

        }
        public IActionResult CheckLogin(string Login)
        {
            using (var context = new AppContext())
            {
                context.Database.EnsureCreated();
                var logins = context.Users.ToList();

                var emailExists = logins.Exists(x => x.Login.ToLower() == Login.ToLower());
               

                return Json(!emailExists);
            }

        }
    }
}
