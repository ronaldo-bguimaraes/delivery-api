using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

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
      var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
      return Ok($"Is running on: [{environment}]");
    }
  }
}
