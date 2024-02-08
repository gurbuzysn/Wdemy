using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Mvc.Areas.Trainer.Models.Videos;

namespace Wdemy.Mvc.Areas.Trainer.Controllers
{
    public class VideoController : TrainerBaseController
    {
        private readonly IVideoService _videoService;
        private readonly ISectionService _sectionService;
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public VideoController(IVideoService videoService,ISectionService sectionService, ICourseService courseService, IMapper mapper)
        {
            _videoService = videoService;
            _sectionService = sectionService;
            _courseService = courseService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var video = await _videoService.GetByIdAsync(id);
            var videoVM = _mapper.Map<TrainerVideoDetailsVM>(video.Data);
            var section = await _sectionService.GetByIdAsync(videoVM.SectionId);
            videoVM.SectionName = section.Data.Name;
            var course = await _courseService.GetByIdAsync(section.Data.CourseId);
            videoVM.CourseName = course.Data.Name;

            return View(videoVM);
        }
    }
}
