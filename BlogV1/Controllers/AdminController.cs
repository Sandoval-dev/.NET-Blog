using BlogV1.Context;
using Microsoft.AspNetCore.Mvc;

namespace BlogV1.Controllers
{
    public class AdminController : Controller
    {
        private readonly BlogDbContext _context;

        public AdminController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blogs()
        {
            var blogs = _context.Blogs.ToList();
            return View(blogs);
        }
    }
}
