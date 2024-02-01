using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Wdemy.Mvc.Models;

namespace Wdemy.Mvc.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}