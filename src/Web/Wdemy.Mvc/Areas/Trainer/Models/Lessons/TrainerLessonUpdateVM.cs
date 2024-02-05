using Wdemy.Domain.Entities;
using Wdemy.Mvc.Areas.Trainer.Models.Videos;

namespace Wdemy.Mvc.Areas.Trainer.Models.Lessons
{
    public class TrainerLessonUpdateVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public IFormFile Document { get; set; } = null!;
        public TrainerVideoUpdateVM Video { get; set; } = null!;
    }
}
