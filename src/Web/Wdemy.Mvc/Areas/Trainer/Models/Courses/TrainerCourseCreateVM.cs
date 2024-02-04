namespace Wdemy.Mvc.Areas.Trainer.Models.Courses
{
    public class TrainerCourseCreateVM
    {
        public string Name { get; set; } = null!;
        public Guid TrainerId { get; set; }
    }
}
