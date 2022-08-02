using CleanArchitectureDotNet.Domain.Models;

namespace CleanArchitectureDotNet.Data.Context
{
    internal static class UniversityDbContextExtensions
    {
        public static void SeedData(this UniversityDbContext dbContext)
        {
            var coursesExist = dbContext.Courses.Any();
            if (coursesExist)
            {
                return;
            }
            dbContext.Courses.AddRange(
                new Course { Name = "Physics", Description = "Introduction to Physics.", ImageUrl = "/img/art-ball-shaped-circle-414860.jpg" },
                new Course { Name = "Chemistry", Description = "Introduction to Chemistry.", ImageUrl = "/img/blue-bubble-crystal-clear-132477.jpg" },
                new Course { Name = "Mathematics", Description = "Introduction to Mathematics.", ImageUrl = "/img/book-education-graphing-paper-167682.jpg" }
            );
            dbContext.SaveChanges();
        }
    }
}
