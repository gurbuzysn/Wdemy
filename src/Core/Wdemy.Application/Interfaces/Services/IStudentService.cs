using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Utilities.Result;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Interfaces.Services
{
    public interface IStudentService
    {
        Task<IDataResult<Student>> GetByIdAsync(Guid id);
    }
}
