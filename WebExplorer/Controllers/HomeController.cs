using System.Web.Mvc;

namespace WebExplorer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Notification", (object) "Please enter the folder path into the address bar.");
        }
    }
}