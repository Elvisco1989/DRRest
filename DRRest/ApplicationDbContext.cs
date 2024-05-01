using Microsoft.EntityFrameworkCore;

namespace DRRest
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        DbSet<Music> music { get; set; } 
    }
}
