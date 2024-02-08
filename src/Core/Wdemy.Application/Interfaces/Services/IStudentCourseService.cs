using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Dtos.StudentCourses;
using Wdemy.Application.Utilities.Result;

namespace Wdemy.Application.Interfaces.Services
{
    public interface IStudentCourseService
    {
        Task<IDataResult<List<StudentCourseDto>>> GetAllAsync();
    }
}
