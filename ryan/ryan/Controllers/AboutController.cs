using Microsoft.AspNetCore.Mvc;
using riode.Models.ViewModels;
using ryan.Models.DataContexts;
using System.Linq;
using System.Threading.Tasks;

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

            return View();
        }
    }
}
