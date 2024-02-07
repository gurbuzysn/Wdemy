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
        public string Name { get; set; } = null!;
        public string VideoUri { get; set; } = null!;
        public string? DocumentUri { get; set; }
        public TimeSpan Duration { get; set; }
        public Guid SectionId { get; set; }

        public virtual Section Section { get; set; } = null!;
    }
}
