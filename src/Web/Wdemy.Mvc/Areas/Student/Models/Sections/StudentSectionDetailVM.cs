using Wdemy.Application.Dtos.Videos;
using Wdemy.Mvc.Areas.Student.Models.Videos;

namespace Wdemy.Mvc.Areas.Student.Models.Sections
{
    public class StudentSectionDetailVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public int LessonCount { get; set; }
        public TimeSpan TotalDuration { get; set; }
        public Guid CourseId { get; set; }

        public List<StudentVideoDetailVM> Videos { get; set; } = new();
    }
}
