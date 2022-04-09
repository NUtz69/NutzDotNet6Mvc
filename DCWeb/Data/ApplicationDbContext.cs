using DCWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace DCWeb.Data
{
    // 002 - Create Project DCWeb
    public class ApplicationDbContext : DbContext
    {
        // ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // DbSet
        public DbSet<Category>? Category { get; set; }
    }
}
