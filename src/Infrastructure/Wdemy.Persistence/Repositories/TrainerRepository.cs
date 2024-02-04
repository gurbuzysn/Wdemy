using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Entities;
using Wdemy.Persistence.Context;
using Wdemy.Application.Interfaces.Repository;

namespace Wdemy.Persistence.Repositories
{
    public class TrainerRepository : EfRepository<Trainer>, ITrainerRepository
    {
        public TrainerRepository(WdemyDbContext db) : base(db)
        {
        }
        public Task<Trainer?> GetByIdentityAsync(Guid identityId)
        {
            return _db.Set<Trainer>().FirstOrDefaultAsync(x => x.IdentityId == identityId);
        }
    }
}
