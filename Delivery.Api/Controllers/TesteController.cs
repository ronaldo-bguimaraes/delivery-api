using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Api.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class TesteController : Controller
  {
    public TesteController() { }

    // GET api/values
    [HttpGet]
    [AllowAnonymous]
    public ActionResult<string> Get()
    {
      return Ok("Delivery Api ir running...");
    }
  }
}
