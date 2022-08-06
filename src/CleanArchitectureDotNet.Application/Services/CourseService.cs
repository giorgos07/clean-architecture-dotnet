using CleanArchitectureDotNet.Application.Interfaces;
using CleanArchitectureDotNet.Application.ViewModels;
using CleanArchitectureDotNet.Domain.Interfaces;

namespace CleanArchitectureDotNet.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
        }

        public async Task<CourseViewModel> Get()
        {
            var courses = await _courseRepository.Get();
            return new CourseViewModel(courses);
        }
    }
}
