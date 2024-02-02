using Microsoft.AspNetCore.Mvc;

namespace Wdemy.Mvc.Areas.Student.Controllers
{
    public class HomeController : StudentBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
