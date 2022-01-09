using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ryan.Models.DataContexts;
using ryan.Models.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace ryan.Controllers
{
    public class ResumeController : Controller
    {
        readonly RyanDbContext db;
        public ResumeController(RyanDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            ResumeViewModel vm = new ResumeViewModel();
            vm.Experience = await db.Experience.Where(b => b.DeletedDate == null).ToListAsync();
            vm.Education = await db.Education.Where(b => b.DeletedDate == null).ToListAsync();
            vm.Design = await db.Design.Where(b => b.DeletedDate == null).ToListAsync();
            vm.Languages = await db.Languages.Where(b => b.DeletedDate == null).ToListAsync();
            vm.Coding = await db.Coding.Where(b => b.DeletedDate == null).ToListAsync();
            vm.Knowledge = await db.Knowledge.Where(b => b.DeletedDate == null).ToListAsync();
            vm.Testimonials = await db.Testimonials.Where(b => b.DeletedDate == null).ToListAsync();

            return View(vm);
        }
    }
}
