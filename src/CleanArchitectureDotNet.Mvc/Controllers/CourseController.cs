using CleanArchitectureDotNet.Application.Interfaces;
using CleanArchitectureDotNet.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureDotNet.Mvc.Controllers
{
    [Authorize]
    [Route("courses")]
    public class CourseController : Controller
    {
        public static readonly string Name = "Course";
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService ?? throw new ArgumentNullException(nameof(courseService));
        }

        [HttpGet]
        public async Task<ViewResult> List()
        {
            var courses = await _courseService.Get();
            return View(new CourseViewModel(courses));
        }
    }
}
