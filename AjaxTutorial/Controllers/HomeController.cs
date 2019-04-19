using AjaxTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxTutorial.Controllers
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
        public ActionResult AddUser(UserModel model)
        {
            var user = new UserModel()
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password
            };
            return Json(user, JsonRequestBehavior.AllowGet);
        }



    }
}