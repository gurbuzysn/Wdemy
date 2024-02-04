using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Interfaces.Repository;
using Wdemy.Domain.Common.Base;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Interfaces.Repository
{
    public interface ICourseRepository : IRepository<Course>
    {
    }
}
