using CleanArchitectureDotNet.Domain.Models;

namespace CleanArchitectureDotNet.Domain.Interfaces
{
    public interface ICourseRepository
    {
        Task Create(Course course);
        Task<IEnumerable<Course>> Get();
    }
}
