using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Videos;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Dtos.Lessons
{
    public class LessonDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public TimeSpan Duration { get; set; }
        public string DocumentUri { get; set; } = null!;
        public Guid SectionId { get; set; }
        public VideoDto Video { get; set; } = null!;
    }
}
