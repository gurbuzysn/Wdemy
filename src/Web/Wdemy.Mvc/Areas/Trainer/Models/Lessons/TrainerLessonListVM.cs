using Wdemy.Application.Dtos.Videos;
using Wdemy.Mvc.Areas.Trainer.Models.Videos;

namespace Wdemy.Mvc.Areas.Trainer.Models.Lessons
{
    public class TrainerLessonListVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public TimeSpan Duration { get; set; }
        public string DocumentUri { get; set; } = null!;
        public Guid SectionId { get; set; }
        public TrainerVideoListVM Video { get; set; } = null!;
    }
}
