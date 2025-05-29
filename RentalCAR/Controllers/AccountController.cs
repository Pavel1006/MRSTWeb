using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic.Core;

namespace RentalCAR.Controllers
{
    public class AccountController : Controller
    {
        private readonly LoginBusiness _service = new LoginBusiness();

        [HttpGet]
        public ActionResult Register() => View();

        [HttpPost]
        public ActionResult Register(string username, string email, string password)
        {
            if (_service.RegisterUser(username, email, password))
                return RedirectToAction("Login");

            ViewBag.Message = "User already exists!";
            return View();
        }

        [HttpGet]
        public ActionResult Login() => View();

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (_service.ValidateUser(username, password))
            {
                Session["user"] = username;
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Message = "Invalid credentials";
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}