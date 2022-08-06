namespace CleanArchitectureDotNet.Domain.Commands
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(string name, string description = null, string imageUrl = null)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
