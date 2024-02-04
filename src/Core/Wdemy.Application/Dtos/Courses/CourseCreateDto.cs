using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Trainer;

namespace Wdemy.Application.Dtos.Course
{
    public class CourseCreateDto
    {
        public string Name { get; set; } = null!;
        public Guid TrainerId { get; set; }

    }
}
