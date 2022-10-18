using Delivery.Application;
using Delivery.Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Delivery.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class FornecedoresController : Controller
  {
    private readonly IApplicationServiceFornecedor applicationServiceFornecedor;

    public FornecedoresController(IApplicationServiceFornecedor _applicationServiceFornecedor)
    {
      applicationServiceFornecedor = _applicationServiceFornecedor;
    }

    [HttpGet]
    [Authorize(Policy = "User")]
    public ActionResult Get()
    {
      return Ok(applicationServiceFornecedor.GetAll());
    }

    [HttpGet("{id}")]
    [Authorize(Policy = "User")]
    public ActionResult Get(int id)
    {
      return Ok(applicationServiceFornecedor.GetById(id));
    }

    [HttpGet("usuarios/{usuarioId}")]
    [Authorize(Policy = "User")]
    public ActionResult GetByUsuarioId(int usuarioId)
    {
      return Ok(applicationServiceFornecedor.GetByUsuarioId(usuarioId));
    }

    [HttpPost]
    [Authorize(Policy = "User")]
    public ActionResult Post([FromBody] FornecedorDto clienteDto)
    {
      try
      {
        if (clienteDto == null)
        {
          return NotFound();
        }
        applicationServiceFornecedor.Save(clienteDto);
        return Ok("Fornecedor cadastrado com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    [HttpPost("save")]
    [Authorize(Policy = "User")]
    public ActionResult Save([FromBody] FornecedorDto clienteDto)
    {
      try
      {
        if (clienteDto == null)
        {
          return NotFound();
        }
        applicationServiceFornecedor.Save(clienteDto);
        return Ok("Fornecedor salvo com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    [HttpPut]
    [Authorize(Policy = "User")]
    public ActionResult Put([FromBody] FornecedorDto clienteDto)
    {
      try
      {
        if (clienteDto == null)
        {
          return NotFound();
        }
        applicationServiceFornecedor.Save(clienteDto);
        return Ok("Fornecedor atualizado com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    [HttpDelete]
    [Authorize(Policy = "User")]
    public ActionResult Delete([FromBody] FornecedorDto clienteDto)
    {
      try
      {
        if (clienteDto == null)
        {
          return NotFound();
        }
        applicationServiceFornecedor.Remove(clienteDto);
        return Ok("Fornecedor removido com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
