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
    public ActionResult Post([FromBody] VendaDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceVenda.Save(enderecoDto);
        return Ok("Venda cadastrada com sucesso!");
      }
      catch (Exception)
      {
        throw;
      }
    }

    [HttpPost("save")]
    [Authorize(Policy = "User")]
    public ActionResult Save([FromBody] VendaDto produtoDto)
    {
      try
      {
        if (produtoDto == null)
        {
          return NotFound();
        }
        applicationServiceVenda.Save(produtoDto);
        return Ok("Venda cadastrada com sucesso!");
      }
      catch (Exception)
      {
        throw;
      }
    }

    [HttpPut]
    [Authorize(Policy = "User")]
    public ActionResult Put([FromBody] VendaDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceVenda.Save(enderecoDto);
        return Ok("Venda atualizada com sucesso!");
      }
      catch (Exception)
      {
        throw;
      }
    }


    [HttpDelete]
    [Authorize(Policy = "User")]
    public ActionResult Delete([FromBody] VendaDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceVenda.Remove(enderecoDto);
        return Ok("Venda removida com sucesso!");
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
