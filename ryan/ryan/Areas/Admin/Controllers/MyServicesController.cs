using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ryan.Models.DataContexts;
using System.Linq;
using System.Threading.Tasks;

namespace ryan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MyServicesController : Controller
    {
        readonly RyanDbContext db;
        public MyServicesController(RyanDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {

            var MyServices = await db.MyServices.Where(b => b.DeletedDate == null).ToListAsync();


            return View(MyServices);
        }

        
        public async Task<IActionResult> Detail(int id)
            {
            var AboutMe = await db.MyServices.FirstOrDefaultAsync(b => b.Id == id);
            if(AboutMe == null)
            {
                NotFound();
            }
            return View(AboutMe);
        }
    }
}
