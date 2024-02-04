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
using Wdemy.Application.Constant;

namespace Wdemy.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly IMapper _mapper;
        private readonly ICourseRepository _courseRepository;
        private readonly ITrainerService _trainerService;

        public CourseService(IMapper mapper, ICourseRepository courseRepository, ITrainerService trainerService)
        {
            _mapper = mapper;
            _courseRepository = courseRepository;
            _trainerService = trainerService;
        }

        public Task<IDataResult<CourseDto>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();

        }



        public async Task<IDataResult<CourseDto>> AddAsync(CourseCreateDto courseCreateDto)
        {
            var trainerDto = await _trainerService.GetByIdAsync(courseCreateDto.TrainerId);
            courseCreateDto.Trainer = trainerDto.Data;
            var course = _mapper.Map<Course>(courseCreateDto);


            try
            {
                var result = await _courseRepository.AddAsync(course);
            }
            catch (Exception)
            {
                return new ErrorDataResult<CourseDto>(Messages.AddFail);
            }

            return new SuccessDataResult<CourseDto>(_mapper.Map<CourseDto>(course), Messages.AddSuccess);
        }




        public Task<IResult> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }


    }
}
