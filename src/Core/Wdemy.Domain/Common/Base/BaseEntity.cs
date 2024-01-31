using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Common.Interfaces;
using Wdemy.Domain.Enums;

namespace Wdemy.Domain.Common.Base
{
    public class BaseEntity : ICreatableEntity, IUpdatableEntity
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
       
    }   
}
