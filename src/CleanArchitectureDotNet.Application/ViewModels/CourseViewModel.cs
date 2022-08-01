using CleanArchitectureDotNet.Domain.Models;

namespace CleanArchitectureDotNet.Application.ViewModels
{
    public class CourseViewModel
    {
        public CourseViewModel(IEnumerable<Course> courses)
        {
            Courses = courses;
        }

        public IEnumerable<Course> Courses { get; }
    }
}
