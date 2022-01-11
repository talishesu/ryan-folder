using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ryan.Models.DataContexts;
using System.Linq;
using System.Threading.Tasks;

namespace ryan.Controllers
{
    public class BlogController : Controller
    {
        readonly RyanDbContext db;
        public BlogController(RyanDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            var blogs = await db.Blog.Where(b => b.DeletedDate == null).ToListAsync();
            return View(blogs);
        }
        public async Task<IActionResult> Detail([FromRoute] int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var blog = await db.Blog.FirstOrDefaultAsync(b => b.Id == id);
            if (blog == null)
            {
                return NotFound();
            }
            if (blog.DeletedDate != null)
            {
                return NotFound();
            }
            return View(blog);
        }
    }
}
