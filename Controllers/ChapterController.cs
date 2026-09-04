using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using HatDe.Models;
using System.Linq;
using System;
using System.Security.Claims;

namespace HatDe.Controllers
{
    [Authorize]
    public class ChapterController : Controller
    {
        private readonly AppDbContext _context;

        public ChapterController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Add(int storyId)
        {
            var story = _context.Stories.Find(storyId);
            if (story == null) return NotFound();

            ViewBag.StoryTitle = story.Title;
            var chapter = new Chapter { StoryId = storyId, IsVip = false, PriceInHatDe = 0 };
            return View(chapter);
        }

        [HttpPost]
        public IActionResult Add(Chapter chapter)
        {
            if (ModelState.IsValid)
            {
                _context.Chapters.Add(chapter);
                _context.SaveChanges();
                return RedirectToAction("Detail", "Story", new { id = chapter.StoryId });
            }
            return View(chapter);
        }

        // 1. Logic xử lý hiển thị nội dung đọc truyện
        public IActionResult Read(int id)
        {
            var chapter = _context.Chapters.Find(id);
            if (chapter == null) return NotFound();

            var story = _context.Stories.Find(chapter.StoryId);
            ViewBag.Story = story;

            int currentUserId = GetCurrentUserId();
            var user = _context.Users.Find(currentUserId);
            if (user == null)
            {
                return RedirectToAction("Login", "Account", new { returnUrl = $"/Chapter/Read/{id}" });
            }

            ViewBag.UserBalance = user.HatDeBalance;

            // Nếu là chương miễn phí -> Hiển thị nội dung luôn
            if (!chapter.IsVip)
            {
                return View(chapter);
            }

            // Nếu là chương VIP -> Kiểm tra xem user đã mở khóa trước đó chưa
            var unlocked = _context.UnlockedChapters
                .FirstOrDefault(u => u.UserId == currentUserId && u.ChapterId == chapter.Id);

            if (unlocked != null)
            {
                return View(chapter); // Đã mua rồi thì cho đọc
            }

            // Chưa mua -> Chuyển hướng sang giao diện khóa (Paywall)
            return View("Locked", chapter);
        }

        // 2. Logic xử lý trừ Hạt dẻ khi bấm mở khóa chương VIP
        [HttpPost]
        public IActionResult Unlock(int chapterId)
        {
            int currentUserId = GetCurrentUserId();
            var user = _context.Users.Find(currentUserId);
            var chapter = _context.Chapters.Find(chapterId);

            if (user == null || chapter == null) return NotFound();

            // Kiểm tra số dư Hạt dẻ
            if (user.HatDeBalance >= chapter.PriceInHatDe)
            {
                // Trừ tiền trong ví
                user.HatDeBalance -= chapter.PriceInHatDe;

                // Ghi nhận vào bảng lịch sử đã mở khóa
                _context.UnlockedChapters.Add(new UnlockedChapter
                {
                    UserId = currentUserId,
                    ChapterId = chapterId,
                    UnlockedAt = DateTime.Now
                });

                _context.SaveChanges();
                return RedirectToAction("Read", new { id = chapterId });
            }

            // Nếu không đủ tiền
            TempData["Error"] = "Số dư Hạt dẻ không đủ để mở khóa chương này!";
            return RedirectToAction("Read", new { id = chapterId });
        }

        private int GetCurrentUserId()
        {
            return int.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out var userId) ? userId : 0;
        }
    }
}