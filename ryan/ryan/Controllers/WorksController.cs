using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ryan.Models.DataContexts;
using System.Linq;
using System.Threading.Tasks;

namespace ryan.Controllers
{
    public class WorksController : Controller
    {
        readonly RyanDbContext db;
        public WorksController(RyanDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            var works = await db.Works.Where(b=>b.DeletedDate == null).ToListAsync();
            return View(works);
        }
    }
}
