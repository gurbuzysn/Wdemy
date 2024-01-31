using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wdemy.Domain.Common.Interfaces
{
    public interface ICreatableEntity : IEntity
    {
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
