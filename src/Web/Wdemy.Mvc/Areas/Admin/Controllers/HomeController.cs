using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wdemy.Application.Interfaces.Services;

namespace Wdemy.Mvc.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        private readonly ITrainerService _trainerService;
        private readonly IStudentService _studentService;
        private readonly ICourseService _courseService;

        public HomeController(ITrainerService trainerService, IStudentService studentService, ICourseService courseService)
        {
            _trainerService = trainerService;
            _studentService = studentService;
            _courseService = courseService;
        }
        public IActionResult Index()
        {
            var trainerCount = _trainerService.GetAllAsync().Result.Data.Count;
            ViewData["TrainerCount"] = trainerCount;

            var studentCount = _studentService.GetAllAsync().Result.Data.Count;
            ViewData["StudentCount"] = studentCount;

            var courseCount = _courseService.GetAllAsync().Result.Data.Count;
            ViewData["CourseCount"] = courseCount;

            return View();
        }
    }
}
