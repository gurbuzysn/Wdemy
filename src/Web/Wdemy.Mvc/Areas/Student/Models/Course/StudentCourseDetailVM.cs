using Wdemy.Application.Dtos.Sections;
using Wdemy.Mvc.Areas.Student.Models.Sections;

namespace Wdemy.Mvc.Areas.Student.Models.Course
{
    public class StudentCourseDetailVM
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int StudentCount { get; set; }
        public int TotalParts { get; set; }
        public int TotalLesson { get; set; }
        public TimeSpan TotalDuration { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<StudentSectionDetailVM> Sections { get; set; } = new();
    }
}
