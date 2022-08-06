using CleanArchitectureDotNet.Application.ViewModels;

namespace CleanArchitectureDotNet.Application.Interfaces
{
    public interface ICourseService
    {
        Task<CourseViewModel> Get();
    }
}
