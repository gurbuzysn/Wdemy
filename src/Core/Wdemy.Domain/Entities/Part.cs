using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Common.Base;

namespace Wdemy.Domain.Entities
{
    public class Part : AuditableEntity
    {
        public string Name { get; set; } = null!;
        public int LessonCount { get; set; }
        public TimeSpan TotalDuration { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; } = new HashSet<Lesson>();
    }
}
