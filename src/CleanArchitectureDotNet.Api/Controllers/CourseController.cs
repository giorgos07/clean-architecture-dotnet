using CleanArchitectureDotNet.Application.Interfaces;
using CleanArchitectureDotNet.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace CleanArchitectureDotNet.Api.Controllers
{
    [ApiController]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    [Route("api/courses")]
    public class CourseController : ControllerBase
    {
        private readonly ILogger<CourseController> _logger;
        private readonly ICourseService _courseService;

        public CourseController(ILogger<CourseController> logger, ICourseService courseService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _courseService = courseService ?? throw new ArgumentNullException(nameof(courseService));
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<CourseModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCourses()
        {
            var courses = await _courseService.Get();
            return Ok(courses);
        }

        [HttpPost]
        [ProducesResponseType(typeof(void), StatusCodes.Status204NoContent)]
        public async Task<IActionResult> CreateCourse([FromBody] CreateCourseRequest request)
        {
            await _courseService.Create(request);
            return NoContent();
        }
    }
}
