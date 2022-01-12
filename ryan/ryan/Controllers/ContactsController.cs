using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ryan.Models.DataContexts;
using ryan.Models.Entities;
using ryan.Models.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace ryan.Controllers
{
    public class ContactsController : Controller
    {
        readonly RyanDbContext db;
        public ContactsController(RyanDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            ContactViewModel vm = new ContactViewModel();
            vm.Contact = await db.Contact.FirstOrDefaultAsync(b=>b.DeletedDate == null);
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContactForm ContactMessage)
        {
            await db.ContactForm.AddAsync(ContactMessage);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
