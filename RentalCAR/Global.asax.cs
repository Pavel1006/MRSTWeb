using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using Helpers;

namespace RentalCAR
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DbSeeder.EnsureRolesExist();
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            AuthHelper.SetPrincipalFromCookie();
        }

    }
}
