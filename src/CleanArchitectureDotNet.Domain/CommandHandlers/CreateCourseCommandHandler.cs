using CleanArchitectureDotNet.Domain.Commands;
using CleanArchitectureDotNet.Domain.Interfaces;
using CleanArchitectureDotNet.Domain.Models;
using MediatR;

namespace CleanArchitectureDotNet.Domain.CommandHandlers
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _courseRepository;

        public CreateCourseCommandHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
        }

        public async Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var newCourse = new Course
            {
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Name = request.Name
            };
            await _courseRepository.Add(newCourse);
            return true;
        }
    }
}
