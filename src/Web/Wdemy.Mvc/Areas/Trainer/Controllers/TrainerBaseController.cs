using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wdemy.Mvc.Controllers;

namespace Wdemy.Mvc.Areas.Trainer.Controllers
{
    [Area("Trainer")]
    [Authorize(Roles = "Trainer")]
    public class TrainerBaseController : BaseController
    {
       
    }
}
