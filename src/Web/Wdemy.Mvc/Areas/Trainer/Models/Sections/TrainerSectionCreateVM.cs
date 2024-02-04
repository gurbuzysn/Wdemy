using Wdemy.Domain.Entities;
using Wdemy.Mvc.Areas.Trainer.Models.Courses;

namespace Wdemy.Mvc.Areas.Trainer.Models.Sections
{
    public class TrainerSectionCreateVM
    {
        public string SectionName { get; set; } = null!;
        public Guid CourseId { get; set; }
        public TrainerCourseUpdateVM Course { get; set; }
    }
}
