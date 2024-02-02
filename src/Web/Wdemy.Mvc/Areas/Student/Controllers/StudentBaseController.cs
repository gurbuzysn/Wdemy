using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wdemy.Mvc.Controllers;

namespace Wdemy.Mvc.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class StudentBaseController : BaseController
    {
       
    }
}
