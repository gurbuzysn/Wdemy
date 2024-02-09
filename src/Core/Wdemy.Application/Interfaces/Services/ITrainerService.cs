using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Dtos.Trainer;
using Wdemy.Application.Utilities.Result;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Interfaces.Services
{
    public interface ITrainerService
    {
        Task<IDataResult<Trainer>> GetByIdAsync(Guid id);
        Task<IDataResult<List<TrainerDto>>> GetAllAsync();
    }
}
