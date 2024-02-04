using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Interfaces.Repository
{
    public interface IStudentRepository
    {
        Task<Student?> GetByIdentityAsync(Guid identityId);

    }
}
