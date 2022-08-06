using CleanArchitectureDotNet.Domain.Models;

namespace CleanArchitectureDotNet.Domain.Interfaces
{
    public interface ICourseRepository
    {
        Task Add(Course course);
        Task<IEnumerable<Course>> Get();
    }
}
