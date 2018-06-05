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

        public ActionResult Menu()
        {
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();
            List<Item> items = ORM.Items.ToList();
            ViewBag.Items = items;

            return View();
        }

        public ActionResult Add(int id)
        {
            CoffeeShopDBEntities db = new CoffeeShopDBEntities();

            //check if the Cart object already exists
            if (Session["Cart"] == null)
            {
                //if it doesn't, make a new list of books
                List<Item> cart = new List<Item>();
                //add this book to it
                cart.Add((from b in db.Items
                          where b.ProductID == id
                          select b).Single());
                //add the list to the session
                Session.Add("Cart", cart);
            }
            else
            {
                //if it does exist, get the list
                List<Item> cart = (List<Item>)(Session["Cart"]);
                //add this book to it
                cart.Add((from b in db.Items
                          where b.ProductID == id
                          select b).Single());
            }
            return View();
        }

        public ActionResult ItemListByQuantity(int Quantity)
        {
            CoffeeShopDBEntities db = new CoffeeShopDBEntities();

            //LINQ Query
            List<Item> itemsByQuantity = (from b in db.Items

                                where b.Quantity == Quantity

                                select b).ToList();

            ViewBag.Items = itemsByQuantity;

            return View("Menu");

        }
    }
}