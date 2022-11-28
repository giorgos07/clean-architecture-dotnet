using AutoMapper;
using CleanArchitectureDotNet.Application.ViewModels;
using CleanArchitectureDotNet.Domain.Commands;
using CleanArchitectureDotNet.Domain.Models;

namespace CleanArchitectureDotNet.Application.ObjectMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCourseRequest, CreateCourseCommand>()
                .ConstructUsing(course => new CreateCourseCommand(course.Name, course.Description, course.ImageUrl));
            CreateMap<Course, CourseModel>();
            CreateMap<CreateCourseCommand, Course>();
        }
    }
}
