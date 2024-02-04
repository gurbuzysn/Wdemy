using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Domain.Entities;
using Wdemy.Application.Utilities.Result;

namespace Wdemy.Application.Services
{
    public class CourseService : ICourseService
    {
        
        public Task<IDataResult<CourseDto>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();

        }



        public Task<IDataResult<CourseDto>> AddAsync(CourseCreateDto courseCreateDto)
        {
            
        }




        public Task<IResult> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
