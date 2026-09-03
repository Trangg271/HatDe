using System;

namespace HatDe.Models
{
    public class UnlockedChapter
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ChapterId { get; set; }
        public DateTime UnlockedAt { get; set; }
    }
}