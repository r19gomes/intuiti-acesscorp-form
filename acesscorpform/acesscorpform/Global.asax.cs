using AspNetMvc.UI;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace acesscorpform
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
