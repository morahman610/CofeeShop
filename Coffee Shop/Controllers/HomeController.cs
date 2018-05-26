using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coffee_Shop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult NewUser(Int64 phoneNumber = 0, string email = null, string firstName = null, string lastName=null, 
            string password=null, string passConf=null, string favCoffee=null, string subscription = null)
        {

            ViewBag.Phone = phoneNumber;
            ViewBag.Email = email;
            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            ViewBag.Password = password;
            ViewBag.PassConf = passConf;
            ViewBag.FavCoffee = favCoffee;
            ViewBag.Subscription = subscription;


            return View();
        }
    }
}