using CleanArchitectureDotNet.Application.ViewModels;

namespace CleanArchitectureDotNet.Application.Interfaces
{
    public interface ICourseService
    {
        Task Create(CreateCourseRequest course);
        Task<IEnumerable<CourseModel>> Get();
    }
}
