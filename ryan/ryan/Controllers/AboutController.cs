using Microsoft.AspNetCore.Mvc;

namespace ryan.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
