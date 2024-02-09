using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.StudentCourses;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Profiles
{
    public class StudentCourseProfile : Profile
    {
        public StudentCourseProfile()
        {
            CreateMap<StudentCourse, StudentCourseDto>()
                .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student))
                .ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Course));
        }
    }
}
