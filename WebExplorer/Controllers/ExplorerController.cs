using System.Web.Mvc;

namespace WebExplorer.Controllers
{
    public class ExplorerController : Controller
    {
        public ActionResult Index(string path)
        {
            return Content($"Matched: {path} | {path?.Length}");
        }
    }
}