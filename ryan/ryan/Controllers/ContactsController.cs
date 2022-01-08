using Microsoft.AspNetCore.Mvc;

namespace ryan.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
