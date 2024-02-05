using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Sections;
using Wdemy.Application.Dtos.Students;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Dtos.Course
{
    public class CourseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int StudentCount { get; set; }
        public int TotalParts { get; set; }
        public int TotalLesson { get; set; }
        public TimeSpan TotalDuration { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid TrainerId { get; set; }

        public List<SectionDto> Sections { get; set; } = new();
        public  List<StudentDto> Students { get; set; } = new();
    }
}
