using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Entities;
using Wdemy.Persistence.Context;
using Wdemy.Persistence.Interfaces.Repository;

namespace Wdemy.Persistence.Repositories
{
    public class AdminRepository : EfRepository<Admin>, IAdminRepository
    {
        public AdminRepository(WdemyDbContext db) : base(db)
        {
        }
        public Task<Admin?> GetByIdentityAsync(Guid identityId)
        {
            return _db.Set<Admin>().FirstOrDefaultAsync(x => x.IdentityId == identityId);
        }
    }
}
