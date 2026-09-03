namespace HatDe.Models
{
    public class GiftCode
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public int RewardAmount { get; set; } // Số Hạt dẻ phần thưởng
        public bool IsUsed { get; set; } = false; // Trạng thái đã dùng hay chưa
    }
}