using BlogV1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogV1.Context
{
    public class BlogDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-ERDEM\\SQLEXPRESS; database=BlogV1; Integrated Security=True; TrustServerCertificate=True;");
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}
