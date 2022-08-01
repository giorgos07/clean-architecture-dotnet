using CleanArchitectureDotNet.Data.Context;
using CleanArchitectureDotNet.Domain.Interfaces;
using CleanArchitectureDotNet.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDotNet.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _dbContext;

        public CourseRepository(UniversityDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<IEnumerable<Course>> GetCourses()
        {
            var courses = await _dbContext.Courses.ToListAsync();
            return courses;
        }
    }
}
