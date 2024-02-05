using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Lessons;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Dtos.Sections
{
    public class SectionDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public int LessonCount { get; set; }
        public TimeSpan TotalDuration { get; set; }
        public Guid CourseId { get; set; }

        public List<LessonDto> Lessons { get; set; } = new();
    }
}
