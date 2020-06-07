using ReactMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactMVC.Controllers
{
    public class DataController : Controller
    {
        public IList<FoodItem> menuItems;
        // GET: Data
        [HttpGet]
        public ActionResult GetMenuList()
        {
            menuItems = new List<FoodItem>();
            using(var db= new AppDbContext())
            {
                foreach (var f in db.FoodItems)
                {
                    menuItems.Add(f);
                }
            }
            return Json(menuItems, JsonRequestBehavior.AllowGet);
        }

        //Get user id
        [HttpGet]
        public string GetUserID()
        {
            return "1";
        }
        [HttpPost]
        public ActionResult PlaceOrder()
        {
            return null;
        }
    }
}