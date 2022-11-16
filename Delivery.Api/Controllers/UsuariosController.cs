using System;
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
    public ActionResult Post([FromBody] UsuarioDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }
        applicationServiceUsuario.Save(dto);
        return Ok("Usuario cadastrado com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao cadastrar o usuario" });
      }
    }

    [HttpPost("login")]
    [AllowAnonymous]
    public IActionResult Authenticate([FromBody] UsuarioDto dto)
    {
      try
      {
        var user = applicationServiceUsuario.Authenticate(dto);

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
    public ActionResult Put([FromBody] UsuarioDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }

        applicationServiceUsuario.Save(dto);
        return Ok("Usuario atualizado com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao atualizar o usuario" });
      }
    }

    [HttpDelete]
    [Authorize(Policy = "User")]
    public ActionResult Delete([FromBody] UsuarioDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }
        applicationServiceUsuario.Remove(dto);
        return Ok("Usuario removido com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao remover o usuario" });
      }
    }
  }
}
