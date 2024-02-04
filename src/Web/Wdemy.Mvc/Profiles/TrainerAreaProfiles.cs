using AutoMapper;
using Wdemy.Application.Dtos.Course;
using Wdemy.Mvc.Areas.Trainer.Models.Courses;

namespace Wdemy.Mvc.Profiles
{
    public class TrainerAreaProfiles : Profile
    {
        public TrainerAreaProfiles()
        {
            CreateMap<TrainerCourseCreateVM, CourseCreateDto>();
        }
    }
}
