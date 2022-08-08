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

    [HttpGet("{text}")]
    [AllowAnonymous]
    public ActionResult<string> Get(string text)
    {
      return Ok($"Text: [{text}]");
    }

    [HttpPost()]
    [AllowAnonymous]
    public ActionResult<string> Post([FromBody] TesteBody teste)
    {
      return Ok($"Text: [{teste.Message}]");
    }
  }

  public class TesteBody
  {
    public string Message { get; set; }
  }
}
