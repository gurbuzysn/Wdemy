using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Common.Base;

namespace Wdemy.Domain.Entities
{
    public class SubCategory : AuditableEntity
    {
        public string Name { get; set; } = null!;
        public Guid CategoryId { get; set; }


        public virtual ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>();
        public virtual Category Category { get; set; } = null!;
    }
}
