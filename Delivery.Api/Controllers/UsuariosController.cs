using Delivery.Application;
using Delivery.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Delivery.Api.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class UsuariosController : Controller
  {
    // Fazer um controller para chamar a applicationService
    private readonly IApplicationServiceUsuario applicationServiceUsuario;

    public UsuariosController(IApplicationServiceUsuario _applicationServiceUsuario)
    {
      applicationServiceUsuario = _applicationServiceUsuario;
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return Ok(applicationServiceUsuario.GetAll());
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return Ok(applicationServiceUsuario.GetById(id));
    }

    // POST api/values
    [HttpPost]
    public ActionResult Post([FromBody] UsuarioDto usuarioDto)
    {
      try
      {
        if (usuarioDto == null)
        {
          return NotFound();
        }
        applicationServiceUsuario.Add(usuarioDto);
        return Ok("Usuario Cadastrado com sucesso!");
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

    // PUT api/values/5
    [HttpPut]
    public ActionResult Put([FromBody] UsuarioDto usuarioDto)
    {
      try
      {
        if (usuarioDto == null)
          return NotFound();

        applicationServiceUsuario.Update(usuarioDto);
        return Ok("Usuario Atualizado com sucesso!");
      }
      catch (Exception)
      {
        throw;
      }
    }
    // DELETE api/values/5
    [HttpDelete()]
    public ActionResult Delete([FromBody] UsuarioDto UsuarioDto)
    {
      try
      {
        if (UsuarioDto == null)
        {
          return NotFound();
        }
        applicationServiceUsuario.Remove(UsuarioDto);
        return Ok("Usuario Removido com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

  }
}
