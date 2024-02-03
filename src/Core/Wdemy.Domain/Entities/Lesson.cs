using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Common.Base;

namespace Wdemy.Domain.Entities
{
    public class Lesson : AuditableEntity
    {
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public string DocumentUri{ get; set; }
    }
}
