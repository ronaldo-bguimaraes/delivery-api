using Delivery.Application;
using Delivery.Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Delivery.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ClientesController : Controller
  {
    private readonly IApplicationServiceCliente applicationServiceCliente;

    public ClientesController(IApplicationServiceCliente _applicationServiceCliente)
    {
      applicationServiceCliente = _applicationServiceCliente;
    }

    [HttpGet]
    [Authorize(Policy = "User")]
    public ActionResult Get()
    {
      return Ok(applicationServiceCliente.GetAll());
    }

    [HttpGet("{id}")]
    [Authorize(Policy = "User")]
    public ActionResult Get(int id)
    {
      return Ok(applicationServiceCliente.GetById(id));
    }

    [HttpGet("usuarios/{id}")]
    [Authorize(Policy = "User")]
    public ActionResult GetByUsuarioId(int id)
    {
      return Ok(applicationServiceCliente.GetByUsuarioId(id));
    }

    [HttpPost]
    [Authorize(Policy = "User")]
    public ActionResult Post([FromBody] ClienteDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }
        applicationServiceCliente.Save(dto);
        return Ok("Cliente cadastrado com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao cadastrar o cliente" });
      }
    }

    [HttpPost("save")]
    [Authorize(Policy = "User")]
    public ActionResult Save([FromBody] ClienteDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }
        applicationServiceCliente.Save(dto);
        return Ok("Cliente salvo com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao salvar o cliente" });
      }
    }

    [HttpPut]
    [Authorize(Policy = "User")]
    public ActionResult Put([FromBody] ClienteDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }
        applicationServiceCliente.Save(dto);
        return Ok("Cliente atualizado com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao atualizar o cliente" });
      }
    }

    [HttpDelete]
    [Authorize(Policy = "User")]
    public ActionResult Delete([FromBody] ClienteDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }
        applicationServiceCliente.Remove(dto);
        return Ok("Cliente removido com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao remover o cliente" });
      }
    }
  }
}
