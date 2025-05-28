using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalCAR.Controllers
{
    public class AccountController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page login.";

            return View();
        }

          public ActionResult Register()
        {
            ViewBag.Message = "Your contact page register.";

            return View();
        }
    }
}