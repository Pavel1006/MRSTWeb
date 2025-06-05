using System;
using System.Web;
using System.Security.Principal;

namespace Helpers
{
    public static class AuthHelper
    {
        public static void SetPrincipalFromCookie()
        {
            var authCookie = System.Web.HttpContext.Current?.Request?.Cookies["AuthCookie"];
            if (authCookie != null)
            {
                string username = authCookie["Username"];
                string[] roles = authCookie["Roles"].Split(',');

                var identity = new GenericIdentity(username);
                var principal = new GenericPrincipal(identity, roles);

                System.Web.HttpContext.Current.User = principal; // <--- FIX HERE
            }
        }
    }
}