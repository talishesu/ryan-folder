using Microsoft.AspNetCore.Mvc;

namespace ryan.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
