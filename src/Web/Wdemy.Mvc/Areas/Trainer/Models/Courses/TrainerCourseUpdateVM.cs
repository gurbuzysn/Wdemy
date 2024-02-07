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
        public Guid TrainerId { get; set; }
        public string LessonName { get; set; } = null!;
        public IFormFile VideoData { get; set; } = null!;
        public IFormFile? Document { get; set; }

        [BindProperty]
        public List<TrainerSectionUpdateVM> Sections { get; set; } = null!;
    }
}
