using Wdemy.Application.Dtos.Sections;
using Wdemy.Application.Dtos.Students;
using Wdemy.Mvc.Areas.Trainer.Models.Sections;
using Wdemy.Mvc.Areas.Trainer.Models.Students;

namespace Wdemy.Mvc.Areas.Trainer.Models.Courses
{
    public class TrainerCourseListVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int StudentCount { get; set; }
        public int TotalParts { get; set; }
        public int TotalLesson { get; set; }
        public TimeSpan TotalDuration { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<TrainerSectionListVM> Sections { get; set; } = new();
        public List<TrainerStudentListVM> Students { get; set; } = new();
    }
}
