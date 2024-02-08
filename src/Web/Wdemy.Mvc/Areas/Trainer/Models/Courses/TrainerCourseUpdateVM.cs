using Microsoft.AspNetCore.Mvc;
using Wdemy.Domain.Entities;
using Wdemy.Mvc.Areas.Trainer.Models.Sections;

namespace Wdemy.Mvc.Areas.Trainer.Models.Courses
{
    public class TrainerCourseUpdateVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid TrainerId { get; set; }
        public string? LessonName { get; set; }
        public IFormFile? VideoData { get; set; }
        public IFormFile? Document { get; set; }
        public Guid SectionId { get; set; }

        public List<TrainerSectionUpdateVM>? Sections { get; set; }
    }
}
