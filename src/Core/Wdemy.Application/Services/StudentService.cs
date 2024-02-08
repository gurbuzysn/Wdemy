using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Constant;
using Wdemy.Application.Interfaces.Repository;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Application.Utilities.Result;
using Wdemy.Application.Utilities.Result.Concrete;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _repository;

        public StudentService(IRepository<Student> repository)
        {
            _repository = repository;
        }

        public async Task<IDataResult<Student>> GetByIdAsync(Guid id)
        {
            var student = await _repository.GetByIdAsync(id);
           
            if(student == null)
                return new ErrorDataResult<Student>();

            return new SuccessDataResult<Student>(student, Messages.FoundSuccess);
        }
    }
}
