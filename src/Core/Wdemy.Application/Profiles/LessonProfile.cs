using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Lessons;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Profiles
{
    public class LessonProfile : Profile
    {
        public LessonProfile()
        {
            //CreateMap<LessonCreateDto, Lesson>();
            CreateMap<Lesson, LessonDto>()
                .ForMember(dest => dest.Video, opt => opt.MapFrom(src => src.Video));
        }
    }
}
