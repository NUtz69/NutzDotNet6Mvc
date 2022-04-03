using Microsoft.EntityFrameworkCore;
using NutzWeb.Models;

namespace NutzWeb.Data
{
    // 000 - Create Project
    public class ApplicationDbContext : DbContext
    {
        // ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // DbSet
        public DbSet<Category> Categories { get; set; }
    }
}
