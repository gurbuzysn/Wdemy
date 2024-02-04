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
using Wdemy.Domain.Enums;

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

        public Task<IDataResult<Course>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();

        }

        public async Task<IDataResult<Course>> AddAsync(CourseCreateDto courseCreateDto)
        {
            Course course = new Course
            {
                Name = courseCreateDto.Name,
                TrainerId = courseCreateDto.TrainerId,
                Trainer = (await _trainerService.GetByIdAsync(courseCreateDto.TrainerId)).Data,
                Status = Status.Added,
                CreatedBy = courseCreateDto.TrainerId,
                CreatedDate = DateTime.Now,
            };

            try
            {
                var result = await _courseRepository.AddAsync(course);
            }
            catch (Exception)
            {
                return new ErrorDataResult<Course>(Messages.AddFail);
            }

            return new SuccessDataResult<Course>(course, Messages.AddSuccess);
        }

        public Task<IResult> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<List<Course>>> GetAllAsync()
        {
            var allCourses = await _courseRepository.GetAllAsync();
            
            if(allCourses == null)
            {
                return new ErrorDataResult<List<Course>>(Messages.CourseNotFound);
            }

            return new SuccessDataResult<List<Course>>(allCourses, Messages.ListedSuccess);
        }
    }
}
