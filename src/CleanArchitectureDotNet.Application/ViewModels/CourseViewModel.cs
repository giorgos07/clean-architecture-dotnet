using CleanArchitectureDotNet.Domain.Models;

namespace CleanArchitectureDotNet.Application.ViewModels
{
    public class CourseViewModel
    {
        public CourseViewModel(IEnumerable<CourseModel> courses)
        {
            Courses = courses;
        }

        public IEnumerable<CourseModel> Courses { get; }
    }
}
