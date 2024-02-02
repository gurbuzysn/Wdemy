using Microsoft.AspNetCore.Mvc;

namespace Wdemy.Mvc.Areas.Trainer.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
