using Delivery.Application;
using Delivery.Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Delivery.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class VendasController : Controller
  {
    // Fazer um controller para chamar a applicationService
    private readonly IApplicationServiceVenda applicationServiceVenda;

    public VendasController(IApplicationServiceVenda _applicationServiceVenda)
    {
      applicationServiceVenda = _applicationServiceVenda;
    }


    [HttpGet]
    [Authorize(Policy = "User")]
    public ActionResult Get()
    {
      return Ok(applicationServiceVenda.GetAll());
    }


    [HttpGet("{id}")]
    [Authorize(Policy = "User")]
    public ActionResult Get(int id)
    {
      return Ok(applicationServiceVenda.GetById(id));
    }

    [HttpGet("clientes/{clienteId}")]
    [Authorize(Policy = "User")]
    public ActionResult GetByClienteId(int clienteId)
    {
      return Ok(applicationServiceVenda.GetByClienteId(clienteId));
    }


    [HttpPost]
    [Authorize(Policy = "User")]
    public ActionResult Post([FromBody] VendaDto vendaDto)
    {
      try
      {
        if (vendaDto == null)
        {
          return NotFound();
        }
        applicationServiceVenda.Save(vendaDto);
        return Ok("Venda cadastrada com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao cadastrar a venda" });
      }
    }

    [HttpPost("save")]
    [Authorize(Policy = "User")]
    public ActionResult Save([FromBody] VendaDto vendaDto)
    {
      try
      {
        if (vendaDto == null)
        {
          return NotFound();
        }
        applicationServiceVenda.Save(vendaDto);
        return Ok("Venda cadastrada com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao salvar a venda" });
      }
    }

    [HttpPut]
    [Authorize(Policy = "User")]
    public ActionResult Put([FromBody] VendaDto vendaDto)
    {
      try
      {
        if (vendaDto == null)
        {
          return NotFound();
        }
        applicationServiceVenda.Save(vendaDto);
        return Ok("Venda atualizada com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao atualizar a venda" });
      }
    }


    [HttpDelete]
    [Authorize(Policy = "User")]
    public ActionResult Delete([FromBody] VendaDto vendaDto)
    {
      try
      {
        if (vendaDto == null)
        {
          return NotFound();
        }
        applicationServiceVenda.Remove(vendaDto);
        return Ok("Venda removida com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao remover a venda" });
      }
    }
  }
}
