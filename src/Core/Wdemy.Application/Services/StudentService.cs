using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Constant;
using Wdemy.Application.Dtos.Students;
using Wdemy.Application.Dtos.Trainer;
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
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentService(IRepository<Student> repository, IStudentRepository studentRepository, IMapper mapper)
        {
            _repository = repository;
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<Student>> GetByIdAsync(Guid id)
        {
            var student = await _repository.GetByIdAsync(id);
           
            if(student == null)
                return new ErrorDataResult<Student>();

            return new SuccessDataResult<Student>(student, Messages.FoundSuccess);
        }

        public async Task<IDataResult<List<StudentDto>>> GetAllAsync()
        {
            var allStudent = await _repository.GetAllAsync();

            if (allStudent == null)
                return new ErrorDataResult<List<StudentDto>>();

            return new SuccessDataResult<List<StudentDto>>(_mapper.Map<List<StudentDto>>(allStudent), Messages.FoundSuccess);
        }
    }
}
