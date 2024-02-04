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
    public class CourseRepository : EfRepository<Course>, ICourseRepository
    {
        public CourseRepository(WdemyDbContext db) : base(db)
        {
        }
    }
}
