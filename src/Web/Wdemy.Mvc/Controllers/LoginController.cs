using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Wdemy.Mvc.Controllers
{
    public class LoginController : BaseController
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["Login"] != null)
            {
                var user = await _userManager.GetUserAsync(User);
                var userRole = await _userManager.GetRolesAsync(user);
                Json(new { success = true });
                return RedirectToAction("Index", "Home", new { Area = userRole[0].ToString() });
            }
            return View();
        }
    }
}
