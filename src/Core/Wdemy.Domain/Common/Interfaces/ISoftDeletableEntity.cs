using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wdemy.Domain.Common.Interfaces
{
    public interface ISoftDeletableEntity : IEntity
    {
        public Guid DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
