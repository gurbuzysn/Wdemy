using Wdemy.Mvc.Areas.Trainer.Models.Videos;

namespace Wdemy.Mvc.Areas.Trainer.Models.Sections
{
    public class TrainerSectionListVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public int LessonCount { get; set; }
        public TimeSpan TotalDuration { get; set; }
        public Guid CourseId { get; set; }

        public List<TrainerVideoListVM> Videos { get; set; } = new();
    }
}
