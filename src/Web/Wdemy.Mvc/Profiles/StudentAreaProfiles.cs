using AutoMapper;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Dtos.Courses;
using Wdemy.Mvc.Areas.Student.Models.Course;

namespace Wdemy.Mvc.Profiles
{
    public class StudentAreaProfiles : Profile
    {
        public StudentAreaProfiles()
        {
            CreateMap<CourseDto, StudentCourseListVM>();
        }
    }
}
