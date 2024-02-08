using AutoMapper;
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

        public CourseController(ICourseService courseService, IStudentService studentService, IMapper mapper)
        {
            _courseService = courseService;
            _studentService = studentService;
            _mapper = mapper;
        }

        //public async Task<IActionResult> Index()
        //{
        //    var userId = Guid.Parse(UserId);
        //    var student = await _studentService.GetByIdAsync(userId);

        //    var studentCourses = 


        //    var courses = await _courseService.GetAllAsync();
        //    var courseListVm = _mapper.Map<List<StudentCourseListVM>>(courses.Data);

           
        //    return View(courseListVm);
        //}
    }
}
