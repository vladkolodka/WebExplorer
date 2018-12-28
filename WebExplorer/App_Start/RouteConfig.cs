using System.Web.Mvc;
using System.Web.Routing;

namespace WebExplorer
{
    public class RouteConfig
    {
        private const string FolderPathPattern = @"^[a-z]+([a-z ])*(\/[a-z]+([a-z ])*)*\/?$";

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "FolderExplorer",
                "{*path}",
                new {controller = "Explorer", action = "Index"},
                new {path = FolderPathPattern}
            );

            routes.MapRoute(
                name: "Main page",
                url: "",
                defaults: new {controller = "Home", action = "Index"}
            );
        }
    }
}