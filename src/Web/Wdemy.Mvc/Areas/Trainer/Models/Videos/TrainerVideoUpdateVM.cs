namespace Wdemy.Mvc.Areas.Trainer.Models.Videos
{
    public class TrainerVideoUpdateVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        //public IFormFile? DocumentUri { get; set; }
        //public IFormFile VideoData { get; set; } = null!;
        public string? DocumentUri { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? VideoUri { get; set; }
        public TimeSpan Duration { get; set; }
        public Guid SectionId { get; set; }
    }
}
