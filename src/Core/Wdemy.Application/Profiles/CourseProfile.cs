using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Course;
using Wdemy.Domain.Entities;
using Wdemy.Domain.Enums;

namespace Wdemy.Application.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<CourseCreateDto, Course>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.TrainerId, opt => opt.MapFrom(src => src.TrainerId))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => Status.Added))
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.TrainerId))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedDate, opt => opt.Ignore())
                .ForMember(dest => dest.DeletedBy, opt => opt.Ignore())
                .ForMember(dest => dest.DeletedDate, opt => opt.Ignore())

                .ForMember(dest => dest.StudentCount, opt => opt.MapFrom(src => 0))
                .ForMember(dest => dest.TotalParts, opt => opt.MapFrom(src => 0))
                .ForMember(dest => dest.TotalLesson, opt => opt.MapFrom(src => 0))
                .ForMember(dest => dest.TotalDuration, opt => opt.MapFrom(src => TimeSpan.Zero))
                .ForMember(dest => dest.Description, opt => opt.Ignore())
               // .ForMember(dest => dest.Trainer, opt => opt.Ignore())
                .ForMember(dest => dest.Sections, opt => opt.Ignore())
                .ForMember(dest => dest.Students, opt => opt.Ignore())
                
                ;
            CreateMap<Course, CourseDto>().ReverseMap();
        }
    }
}
