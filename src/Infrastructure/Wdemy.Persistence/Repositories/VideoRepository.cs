using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Interfaces.Repository;
using Wdemy.Domain.Entities;
using Wdemy.Persistence.Context;

namespace Wdemy.Persistence.Repositories
{
    public class VideoRepository : EfRepository<Video>, IVideoRepository
    {
        public VideoRepository(WdemyDbContext db) : base(db)
        {
        }
    }
}
