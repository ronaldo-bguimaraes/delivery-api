using Delivery.Application;
using Delivery.Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Delivery.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ProdutosController : Controller
  {
    private readonly IApplicationServiceProduto ApplicationServiceProduto;

    public ProdutosController(IApplicationServiceProduto applicationServiceProduto)
    {
      ApplicationServiceProduto = applicationServiceProduto;
    }

    [HttpGet]
    [Authorize(Policy = "User")]
    public ActionResult Get()
    {
      return Ok(ApplicationServiceProduto.GetAll());
    }

    [HttpGet("{id}")]
    [Authorize(Policy = "User")]
    public ActionResult Get(int id)
    {
      return Ok(ApplicationServiceProduto.GetById(id));
    }

    [HttpGet("fornecedores/{id}")]
    [Authorize(Policy = "User")]
    public ActionResult GetByFornecedorId(int id)
    {
      return Ok(ApplicationServiceProduto.GetByFornecedorId(id));
    }

    [HttpPost]
    [Authorize(Policy = "User")]
    public ActionResult Post([FromBody] ProdutoDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }
        ApplicationServiceProduto.Save(dto);
        return Ok("Produto cadastrado com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao cadastrar o produto" });
      }
    }

    [HttpPost("save")]
    [Authorize(Policy = "User")]
    public ActionResult Save([FromBody] ProdutoDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }
        ApplicationServiceProduto.Save(dto);
        return Ok("Produto salvo com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao salvar o produto" });
      }
    }

    [HttpPut]
    [Authorize(Policy = "User")]
    public ActionResult Put([FromBody] ProdutoDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }
        ApplicationServiceProduto.Save(dto);
        return Ok("Produto atualizado com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao atualizar o produto" });
      }
    }

    [HttpDelete]
    [Authorize(Policy = "User")]
    public ActionResult Delete([FromBody] ProdutoDto dto)
    {
      try
      {
        if (dto == null)
        {
          return NotFound();
        }
        ApplicationServiceProduto.Remove(dto);
        return Ok("Produto removido com sucesso!");
      }
      catch (Exception)
      {
        return BadRequest(new { message = "Erro ao remover o produto" });
      }
    }
  }
}
