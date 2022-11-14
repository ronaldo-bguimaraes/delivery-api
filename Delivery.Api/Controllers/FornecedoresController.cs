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
    public ActionResult Post([FromBody] FornecedorDto fornecedorDto)
    {
      try
      {
        if (fornecedorDto == null)
        {
          return NotFound();
        }
        applicationServiceFornecedor.Save(fornecedorDto);
        return Ok("Fornecedor cadastrado com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao cadastrar o fornecedor" });
      }
    }

    [HttpPost("save")]
    [Authorize(Policy = "User")]
    public ActionResult Save([FromBody] FornecedorDto fornecedorDto)
    {
      try
      {
        if (fornecedorDto == null)
        {
          return NotFound();
        }
        applicationServiceFornecedor.Save(fornecedorDto);
        return Ok("Fornecedor salvo com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao salvar o fornecedor" });
      }
    }

    [HttpPut]
    [Authorize(Policy = "User")]
    public ActionResult Put([FromBody] FornecedorDto fornecedorDto)
    {
      try
      {
        if (fornecedorDto == null)
        {
          return NotFound();
        }
        applicationServiceFornecedor.Save(fornecedorDto);
        return Ok("Fornecedor atualizado com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao remover o fornecedor" });
      }
    }

    [HttpDelete]
    [Authorize(Policy = "User")]
    public ActionResult Delete([FromBody] FornecedorDto fornecedorDto)
    {
      try
      {
        if (fornecedorDto == null)
        {
          return NotFound();
        }
        applicationServiceFornecedor.Remove(fornecedorDto);
        return Ok("Fornecedor removido com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao remover o fornecedor" });
      }
    }
  }
}
