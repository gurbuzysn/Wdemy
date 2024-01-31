using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wdemy.Domain.Entities
{
    public class SubCategory : Category
    {
        public Guid CategoryId { get; set; }



        public virtual ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>();
        public virtual Category Category { get; set; } = null!;
    }
}
