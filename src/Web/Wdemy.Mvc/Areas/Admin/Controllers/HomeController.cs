using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wdemy.Mvc.Controllers;

namespace Wdemy.Mvc.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
