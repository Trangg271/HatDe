using Microsoft.EntityFrameworkCore;

namespace HatDe.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Story> Stories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<UnlockedChapter> UnlockedChapters { get; set; }
        public DbSet<GiftCode> GiftCodes { get; set; }
    }
}