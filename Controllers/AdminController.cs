using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using HatDe.Models;
using System.Linq;

namespace HatDe.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Dashboard()
        {
            var today = DateTime.UtcNow.Date;
            var model = new AdminDashboardViewModel
            {
                TotalVisits = _context.VisitLogs.Count(),
                TodayVisits = _context.VisitLogs.Count(visit => visit.VisitedAt >= today),
                TotalUsers = _context.Users.Count(),
                TotalStories = _context.Stories.Count(),
                TotalChapters = _context.Chapters.Count(),
                ActiveGiftCodes = _context.GiftCodes.Count(code => !code.IsUsed)
            };

            return View(model);
        }

        // 1. Gửi form trống ra màn hình cho bạn nhập
        [HttpGet]
        public IActionResult CreateStory()
        {
            return View();
        }

        // 2. Nhận dữ liệu khi bạn bấm nút "Lưu" và cất vào Database
        [HttpPost]
        public IActionResult CreateStory(Story story)
        {
            if (ModelState.IsValid)
            {
                _context.Stories.Add(story);
                _context.SaveChanges();
                
                // Lưu xong thì quay tự động về Trang chủ để xem thành quả
                return RedirectToAction("Index", "Home"); 
            }
            return View(story);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteStory(int id)
        {
            var story = _context.Stories.Find(id);
            if (story != null)
            {
                _context.Stories.Remove(story);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }

        // 3. Hiển thị danh sách Giftcode và form tạo mã mới
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult ManageGiftCodes()
        {
            var codes = _context.GiftCodes.OrderByDescending(g => g.Id).ToList();
            return View(codes);
        }

        // 4. Xử lý tạo Giftcode mới
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public IActionResult CreateGiftCode(string code, int rewardAmount)
        {
            if (string.IsNullOrWhiteSpace(code) || rewardAmount <= 0)
            {
                TempData["Error"] = "Vui lòng nhập mã và số lượng Hạt dẻ hợp lệ!";
                return RedirectToAction("ManageGiftCodes");
            }

            // Kiểm tra xem mã đã tồn tại chưa
            var existing = _context.GiftCodes.FirstOrDefault(g => g.Code == code.Trim());
            if (existing != null)
            {
                TempData["Error"] = "Mã Giftcode này đã tồn tại!";
                return RedirectToAction("ManageGiftCodes");
            }

            _context.GiftCodes.Add(new GiftCode
            {
                Code = code.Trim().ToUpper(),
                RewardAmount = rewardAmount,
                IsUsed = false
            });
            _context.SaveChanges();

            TempData["Success"] = "🎉 Tạo mã Giftcode thành công!";
            return RedirectToAction("ManageGiftCodes");
        }
    }
}