using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Common.Base;

namespace Wdemy.Domain.Entities
{
    public class StudentCourse : AuditableEntity
    {
        public double ProgressRate { get; set; }
        public bool IsFinished { get; set; }

        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public virtual Student Student { get; set; } = null!;
        public virtual Course Course { get; set; } = null!;

    }
}
