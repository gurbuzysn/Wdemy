using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Wdemy.Mvc.Controllers
{
    public class BaseController : Controller
    {
        protected string? UserIdentityId => User.FindFirstValue(ClaimTypes.NameIdentifier);
        protected string? UserId => User.FindAll(ClaimTypes.NameIdentifier).LastOrDefault()?.Value;
    }
}
