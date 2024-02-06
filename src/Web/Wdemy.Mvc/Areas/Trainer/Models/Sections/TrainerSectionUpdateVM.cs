using Wdemy.Domain.Entities;
using Wdemy.Mvc.Areas.Trainer.Models.Lessons;

namespace Wdemy.Mvc.Areas.Trainer.Models.Sections
{
    public class TrainerSectionUpdateVM
    {
        public Guid Id { get; set; }
        public string SectionName { get; set; } = null!;
        public Guid CourseId { get; set; }

        public List<TrainerLessonUpdateVM> Lessons { get; set; } = null!;
    }
}
