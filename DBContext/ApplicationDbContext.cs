using HierarchicalDirectory.Models;
using Microsoft.EntityFrameworkCore;

namespace HierarchicalDirectory.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Catalog> Catalogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Catalog>().HasData(
                new List<Catalog>
                {
                    new Catalog { Id = 1, Name = "Creating Digital Images" },
                    new Catalog { Id = 2, Name = "Resources", ParentId = 1 },
                    new Catalog { Id = 3, Name = "Evidence" },
                    new Catalog { Id = 4, Name = "Graphic Products", ParentId = 1 },
                    new Catalog { Id = 5, Name = "Primary Sources", ParentId = 2 },
                    new Catalog { Id = 6, Name = "Secondary Sources", ParentId = 2 },
                    new Catalog { Id = 7, Name = "Process", ParentId = 4 },
                    new Catalog { Id = 8, Name = "Final Product", ParentId = 4 },
                });
        }
    }
}
