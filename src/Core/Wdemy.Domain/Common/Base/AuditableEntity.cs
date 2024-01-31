using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Common.Interfaces;
using Wdemy.Domain.Enums;

namespace Wdemy.Domain.Common.Base
{
    public class AuditableEntity : BaseEntity, ISoftDeletableEntity
    {
        public Guid DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
