using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace Delivery.Api.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class TesteController : Controller
  {
    public IWebHostEnvironment Env { get; }
    public TesteController(IWebHostEnvironment env)
    {
      Env = env;
    }

    // GET api/values
    [HttpGet]
    [AllowAnonymous]
    public ActionResult<string> Get()
    {
      return Ok($"Running mode: [{Env.EnvironmentName}]");
    }

    [HttpPost("{text}")]
    [AllowAnonymous]
    public ActionResult<string> Post(int text)
    {
      return Ok($"Text: [{text}]");
    }
  }
}
