using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ryan.Models.DataContexts;
using ryan.Models.Entities;
using ryan.Models.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace ryan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutMeController : Controller
    {
        readonly RyanDbContext db;
        public AboutMeController(RyanDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {

            var AboutMe = await db.AboutMe.FirstOrDefaultAsync(b => b.DeletedDate == null);


            return View(AboutMe);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AboutMe model)
        {
                var aboutMe = await db.AboutMe.FirstOrDefaultAsync(b => b.DeletedDate == null);

                aboutMe.Info = model.Info;
                aboutMe.Age = model.Age;
                aboutMe.Residence = model.Residence;
                aboutMe.Freelance = model.Freelance;
                aboutMe.Address = model.Address;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
        }
    }
}
