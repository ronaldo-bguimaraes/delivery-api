using Delivery.Application;
using Delivery.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Delivery.Api.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class EnderecosController : Controller
  {
    // Fazer um controller para chamar a applicationService
    private readonly IApplicationServiceVenda applicationServiceEndereco;

    public EnderecosController(IApplicationServiceVenda _applicationServiceEndereco)
    {
      applicationServiceEndereco = _applicationServiceEndereco;
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return Ok(applicationServiceEndereco.GetAll());
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return Ok(applicationServiceEndereco.GetById(id));
    }

    // não está funcionando
    [HttpGet("usuarios/{usuarioId}")]
    public ActionResult<IEnumerable<string>> GetByUsuarioId(int usuarioId)
    {
      return Ok(applicationServiceEndereco.GetByUsuarioId(usuarioId));
    }

    // POST api/values
    [HttpPost]
    public ActionResult Post([FromBody] EnderecoDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceEndereco.Add(enderecoDto);
        return Ok("Endereço Cadastrado com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    // PUT api/values/5
    [HttpPut]
    public ActionResult Put([FromBody] EnderecoDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceEndereco.Update(enderecoDto);
        return Ok("Endereço Atualizado com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    // DELETE api/values/5
    [HttpDelete()]
    public ActionResult Delete([FromBody] EnderecoDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceEndereco.Remove(enderecoDto);
        return Ok("Endereço Removido com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
