namespace Wdemy.Mvc.Areas.Trainer.Models
{
    public class TrainerCourseListVM
    {
        public string Name { get; set; } = null!;
        public int StudentCount { get; set; }
        public int TotalParts { get; set; }
        public int TotalLesson { get; set; }
        public TimeSpan TotalDuration { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
