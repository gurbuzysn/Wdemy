using AutoMapper;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Dtos.Sections;
using Wdemy.Application.Dtos.Students;
using Wdemy.Application.Dtos.Videos;
using Wdemy.Mvc.Areas.Trainer.Models.Courses;
using Wdemy.Mvc.Areas.Trainer.Models.Sections;
using Wdemy.Mvc.Areas.Trainer.Models.Students;
using Wdemy.Mvc.Areas.Trainer.Models.Videos;

namespace Wdemy.Mvc.Profiles
{
    public class TrainerAreaProfiles : Profile
    {
        public TrainerAreaProfiles()
        {
            CreateMap<TrainerCourseCreateVM, CourseCreateDto>();
            CreateMap<CourseDto, TrainerCourseListVM>()
                .ForMember(dest => dest.Sections, opt => opt.MapFrom(src => src.Sections))
                .ForMember(dest => dest.Students, opt => opt.MapFrom(src => src.Students));
            CreateMap<CourseDto, TrainerCourseUpdateVM>()
                .ForMember(dest => dest.Sections, opt => opt.MapFrom(src => src.Sections));
            CreateMap<TrainerCourseUpdateVM, CourseDto>()
                .ForMember(dest => dest.Sections, opt => opt.MapFrom(src => src.Sections));
            CreateMap<TrainerCourseDetailsVM, CourseDto>().ReverseMap();

            CreateMap<StudentDto, TrainerStudentListVM>();

            CreateMap<SectionDto, TrainerSectionListVM>()
                .ForMember(dest => dest.Videos, opt => opt.MapFrom(src => src.Videos));
            CreateMap<SectionDto, TrainerSectionUpdateVM>()
                .ForMember(dest => dest.SectionName, opt => opt.MapFrom(src => src.Name)).ReverseMap();
            CreateMap<TrainerVideoDetailsVM, SectionDto>().ReverseMap();

            CreateMap<VideoDto, TrainerVideoListVM>();
            CreateMap<VideoDto, TrainerVideoUpdateVM>().ReverseMap();
            CreateMap<TrainerVideoDetailsVM, VideoDto>().ReverseMap();
        }
    }
}
