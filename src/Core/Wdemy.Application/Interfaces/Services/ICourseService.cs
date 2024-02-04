using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Utilities.Result;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Interfaces.Services
{
    public interface ICourseService
    {
        Task<IDataResult<Course>> GetByIdAsync(Guid id);
        //Task<IDataResult<List<CourseListDto>>> GetAllAsync();
        Task<IDataResult<Course>> AddAsync(CourseCreateDto courseCreateDto);
        Task<IResult> DeleteAsync(Guid id);
    }
}
