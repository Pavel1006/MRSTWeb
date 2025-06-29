﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalCAR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = User.Identity.IsAuthenticated
                ? $"Welcome, {User.Identity.Name}!"
                : "You are not logged in.";
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
       /* public ActionResult Register()
        {
            ViewBag.Message = "Your contact page register.";

            return View();
        }*/
    }
}