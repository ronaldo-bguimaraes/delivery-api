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

    [HttpGet("confirmar/{id}")]
    [Authorize(Policy = "User")]
    public ActionResult Confirmar(int id)
    {
      try {
        applicationServiceVenda.Confirmar(id);
        return Ok();
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao confirmar a venda" });
      }
    }

    [HttpGet("cancelar/{id}")]
    [Authorize(Policy = "User")]
    public ActionResult Cancelar(int id)
    {
      try {
        applicationServiceVenda.Cancelar(id);
        return Ok();
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao cancelar a venda" });
      }
    }

    [HttpGet("clientes/{id}")]
    [Authorize(Policy = "User")]
    public ActionResult GetByClienteId(int id)
    {
      return Ok(applicationServiceVenda.GetByClienteId(id));
    }

    [HttpGet("fornecedores/{id}")]
    [Authorize(Policy = "User")]
    public ActionResult GetByFornecedorId(int id)
    {
      return Ok(applicationServiceVenda.GetByFornecedorId(id));
    }

    [HttpPost]
    [Authorize(Policy = "User")]
    public ActionResult Post([FromBody] VendaDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }
        applicationServiceVenda.Save(dto);
        return Ok("Venda cadastrada com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao cadastrar a venda" });
      }
    }

    [HttpPost("save")]
    [Authorize(Policy = "User")]
    public ActionResult Save([FromBody] VendaDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }
        applicationServiceVenda.Save(dto);
        return Ok("Venda cadastrada com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao salvar a venda" });
      }
    }

    [HttpPut]
    [Authorize(Policy = "User")]
    public ActionResult Put([FromBody] VendaDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }
        applicationServiceVenda.Save(dto);
        return Ok("Venda atualizada com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao atualizar a venda" });
      }
    }

    [HttpDelete]
    [Authorize(Policy = "User")]
    public ActionResult Delete([FromBody] VendaDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }
        applicationServiceVenda.Remove(dto);
        return Ok("Venda removida com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao remover a venda" });
      }
    }
  }
}
