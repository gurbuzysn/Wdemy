using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Course;

namespace Wdemy.Application.Interfaces.Services
{
    public interface ICourseService
    {
      Task<IAsyncResult<CourseDto>> AddAsync(CourseCreateDto courseCreateDto);
    }
}
