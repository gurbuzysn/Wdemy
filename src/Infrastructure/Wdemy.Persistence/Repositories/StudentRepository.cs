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
    public class StudentRepository : EfRepository<Student>, IStudentRepository
    {
        public StudentRepository(WdemyDbContext db) : base(db)
        {
        }
        public Task<Student?> GetByIdentityAsync(Guid identityId)
        {
            return _db.Set<Student>().FirstOrDefaultAsync(x => x.IdentityId == identityId);
        }
    }
}
