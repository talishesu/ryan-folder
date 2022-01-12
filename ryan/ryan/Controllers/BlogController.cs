using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ryan.Models.DataContexts;
using ryan.Models.Entities;
using ryan.Models.ViewModels;
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
            BlogViewModel vm = new BlogViewModel();
            vm.Blog = await db.Blog.FirstOrDefaultAsync(b => b.Id == id);
            if (vm.Blog == null)
            {
                return NotFound();
            }
            vm.BlogComment = await db.BlogComment.Where(b => b.BlogId == id && b.DeletedDate == null).ToListAsync();
            if (vm.Blog.DeletedDate != null)
            {
                return NotFound();
            }
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Create(BlogViewModel comment)
        {
                var BlogComment = comment.SimpleComment;
                await db.BlogComment.AddAsync(BlogComment);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
        }
    }
}
