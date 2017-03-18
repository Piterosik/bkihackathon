using Microsoft.EntityFrameworkCore;

namespace hackathon.Models
{
    public class WasherDb : DbContext
    {
        public WasherDb(DbContextOptions options) : base(options) {}
        public DbSet<Cloth> Cloths { get; set; }
        public DbSet<User.User> Users { get; set; }

        public WasherDb() {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Filename=hackathon.db");
        }
    }
}