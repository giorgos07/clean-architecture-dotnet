using CleanArchitectureDotNet.Application.Interfaces;
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
            var model = await _courseService.GetCourses();
            return View(model);
        }
    }
}
