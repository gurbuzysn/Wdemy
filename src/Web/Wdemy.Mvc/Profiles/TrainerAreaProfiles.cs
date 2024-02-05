using AutoMapper;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Dtos.Lessons;
using Wdemy.Application.Dtos.Sections;
using Wdemy.Application.Dtos.Students;
using Wdemy.Application.Dtos.Videos;
using Wdemy.Mvc.Areas.Trainer.Models.Courses;
using Wdemy.Mvc.Areas.Trainer.Models.Lessons;
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

            CreateMap<StudentDto, TrainerStudentListVM>();

            CreateMap<SectionDto, TrainerSectionListVM>()
                .ForMember(dest => dest.Lessons, opt => opt.MapFrom(src => src.Lessons));
            CreateMap<SectionDto, TrainerSectionUpdateVM>()
                .ForMember(dest => dest.Lessons, opt => opt.MapFrom(src => src.Lessons))
                .ForMember(dest => dest.SectionName, opt => opt.MapFrom(src => src.Name));

            CreateMap<LessonDto, TrainerLessonListVM>()
               .ForMember(dest => dest.Video, opt => opt.MapFrom(src => src.Video));
            CreateMap<LessonDto, TrainerLessonUpdateVM>()
              .ForMember(dest => dest.Video, opt => opt.MapFrom(src => src.Video));

            CreateMap<VideoDto, TrainerVideoListVM>();
            CreateMap<VideoDto, TrainerVideoUpdateVM>();




        }
    }
}
