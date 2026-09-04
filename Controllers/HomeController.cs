using Microsoft.AspNetCore.Mvc;
using HatDe.Models;
using System.Linq;

namespace HatDe.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        // Yêu cầu hệ thống cung cấp (Inject) AppDbContext
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            _context.VisitLogs.Add(new VisitLog { VisitedAt = DateTime.UtcNow });
            _context.SaveChanges();

            // Lấy toàn bộ danh sách truyện từ Database và truyền ra View
            var stories = _context.Stories.ToList();
            return View(stories);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}