using Delivery.Application;
using Delivery.Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class UsuariosController : Controller
  {
    // Fazer um controller para chamar a applicationService
    private readonly IApplicationServiceUsuario applicationServiceUsuario;

    public UsuariosController(IApplicationServiceUsuario _applicationServiceUsuario)
    {
      applicationServiceUsuario = _applicationServiceUsuario;
    }

    [HttpGet]
    [Authorize(Policy = "User")]
    public ActionResult Get()
    {
      return Ok(applicationServiceUsuario.GetAll());
    }

    [HttpGet("{id}")]
    [Authorize(Policy = "User")]
    public ActionResult Get(int id)
    {
      return Ok(applicationServiceUsuario.GetById(id));
    }

    [HttpPost]
    [AllowAnonymous]
    public ActionResult Post([FromBody] UsuarioDto usuarioDto)
    {
      try
      {
        if (usuarioDto == null)
        {
          return NotFound();
        }
        applicationServiceUsuario.Save(usuarioDto);
        return Ok("Usuario cadastrado com sucesso!");
      }
      catch
      {
        return BadRequest(new { message = "Erro ao cadastrar o usuario" });
      }
    }

    [HttpPost("login")]
    [AllowAnonymous]
    public IActionResult Authenticate([FromBody] UsuarioDto usuarioDto)
    {
      try
      {
        var user = applicationServiceUsuario.Authenticate(usuarioDto);

        if (user == null)
        {
          return BadRequest(new { message = "Usuário ou senha inválidos" });
        }

        return Ok(user);
      }
      catch
      {
        return BadRequest(new { message = "Erro ao autenticar o usuario" });
      }
    }

    [HttpPut]
    [Authorize(Policy = "User")]
    public ActionResult Put([FromBody] UsuarioDto usuarioDto)
    {
      try
      {
        if (usuarioDto == null)
        {
          return NotFound();
        }

        applicationServiceUsuario.Save(usuarioDto);
        return Ok("Usuario atualizado com sucesso!");
      }
      catch
      {
        return BadRequest(new { message = "Erro ao atualizar o usuario" });
      }
    }

    [HttpDelete]
    [Authorize(Policy = "User")]
    public ActionResult Delete([FromBody] UsuarioDto usuarioDto)
    {
      try
      {
        if (usuarioDto == null)
        {
          return NotFound();
        }
        applicationServiceUsuario.Remove(usuarioDto);
        return Ok("Usuario removido com sucesso!");
      }
      catch
      {
        return BadRequest(new { message = "Erro ao remover o usuario" });
      }
    }
  }
}
