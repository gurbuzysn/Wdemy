using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Mvc.Areas.Trainer.Models.Videos;

namespace Wdemy.Mvc.Areas.Trainer.Controllers
{
    public class VideoController : Controller
    {
        private readonly IVideoService _videoService;
        private readonly IMapper _mapper;

        public VideoController(IVideoService videoService, IMapper mapper)
        {
            _videoService = videoService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var video = await _videoService.GetByIdAsync(id);
            var videoVM = _mapper.Map<TrainerVideoDetailsVM>(video);

            return View(videoVM);
        }
    }
}
