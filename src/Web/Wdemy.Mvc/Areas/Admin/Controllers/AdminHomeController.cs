﻿using Microsoft.AspNetCore.Mvc;
using Wdemy.Mvc.Controllers;

namespace Wdemy.Mvc.Areas.Admin.Controllers
{
    public class AdminHomeController : BaseController
    {
        //private readonly IAdminService _adminService;
        //public HomeController(IAdminService adminService)
        //{
        //    _adminService = adminService;
        //}
        //public async Task<IActionResult> Index()
        //{
        //    var result = await _adminService.GetByIdentityIdAsync(UserIdentityId!);

        //     Kullanıcı bilgilerini ViewBag veya ViewData ile ayarlayın
        //    ViewBag.UserName = $"{result.Data.FirstName} {result.Data.LastName}";
        //    if (TempData["Login"] != null)
        //        NotifySuccess($"Hoş Geldin {result.Data.FirstName} {result.Data.LastName}");
        //        return View();
        //}


        public IActionResult Index()
        {
            return View();
        }

    }
}
