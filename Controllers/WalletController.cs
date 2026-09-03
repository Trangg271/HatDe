using Microsoft.AspNetCore.Mvc;
using HatDe.Models;
using System.Linq;

namespace HatDe.Controllers
{
    public class WalletController : Controller
    {
        private readonly AppDbContext _context;

        public WalletController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            int currentUserId = 1;
            var user = _context.Users.Find(currentUserId);
            
            if (user == null)
            {
                user = new User { Id = 1, Username = "DocGiaHatDe", HatDeBalance = 100 };
                _context.Users.Add(user);
                _context.SaveChanges();
            }

            return View(user);
        }

        [HttpPost]
        public IActionResult Deposit(int amount)
        {
            if (amount <= 0)
            {
                TempData["Error"] = "Số lượng nạp không hợp lệ!";
                return RedirectToAction("Index");
            }

            int currentUserId = 1;
            var user = _context.Users.Find(currentUserId);
            
            if (user != null)
            {
                user.HatDeBalance += amount;
                _context.SaveChanges();
                TempData["Success"] = $"🎉 Nạp thành công {amount} 🌰 Hạt Dẻ vào tài khoản!";
            }

            return RedirectToAction("Index");
        }

        // Thêm logic xử lý đổi Giftcode
        [HttpPost]
        public IActionResult RedeemCode(string codeInput)
        {
            if (string.IsNullOrWhiteSpace(codeInput))
            {
                TempData["Error"] = "Vui lòng nhập mã Giftcode!";
                return RedirectToAction("Index");
            }

            // Tìm mã trong Database
            var giftCode = _context.GiftCodes.FirstOrDefault(g => g.Code == codeInput.Trim() && !g.IsUsed);

            if (giftCode == null)
            {
                TempData["Error"] = "Mã Giftcode không tồn tại hoặc đã được sử dụng!";
                return RedirectToAction("Index");
            }

            int currentUserId = 1;
            var user = _context.Users.Find(currentUserId);

            if (user != null)
            {
                // Cộng Hạt dẻ cho user và đánh dấu mã đã sử dụng
                user.HatDeBalance += giftCode.RewardAmount;
                giftCode.IsUsed = true;
                _context.SaveChanges();

                TempData["Success"] = $"🎁 Nhận thành công {giftCode.RewardAmount} 🌰 Hạt Dẻ từ mã quà tặng!";
            }

            return RedirectToAction("Index");
        }
    }
}