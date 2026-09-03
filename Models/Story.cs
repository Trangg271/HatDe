using System;

namespace HatDe.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public string? CoverImageUrl { get; set; }
        public string? AffiliateLink { get; set; }
    }
}