namespace HatDe.Models
{
    public class Chapter
    {
        public int Id { get; set; }
        public int StoryId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public bool IsVip { get; set; }
        public int PriceInHatDe { get; set; } 
    }
}
