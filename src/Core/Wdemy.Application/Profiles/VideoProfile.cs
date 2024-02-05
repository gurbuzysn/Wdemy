using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Videos;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Profiles
{
    public class VideoProfile : Profile
    {
        public VideoProfile()
        {
            //CreateMap<VideoCreateDto, Video>();
            CreateMap<Video, VideoDto>();
        }
    }
}
