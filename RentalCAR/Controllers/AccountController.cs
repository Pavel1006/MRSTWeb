using System.Web.Mvc;
using System.Web;
using BusinessLogic.Core;

public class AccountController : Controller
{
    private LoginBusiness _login = new LoginBusiness();

    [HttpGet]
    public ActionResult Login() => View();

    [HttpPost]
    public ActionResult Login(string username, string password)
    {
        if (_login.ValidateUser(username, password))
            return RedirectToAction("Index", "Home");

        ViewBag.Error = "Invalid login.";
        return View();
    }

    [HttpGet]
    public ActionResult Register() => View();

    [HttpPost]
    public ActionResult Register(string username, string email, string password)
    {
        if (_login.RegisterUser(username, email, password))
            return RedirectToAction("Login");

        ViewBag.Error = "Username or email already exists.";
        return View();
    }

    public ActionResult Logout()
    {
        if (Request.Cookies["AuthCookie"] != null)
        {
            var cookie = new HttpCookie("AuthCookie")
            {
                Expires = System.DateTime.Now.AddDays(-1)
            };
            Response.Cookies.Add(cookie);
        }
        return RedirectToAction("Login");
    }
}