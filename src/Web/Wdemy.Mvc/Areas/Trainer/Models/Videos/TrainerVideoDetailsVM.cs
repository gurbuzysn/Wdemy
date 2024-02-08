namespace Wdemy.Mvc.Areas.Trainer.Models.Videos
{
    public class TrainerVideoDetailsVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string DocumentUri { get; set; } = null!;
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string VideoUri { get; set; } = null!;
        public TimeSpan Duration { get; set; }
        public Guid SectionId { get; set; }
    }
}
