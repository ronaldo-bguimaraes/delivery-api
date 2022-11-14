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
    // Fazer um controller para chamar a applicationService
    private readonly IApplicationServiceProduto applicationServiceProduto;

    public ProdutosController(IApplicationServiceProduto _applicationServiceProduto)
    {
      applicationServiceProduto = _applicationServiceProduto;
    }


    [HttpGet]
    [Authorize(Policy = "User")]
    public ActionResult Get()
    {
      return Ok(applicationServiceProduto.GetAll());
    }


    [HttpGet("{id}")]
    [Authorize(Policy = "User")]
    public ActionResult Get(int id)
    {
      return Ok(applicationServiceProduto.GetById(id));
    }


    [HttpPost]
    [Authorize(Policy = "User")]
    public ActionResult Post([FromBody] ProdutoDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceProduto.Save(enderecoDto);
        return Ok("Produto cadastrado com sucesso!");
      }
      catch (Exception)
      {
        throw;
      }
    }

    [HttpPost("save")]
    [Authorize(Policy = "User")]
    public ActionResult Save([FromBody] ProdutoDto produtoDto)
    {
      try
      {
        if (produtoDto == null)
        {
          return NotFound();
        }
        applicationServiceProduto.Save(produtoDto);
        return Ok("Produto salvo com sucesso!");
      }
      catch (Exception)
      {
        throw;
      }
    }

    [HttpPut]
    [Authorize(Policy = "User")]
    public ActionResult Put([FromBody] ProdutoDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceProduto.Save(enderecoDto);
        return Ok("Produto atualizado com sucesso!");
      }
      catch (Exception)
      {
        throw;
      }
    }


    [HttpDelete]
    [Authorize(Policy = "User")]
    public ActionResult Delete([FromBody] ProdutoDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceProduto.Remove(enderecoDto);
        return Ok("Produto removido com sucesso!");
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
