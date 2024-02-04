using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Utilities.Result;

namespace Wdemy.Application.Interfaces.Services
{
    public interface ICourseService
    {
        Task<IDataResult<CourseDto>> GetByIdAsync(Guid id);
        //Task<IDataResult<List<CourseListDto>>> GetAllAsync();
        Task<IDataResult<CourseDto>> AddAsync(CourseCreateDto courseCreateDto);
        Task<IResult> DeleteAsync(Guid id);
    }
}
