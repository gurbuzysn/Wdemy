using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Students;
using Wdemy.Application.Dtos.Trainer;
using Wdemy.Application.Utilities.Result;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Interfaces.Services
{
    public interface IStudentService
    {
        Task<IDataResult<Student>> GetByIdAsync(Guid id);
        Task<IDataResult<List<StudentDto>>> GetAllAsync();

    }
}
