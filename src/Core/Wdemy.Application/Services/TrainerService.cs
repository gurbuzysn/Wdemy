using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Constant;
using Wdemy.Application.Dtos.Trainer;
using Wdemy.Application.Interfaces.Repository;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Application.Utilities.Result;
using Wdemy.Application.Utilities.Result.Concrete;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Services
{
    public class TrainerService : ITrainerService
    {
        private readonly IRepository<Trainer> _trainerRepository;
        private readonly IMapper _mapper;

        public TrainerService(IRepository<Trainer> trainerRepository, IMapper mapper)
        {
            _trainerRepository = trainerRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<Trainer>> GetByIdAsync(Guid id)
        {
           var trainer = await _trainerRepository.GetByIdAsync(id);

            if (trainer == null)
            {
                return new ErrorDataResult<Trainer>();
            }

            return new SuccessDataResult<Trainer>(trainer, Messages.FoundSuccess);
        }
    }
}
