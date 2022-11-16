using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class TesteController : Controller
  {
    public readonly IWebHostEnvironment Env;

    public TesteController(IWebHostEnvironment env)
    {
      Env = env;
    }

    [HttpGet]
    [AllowAnonymous]
    public ActionResult Get()
    {
      return Ok($"Running mode: [{Env.EnvironmentName}]");
    }

    [HttpGet("{text}")]
    [AllowAnonymous]
    public ActionResult Get(string text)
    {
      return Ok($"Text: [{text}]");
    }

    [HttpPost()]
    [AllowAnonymous]
    public ActionResult Post([FromBody] TesteBody teste)
    {
      return Ok($"Text: [{teste.Message}]");
    }
  }

  public class TesteBody
  {
    public string Message { get; set; }
  }
}
