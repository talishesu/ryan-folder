using Microsoft.AspNetCore.Mvc;

namespace ryan.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
