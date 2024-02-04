namespace Wdemy.Mvc.Areas.Trainer.Models
{
    public class TrainerCourseCreateVM
    {
        public string Name { get; set; } = null!;
        public Guid TrainerId { get; set; }
    }
}
