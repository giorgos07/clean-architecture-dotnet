using CleanArchitectureDotNet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CleanArchitectureDotNet.Data.Context
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {
#if DEBUG
            if (Database.EnsureCreated())
            {
                this.SeedData();
            }
#endif
        }

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
