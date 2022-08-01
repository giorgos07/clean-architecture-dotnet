using CleanArchitectureDotNet.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDotNet.Data.Context
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {
#if DEBUG
            Database.EnsureCreated();
#endif
        }

        public DbSet<Course> Courses { get; set; }
    }
}
