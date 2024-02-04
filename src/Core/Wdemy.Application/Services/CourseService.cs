using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Domain.Entities;
using Wdemy.Application.Utilities.Result;
using AutoMapper;
using Wdemy.Application.Interfaces.Repository;
using Wdemy.Application.Utilities.Result.Concrete;

namespace Wdemy.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly IMapper _mapper;
        private readonly ICourseRepository _courseRepository;

        public CourseService(IMapper mapper, ICourseRepository courseRepository)
        {
            _mapper = mapper;
            _courseRepository = courseRepository;
        }

        public Task<IDataResult<CourseDto>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();

        }



        public Task<IDataResult<CourseDto>> AddAsync(CourseCreateDto courseCreateDto)
        {
            //if(!ModelState.IsValid)
            //    return new ErrorDataResult<CourseDto>("Model is not valid");

            var course = _mapper.Map<Course>(courseCreateDto);


        }




        public Task<IResult> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
