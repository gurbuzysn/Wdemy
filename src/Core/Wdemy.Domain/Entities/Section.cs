using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Common.Base;

namespace Wdemy.Domain.Entities
{
    public class Section : AuditableEntity
    {
        public string Name { get; set; } = null!;
        public int LessonCount { get; set; }
        public TimeSpan TotalDuration { get; set; }
        public Guid CourseId { get; set; }


        public virtual Course Course { get; set; } = null!;
        public virtual ICollection<Video> Videos { get; set; } = new HashSet<Video>();
    }
}
