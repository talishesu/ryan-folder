using Microsoft.AspNetCore.Mvc;

namespace ryan.Controllers
{
    public class WorksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
