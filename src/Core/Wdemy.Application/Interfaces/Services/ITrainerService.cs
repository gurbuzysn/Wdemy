using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Dtos.Trainer;
using Wdemy.Application.Utilities.Result;

namespace Wdemy.Application.Interfaces.Services
{
    public interface ITrainerService
    {
        Task<IDataResult<TrainerDto>> GetByIdAsync(Guid id);

    }
}
