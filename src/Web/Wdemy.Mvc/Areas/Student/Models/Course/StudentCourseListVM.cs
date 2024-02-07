using Wdemy.Application.Dtos.Sections;

namespace Wdemy.Mvc.Areas.Student.Models.Course
{
    public class StudentCourseListVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int StudentCount { get; set; }
        public int TotalParts { get; set; }
        public int TotalLesson { get; set; }
        public TimeSpan TotalDuration { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid TrainerId { get; set; }

        public List<StudentSectionListVM> Sections { get; set; } = new();
    }
}
