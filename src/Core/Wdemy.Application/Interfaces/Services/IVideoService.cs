using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Dtos.Videos;
using Wdemy.Application.Utilities.Result;

namespace Wdemy.Application.Interfaces.Services
{
    public interface IVideoService
    {
        Task<IDataResult<VideoDto>> GetByIdAsync(Guid id);
        Task<IDataResult<List<VideoDto>>> GetAllAsync();
        //Task<IDataResult<VideoDto>> AddAsync(CourseCreateDto courseCreateDto);
        Task<IResult> DeleteAsync(Guid id);
        Task<IDataResult<VideoDto>> UpdateAsync(VideoDto videoDto);
    }
}
