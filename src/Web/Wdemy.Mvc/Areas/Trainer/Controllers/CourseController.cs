using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Wdemy.Application.Dtos.Course;
using Wdemy.Mvc.Areas.Trainer.Models;

namespace Wdemy.Mvc.Areas.Trainer.Controllers
{
    
    public class CourseController : Controller
    {
        private readonly IMapper _mapper;

        public CourseController(IMapper mapper)
        {
            _mapper = mapper;
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

        //[HttpPost]
        //public async Task<IActionResult> Create(TrainerCourseCreateVM trainerCourseCreateVM)
        //{
        //    if (!ModelState.IsValid)
        //        return View(trainerCourseCreateVM);

        //    var courseDto = _mapper.Map<CourseCreateDto>(trainerCourseCreateVM);

            //var addCourseResult = await _courseService.AddAsync(courseDto);

            return Ok();

        //}

    }
}
