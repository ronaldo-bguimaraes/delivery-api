using Delivery.Application;
using Delivery.Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Delivery.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class EnderecosController : Controller
  {
    private readonly IApplicationServiceEndereco applicationServiceEndereco;

    public EnderecosController(IApplicationServiceEndereco _applicationServiceEndereco)
    {
      applicationServiceEndereco = _applicationServiceEndereco;
    }

    [HttpGet]
    [Authorize(Policy = "User")]
    public ActionResult Get()
    {
      return Ok(applicationServiceEndereco.GetAll());
    }

    [HttpGet("{id}")]
    [Authorize(Policy = "User")]
    public ActionResult Get(int id)
    {
      return Ok(applicationServiceEndereco.GetById(id));
    }

    [HttpGet("usuarios/{usuarioId}")]
    [Authorize(Policy = "User")]
    public ActionResult GetByUsuarioId(int usuarioId)
    {
      return Ok(applicationServiceEndereco.GetByUsuarioId(usuarioId));
    }

    [HttpPost]
    [Authorize(Policy = "User")]
    public ActionResult Post([FromBody] EnderecoDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceEndereco.Save(enderecoDto);
        return Ok("Endereço cadastrado com sucesso!");
      }
      catch
      {
        return BadRequest(new { message = "Erro ao cadastrar o endereço" });
      }
    }

    [HttpPost("save")]
    [Authorize(Policy = "User")]
    public ActionResult Save([FromBody] EnderecoDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceEndereco.Save(enderecoDto);
        return Ok("Endereço salvo com sucesso!");
      }
      catch
      {
        return BadRequest(new { message = "Erro ao salvar o endereço" });
      }
    }

    [HttpPut]
    [Authorize(Policy = "User")]
    public ActionResult Put([FromBody] EnderecoDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceEndereco.Save(enderecoDto);
        return Ok("Endereço atualizado com sucesso!");
      }
      catch
      {
        return BadRequest(new { message = "Erro ao atualizar o endereço" });
      }
    }

    [HttpDelete]
    [Authorize(Policy = "User")]
    public ActionResult Delete([FromBody] EnderecoDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceEndereco.Remove(enderecoDto);
        return Ok("Endereço removido com sucesso!");
      }
      catch
      {
        return BadRequest(new { message = "Erro ao remover o endereço" });
      }
    }
  }
}
