using Microsoft.AspNetCore.Mvc;

namespace Wdemy.Mvc.Areas.Trainer.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TrainerCourseCreateVM trainerCourseCreateVM)
        {
            if (!ModelState.IsValid)
                return View(trainerCourseCreateVM);

        }

    }
}
