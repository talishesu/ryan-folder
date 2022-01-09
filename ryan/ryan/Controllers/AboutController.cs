using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ryan.Models.DataContexts;
using ryan.Models.ViewModels;
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
        public async  Task<IActionResult> Index()
        {
            AboutViewModel vm = new AboutViewModel();
            vm.AboutMe = await db.AboutMe.FirstOrDefaultAsync(b => b.DeletedDate == null);
            vm.Quote = await db.Quote.FirstOrDefaultAsync(b => b.DeletedDate == null);
            vm.Pricing = await db.Pricing.Where(b => b.DeletedDate == null).ToListAsync();
            vm.PricingAdvantages = await db.PricingAdvantages.Where(b => b.DeletedDate == null).ToListAsync();
            vm.FunFact = await db.FunFact.Where(b => b.DeletedDate == null).ToListAsync();
            vm.Clients = await db.Clients.Where(b => b.DeletedDate == null).ToListAsync();
            vm.MyServices = await db.MyServices.Where(b => b.DeletedDate == null).ToListAsync();

            return View(vm);
        }
    }
}
