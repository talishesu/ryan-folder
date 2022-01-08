using Microsoft.AspNetCore.Mvc;
using riode.Models.ViewModels;
using ryan.Models.DataContexts;

namespace ryan.Controllers
{
    public class AboutController : Controller
    {
        readonly RyanDbContext db;
        public AboutController(RyanDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            AboutViewModel vm = new AboutViewModel();
            return View(vm);
        }
    }
}
