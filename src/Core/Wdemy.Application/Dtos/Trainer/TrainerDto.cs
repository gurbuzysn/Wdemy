using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Course;
using Wdemy.Domain.Entities;
using Wdemy.Domain.Enums;

namespace Wdemy.Application.Dtos.Trainer
{
    public class TrainerDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string? Image { get; set; }
        public Guid IdentityId { get; set; }

        public List<CourseDto> Courses { get; set; }

    }
}
