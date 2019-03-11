using CoinTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace CoinTracker.Controllers
{
    public class HomeController : Controller
    {

        UserDBContext db = new UserDBContext();

        public ActionResult Index()
        {

            ViewBag.Message = "Fifty States? No Problem!";

            return View();
        }

        public ActionResult Start()
        {

            ViewBag.Message = "Let's add to your collection!";

            return View();
        }

        public ActionResult AccountHome()
        {

            ViewBag.Title = "Acocunt Home";
            ViewBag.Message = "Welcome Back User";

            return View();
        }

        public ActionResult AccountCreated(User user)
        {

            db.Users.Add(user);
            db.SaveChanges();

            ViewBag.Title = "Account Created";
            ViewBag.Message = "Thanks for signing up, " + user.userName;
            

            return View();
        }

        public ActionResult CoinCare()
        {
            return View();
        }

        public ActionResult CoinStorage()
        {
            return View();
        }

        public ActionResult HelpfulLinks()
        {
            return View();
        }

        public ActionResult StateCoinProgramInfo()
        {
            return View();
        }

        public ActionResult FeaturedPage()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }


        [HttpPost]
        public ActionResult LogIn()
        {
            return RedirectToAction("AccountHome");
        }

        [HttpPost]
        public ActionResult CreateAccount(string username, string pwd, string confirmPwd)
        {
            if (pwd == confirmPwd)
            {
                User user = new User(username, pwd);

                return RedirectToAction("AccountCreated", user);
            }
            else
            {

                return RedirectToAction("Start");

            }

            }

    }
}
