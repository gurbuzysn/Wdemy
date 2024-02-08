using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Dtos.Students;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Dtos.StudentCourses
{
    public class StudentCourseDto
    {
        public double ProgressRate { get; set; }
        public bool IsFinished { get; set; }

        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public  StudentDto Student { get; set; } = null!;
        public  CourseDto Course { get; set; } = null!;
    }
}
