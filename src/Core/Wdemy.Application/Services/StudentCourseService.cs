using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Constant;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Dtos.StudentCourses;
using Wdemy.Application.Interfaces.Repository;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Application.Utilities.Result;
using Wdemy.Application.Utilities.Result.Concrete;

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

        public async Task<IDataResult<List<StudentCourseDto>>> GetAllAsync()
        {
            var studentCoursesEntity = await _studentCourseRepository.GetAllAsync();
            var studentCoursesDto = _mapper.Map<List<StudentCourseDto>>(studentCoursesEntity);

            if(studentCoursesDto == null)
                return new ErrorDataResult<List<StudentCourseDto>>(Messages.CourseNotFound);

            return new SuccessDataResult<List<StudentCourseDto>>(studentCoursesDto, Messages.FoundSuccess);
        }
    }
}
