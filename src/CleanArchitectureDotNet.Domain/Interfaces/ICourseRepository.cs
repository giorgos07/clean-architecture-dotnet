using CleanArchitectureDotNet.Domain.Models;

namespace CleanArchitectureDotNet.Domain.Interfaces
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetCourses();
    }
}
