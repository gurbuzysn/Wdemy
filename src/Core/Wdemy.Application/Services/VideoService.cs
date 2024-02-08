using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Constant;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Dtos.Videos;
using Wdemy.Application.Interfaces.Repository;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Application.Utilities.Result;
using Wdemy.Application.Utilities.Result.Concrete;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Services
{
    public class VideoService : IVideoService
    {
        private readonly IVideoRepository _videoRepository;
        private readonly IMapper _mapper;

        public VideoService(IVideoRepository videoRepository, IMapper mapper)
        {
            _videoRepository = videoRepository;
            _mapper = mapper;
        }

        public Task<IResult> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<VideoDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<VideoDto>> GetByIdAsync(Guid id)
        {
            var video = await _videoRepository.GetByIdAsync(id);

            if(video == null)
            {
                return new ErrorDataResult<VideoDto>(Messages.VideoNotFound);
            }

            return new SuccessDataResult<VideoDto>(_mapper.Map<VideoDto>(video), Messages.FoundSuccess);
        }

        public Task<IDataResult<VideoDto>> UpdateAsync(VideoDto courseDto)
        {
            throw new NotImplementedException();
        }
    }
}
