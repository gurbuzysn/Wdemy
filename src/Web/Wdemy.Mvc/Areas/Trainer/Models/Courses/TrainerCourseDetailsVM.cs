using Wdemy.Mvc.Areas.Trainer.Models.Sections;

namespace Wdemy.Mvc.Areas.Trainer.Models.Courses
{
    public class TrainerCourseDetailsVM
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

        public List<TrainerSectionDetailsVM>? Sections { get; set; }
    }
}
