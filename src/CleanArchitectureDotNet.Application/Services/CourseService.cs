using AutoMapper;
using CleanArchitectureDotNet.Application.Interfaces;
using CleanArchitectureDotNet.Application.ViewModels;
using CleanArchitectureDotNet.Domain.Commands;
using CleanArchitectureDotNet.Domain.Core.Bus;
using CleanArchitectureDotNet.Domain.Interfaces;

namespace CleanArchitectureDotNet.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _mediator;
        private readonly IMapper _mapper;

        public CourseService(
            ICourseRepository courseRepository,
            IMediatorHandler mediator,
            IMapper mapper
        )
        {
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task Create(CreateCourseRequest course)
        {
            var command = _mapper.Map<CreateCourseCommand>(course);
            await _mediator.SendCommand(command);
        }

        public async Task<IEnumerable<CourseModel>> Get()
        {
            var courses = await _courseRepository.Get();
            return courses.Select(course => _mapper.Map<CourseModel>(course));
        }
    }
}
