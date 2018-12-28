using System.Threading.Tasks;
using System.Web.Mvc;
using WebExplorer.Services;

namespace WebExplorer.Controllers
{
    public class ExplorerController : Controller
    {
        private readonly IFolderAliasService _aliasService;

        public ExplorerController(IFolderAliasService aliasService)
        {
            _aliasService = aliasService;
        }

        public async Task<ActionResult> Index(string path)
        {
            var folder = await _aliasService.FindByPath(path).ConfigureAwait(false);

            return folder == null
                ? View("Notification", (object) "Path not found.")
                : View(folder);
        }
    }
}