using Wdemy.Domain.Entities;
using Wdemy.Mvc.Areas.Trainer.Models.Lessons;

namespace Wdemy.Mvc.Areas.Trainer.Models.Sections
{
    public class TrainerSectionUpdateVM
    {
        public string Name { get; set; } = null!;

        public List<TrainerLessonUpdateVM> Lessons { get; set; } = null!;
    }
}
