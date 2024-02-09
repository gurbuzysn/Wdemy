using AutoMapper;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Dtos.Courses;
using Wdemy.Application.Dtos.Sections;
using Wdemy.Application.Dtos.StudentCourses;
using Wdemy.Mvc.Areas.Student.Models.Course;
using Wdemy.Mvc.Areas.Student.Models.Sections;

namespace Wdemy.Mvc.Profiles
{
    public class StudentAreaProfiles : Profile
    {
        public StudentAreaProfiles()
        {
            CreateMap<CourseDto, StudentCourseListVM>();

            CreateMap<SectionDto, StudentSectionListVM>()
                .ForMember(dest => dest.Videos, opt => opt.MapFrom(src => src.Videos) );
        }
    }
}
