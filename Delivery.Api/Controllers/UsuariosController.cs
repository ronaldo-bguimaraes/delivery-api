using Delivery.Application;
using Delivery.Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

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
      catch (Exception ex)
      {
        throw ex;
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
      catch (Exception ex)
      {
        return BadRequest(ex);
      }
    }

    [HttpPut]
    [Authorize(Policy = "User")]
    public ActionResult Put([FromBody] UsuarioDto usuarioDto)
    {
      try
      {
        if (usuarioDto == null) {
          return NotFound();
        }

        applicationServiceUsuario.Save(usuarioDto);
        return Ok("Usuario atualizado com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    [HttpDelete]
    [Authorize(Policy = "User")]
    public ActionResult Delete([FromBody] UsuarioDto UsuarioDto)
    {
      try
      {
        if (UsuarioDto == null)
        {
          return NotFound();
        }
        applicationServiceUsuario.Remove(UsuarioDto);
        return Ok("Usuario removido com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
