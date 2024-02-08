using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Videos;
using Wdemy.Domain.Entities;
using Wdemy.Domain.Enums;

namespace Wdemy.Application.Profiles
{
    public class VideoProfile : Profile
    {
        public VideoProfile()
        {
            //CreateMap<VideoCreateDto, Video>();
            CreateMap<Video, VideoDto>().ReverseMap()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => Status.Added));
        }
    }
}
