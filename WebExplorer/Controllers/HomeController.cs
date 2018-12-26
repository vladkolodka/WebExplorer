using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using WebExplorer.Entities;
using WebExplorer.Infrastructure;

namespace WebExplorer.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            dbContext.Database.CreateIfNotExists();
        }

        public ActionResult Index()
        {

            return View(/*_dbContext.Folders.Include(f => f.Children).FirstOrDefault(f => f.Id == 1)*/);
        }
    }
}