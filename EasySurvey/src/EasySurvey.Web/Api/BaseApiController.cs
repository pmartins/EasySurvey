using Microsoft.AspNetCore.Mvc;

namespace EasySurvey.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
