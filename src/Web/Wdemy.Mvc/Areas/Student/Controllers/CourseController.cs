﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Mvc.Areas.Student.Models.Course;

namespace Wdemy.Mvc.Areas.Student.Controllers
{
    public class CourseController : StudentBaseController
    {
        private readonly ICourseService _courseService;
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        private readonly IStudentCourseService _studentCourseService;

        public CourseController(ICourseService courseService, IStudentService studentService, IMapper mapper, IStudentCourseService studentCourseService)
        {
            _courseService = courseService;
            _studentService = studentService;
            _mapper = mapper;
            _studentCourseService = studentCourseService;
        }

        public async Task<IActionResult> Index()
        {
            var userId = Guid.Parse(UserId);
            var student = await _studentService.GetByIdAsync(userId);

            var studentCourses = await _courseService.GetByStudentIdAsync(student.Data.Id);


            //var courseListVm = _mapper.Map<List<StudentCourseListVM>>(courses.Data);


            return View();
        }
    }
}
