using AjaxjsonFormat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxjsonFormat.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public JsonResult GetCustomer()
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<Customer> plist = db.Customers.ToList();
            return Json(plist, JsonRequestBehavior.AllowGet); 
        }
    }
}