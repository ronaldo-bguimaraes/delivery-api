using Delivery.Application;
using Delivery.Dtos;
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
    [Authorize(Policy = "Admin")]
    public ActionResult Get()
    {
      return Ok(applicationServiceCliente.GetAll());
    }

    [HttpGet("{id}")]
    [Authorize(Policy = "Admin")]
    public ActionResult Get(int id)
    {
      return Ok(applicationServiceCliente.GetById(id));
    }

    [HttpGet("usuarios/{usuarioId}")]
    [Authorize(Policy = "User")]
    public ActionResult GetByUsuarioId(int usuarioId)
    {
      return Ok(applicationServiceCliente.GetByUsuarioId(usuarioId));
    }

    [HttpPost]
    [Authorize(Policy = "User")]
    public ActionResult Post([FromBody] ClienteDto clienteDto)
    {
      try
      {
        if (clienteDto == null)
        {
          return NotFound();
        }
        applicationServiceCliente.Save(clienteDto);
        return Ok("Cliente cadastrado com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    [HttpPost("save")]
    [Authorize(Policy = "User")]
    public ActionResult Save([FromBody] ClienteDto clienteDto)
    {
      try
      {
        if (clienteDto == null)
        {
          return NotFound();
        }
        applicationServiceCliente.Save(clienteDto);
        return Ok("Cliente salvo com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    [HttpPut]
    [Authorize(Policy = "User")]
    public ActionResult Put([FromBody] ClienteDto clienteDto)
    {
      try
      {
        if (clienteDto == null)
        {
          return NotFound();
        }
        applicationServiceCliente.Save(clienteDto);
        return Ok("Cliente atualizado com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    [HttpDelete]
    [Authorize(Policy = "User")]
    public ActionResult Delete([FromBody] ClienteDto clienteDto)
    {
      try
      {
        if (clienteDto == null)
        {
          return NotFound();
        }
        applicationServiceCliente.Remove(clienteDto);
        return Ok("Cliente removido com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
