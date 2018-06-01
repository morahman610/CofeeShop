using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coffee_Shop.Models;

namespace Coffee_Shop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();
            ViewBag.Items = ORM.Items.ToList();
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

        public ActionResult NewUser(Item data)
        {
            
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();

            if(ModelState.IsValid)
            {
                ORM.Items.Add(data);
                ORM.SaveChanges();
                ViewBag.User = ORM.Users.ToList();

                ViewBag.message = "Registration Sucessful!";

            }
            else
            {
                ViewBag.message = "Invalid onformation entered. Registration is not complete.";
            }




            return View();
        }
    }
}