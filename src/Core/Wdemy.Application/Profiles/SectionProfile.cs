using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Sections;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Profiles
{
    public class SectionProfile : Profile
    {
        public SectionProfile()
        {
            CreateMap<SectionCreateDto, Section>();
            CreateMap<Section, SectionDto>()
                .ForMember(dest => dest.Lessons, opt => opt.MapFrom(src => src.Lessons)).ReverseMap();
        }
    }
}
