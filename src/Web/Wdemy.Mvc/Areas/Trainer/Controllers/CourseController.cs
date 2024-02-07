using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Wdemy.Application.Constant;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Dtos.Sections;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Application.Utilities.Result.Concrete;
using Wdemy.Domain.Entities;
using Wdemy.Mvc.Areas.Trainer.Models.Courses;
using Wdemy.Mvc.Areas.Trainer.Models.Sections;
using Wdemy.Mvc.Areas.Trainer.Models.Videos;

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
        public async Task<IActionResult> Index()
        {
            var allCourses = await _courseService.GetAllAsync();
            var allCoursesListVM = _mapper.Map<List<TrainerCourseListVM>>(allCourses.Data);

            return View(allCoursesListVM);
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

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var courseResult = await _courseService.GetByIdAsync(id);

            if(!courseResult.IsSuccess)
                return RedirectToAction(nameof(Index));

            var courseUpdateVM = _mapper.Map<TrainerCourseUpdateVM>(courseResult.Data);
            ViewBag.Sections = JsonSerializer.Serialize(courseUpdateVM.Sections);

            return View(courseUpdateVM);
        }


        [HttpPost]
        public async Task<IActionResult> Update(TrainerCourseUpdateVM trainerCourseUpdateVM, IFormCollection collection)
        {
            List<TrainerSectionUpdateVM> sectionList = JsonSerializer.Deserialize<List<TrainerSectionUpdateVM>>(collection["sectionList"]);

            trainerCourseUpdateVM.Sections = sectionList;

           var courseUpdateDto = _mapper.Map<CourseDto>(trainerCourseUpdateVM);

            var result = await _courseService.UpdateAsync(courseUpdateDto);

            return RedirectToAction(nameof(Index));
        }
    }
}
