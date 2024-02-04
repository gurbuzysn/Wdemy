using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Trainer;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Profiles
{
    public class TrainerProfile : Profile
    {
        public TrainerProfile()
        {
            CreateMap<TrainerDto, Trainer>().ReverseMap();

        }
    }
}
