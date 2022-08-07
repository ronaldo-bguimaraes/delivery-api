using Delivery.Application;
using Delivery.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Delivery.Api.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class ClientesController : Controller
  {
    // Fazer um controller para chamar a applicationService
    private readonly IApplicationServiceCliente applicationServiceCliente;

    public ClientesController(IApplicationServiceCliente _applicationServiceCliente)
    {
      applicationServiceCliente = _applicationServiceCliente;
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return Ok(applicationServiceCliente.GetAll());
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return Ok(applicationServiceCliente.GetById(id));
    }

    [HttpGet("usuarios/{usuarioId}")]
    public ActionResult<string> GetByUsuarioId(int usuarioId)
    {
      return Ok(applicationServiceCliente.GetByUsuarioId(usuarioId));
    }

    // POST api/values
    [HttpPost]
    public ActionResult Post([FromBody] ClienteDto clienteDto)
    {
      try
      {
        if (clienteDto == null)
        {
          return NotFound();
        }
        applicationServiceCliente.Add(clienteDto);
        return Ok("Cliente Cadastrado com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    // PUT api/values/5
    [HttpPut]
    public ActionResult Put([FromBody] ClienteDto clienteDto)
    {
      try
      {
        if (clienteDto == null)
        {
          return NotFound();
        }
        applicationServiceCliente.Update(clienteDto);
        return Ok("Cliente Atualizado com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    // DELETE api/values/5
    [HttpDelete()]
    public ActionResult Delete([FromBody] ClienteDto clienteDto)
    {
      try
      {
        if (clienteDto == null)
        {
          return NotFound();
        }
        applicationServiceCliente.Remove(clienteDto);
        return Ok("Cliente Removido com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
