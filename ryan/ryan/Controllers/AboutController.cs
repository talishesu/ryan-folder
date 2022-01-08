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
            vm.About = await db.About.FirstOrDefaultAsync();
            vm.AboutMe = await db.AboutMe.FirstOrDefaultAsync();
            vm.Quote = await db.Quote.FirstOrDefaultAsync();
            vm.Pricing = await db.Pricing.ToListAsync();
            vm.PricingAdvantages = await db.PricingAdvantages.ToListAsync();
            vm.FunFact = await db.FunFact.ToListAsync();
            vm.Clients = await db.Clients.ToListAsync();
            vm.MyServices = await db.MyServices.ToListAsync();

            return View(vm);
        }
    }
}
