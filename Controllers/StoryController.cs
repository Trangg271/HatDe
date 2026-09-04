using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using HatDe.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HatDe.Controllers
{
    [Authorize]
    public class StoryController : Controller
    {
        private readonly AppDbContext _context;

        public StoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Detail(int id)
        {
            // Tìm truyện và lấy kèm danh sách các chương thuộc về truyện này
            var story = _context.Stories
                .FirstOrDefault(s => s.Id == id);

            if (story == null)
            {
                return NotFound();
            }

            // Lấy danh sách chương của truyện này sắp xếp theo ID tăng dần
            var chapters = _context.Chapters
                .Where(c => c.StoryId == id)
                .OrderBy(c => c.Id)
                .ToList();

            // Truyền danh sách chương qua ViewBag để hiển thị ở View
            ViewBag.Chapters = chapters;

            return View(story);
        }
    }
}