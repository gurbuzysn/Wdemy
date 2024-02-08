using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.StudentCourses;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Application.Utilities.Result;

namespace Wdemy.Application.Services
{
    public class StudentCourseService : IStudentCourseService
    {
        private readonly IMapper _mapper;
        private readonly IStudentCourseRepository _studentCourseRepository;

        public StudentCourseService(IMapper mapper, IStudentCourseRepository studentCourseRepository)
        {
            _mapper = mapper;
            _studentCourseRepository = studentCourseRepository;
        }

        public Task<IDataResult<List<StudentCourseDto>>> GetAllAsync()
        {

        }
    }
}
