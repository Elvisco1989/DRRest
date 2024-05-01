using Microsoft.EntityFrameworkCore;

namespace DRRest
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
       public DbSet<Music> music { get; set; } 
    }
}
