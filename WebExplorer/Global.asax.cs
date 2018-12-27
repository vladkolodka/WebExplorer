using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebExplorer.Infrastructure;

namespace WebExplorer
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AutofacConfig.ConfigureContainer();

            // TODO try to remove
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}