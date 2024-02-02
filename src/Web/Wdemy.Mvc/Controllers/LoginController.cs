using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Wdemy.Mvc.Models;

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

        [HttpPost]
        public async Task<IActionResult> Index(LoginVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user is null)
            {
                //NotifyError("Email veya şifre hatalı");
                return View(model);
            }

            var checkPass = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (!checkPass.Succeeded)
            {
                //NotifyError("Email veya şifre hatalı");
                return View(model);
            }

            //if (User.IsInRole("Student"))
            //{
            //    bool isGraduated = await _studentService.IsGraduatedAsync(user?.Id);

            //    if (isGraduated)
            //    {
            //        NotifyError("Mezun olduğunuz için artık sisteme giriş yapamazsınız.Tebrikler!");
            //        return View(model);
            //    }
            //}
            var userRole = await _userManager.GetRolesAsync(user);
            if (userRole is null)
            {
                //NotifyError("Kullanıcıya ait rol bulunamadı");
                return View(model);
            }
            TempData["Login"] = "ok";
            Json(new { success = true });
            return RedirectToAction("Index", "Home", new { Area = userRole[0].ToString() });
        }


        public async Task<IActionResult> Verify(LoginVM model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user is null)
            {
                //NotifyError("Email veya şifre hatalı");
                return Json(new { success = false });
            }

            var checkPass = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (!checkPass.Succeeded)
            {
                //NotifyError("Email veya şifre hatalı");
                return Json(new { success = false });
            }

            //int verificationCode = await _sendMailService.SendEmailVerificationCode(model.Email);
            //TempData["VerificationCode"] = verificationCode;
            return Json(new { success = true });
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> AccessDenied(AccessDeniedVM? accessDeniedVM)
        {
            var user = await _userManager.GetUserAsync(User);
            var userRole = await _userManager.GetRolesAsync(user);

            if (accessDeniedVM != null)
            {
                if (accessDeniedVM.AreaName == null)
                {
                    accessDeniedVM.AreaName = userRole[0].ToString();
                }
                return View(accessDeniedVM);
            }
            else
            {
                accessDeniedVM = new AccessDeniedVM();
                accessDeniedVM.AreaName = userRole[0].ToString();
                return View(accessDeniedVM);
            }

        }

    }
}
