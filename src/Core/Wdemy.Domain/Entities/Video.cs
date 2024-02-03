using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Common.Base;

namespace Wdemy.Domain.Entities
{
    public class Video : AuditableEntity
    {
        public string Url { get; set; } = null!;
        public TimeSpan Duration { get; set; }
        public Guid LessonId { get; set; }

        public virtual Lesson Lesson { get; set; } = null!;
    }
}
