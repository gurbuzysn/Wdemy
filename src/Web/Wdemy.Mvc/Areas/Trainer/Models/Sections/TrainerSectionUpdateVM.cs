using Wdemy.Domain.Entities;
using Wdemy.Mvc.Areas.Trainer.Models.Videos;

namespace Wdemy.Mvc.Areas.Trainer.Models.Sections
{
    public class TrainerSectionUpdateVM
    {
        public Guid Id { get; set; }
        public string SectionName { get; set; } = null!;
        public Guid CourseId { get; set; }
        public string? LessonName { get; set; }
        public IFormFile? VideoData { get; set; }
        public IFormFile? Document { get; set; }

        public List<TrainerVideoUpdateVM> Videos { get; set; } = new();
    }
}
