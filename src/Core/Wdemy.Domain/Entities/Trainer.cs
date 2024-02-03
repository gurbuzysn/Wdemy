using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Common.Base;

namespace Wdemy.Domain.Entities
{
    public class Trainer : BaseUser
    {
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
