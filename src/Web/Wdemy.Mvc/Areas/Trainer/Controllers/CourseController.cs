using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Mvc.Areas.Trainer.Models;

namespace Wdemy.Mvc.Areas.Trainer.Controllers
{
    
    public class CourseController : TrainerBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICourseService _courseService;

        public CourseController(IMapper mapper, ICourseService courseService)
        {
            _mapper = mapper;
            _courseService = courseService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TrainerCourseCreateVM trainerCourseCreateVM)
        {
            if (!ModelState.IsValid)
                return View(trainerCourseCreateVM);

            var userId = Guid.Parse(UserId);
            trainerCourseCreateVM.TrainerId = userId;

            var courseCreateDto = _mapper.Map<CourseCreateDto>(trainerCourseCreateVM);

            var addCourseResult = await _courseService.AddAsync(courseCreateDto);

            return RedirectToAction(nameof(Index));

        }

    }
}
