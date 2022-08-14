﻿using Delivery.Application;
using Delivery.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Delivery.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class EnderecosController : Controller
  {
    // Fazer um controller para chamar a applicationService
    private readonly IApplicationServiceEndereco applicationServiceEndereco;

    public EnderecosController(IApplicationServiceEndereco _applicationServiceEndereco)
    {
      applicationServiceEndereco = _applicationServiceEndereco;
    }

    
    [HttpGet]
    [Authorize(Policy = "User")]
    public ActionResult Get()
    {
      return Ok(applicationServiceEndereco.GetAll());
    }

    
    [HttpGet("{id}")]
    [Authorize(Policy = "User")]
    public ActionResult Get(int id)
    {
      return Ok(applicationServiceEndereco.GetById(id));
    }

    [HttpGet("usuarios/{usuarioId}")]
    [Authorize(Policy = "User")]
    public ActionResult GetByUsuarioId(int usuarioId)
    {
      return Ok(applicationServiceEndereco.GetByUsuarioId(usuarioId));
    }

    [HttpPost]
    [Authorize(Policy = "User")]
    public ActionResult Post([FromBody] EnderecoDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceEndereco.Save(enderecoDto);
        return Ok("Endereço cadastrado com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    [HttpPost("save")]
    [Authorize(Policy = "User")]
    public ActionResult Save([FromBody] EnderecoDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceEndereco.Save(enderecoDto);
        return Ok("Endereço salvo com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    [HttpPut]
    [Authorize(Policy = "User")]
    public ActionResult Put([FromBody] EnderecoDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceEndereco.Save(enderecoDto);
        return Ok("Endereço atualizado com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    [HttpDelete]
    [Authorize(Policy = "User")]
    public ActionResult Delete([FromBody] EnderecoDto enderecoDto)
    {
      try
      {
        if (enderecoDto == null)
        {
          return NotFound();
        }
        applicationServiceEndereco.Remove(enderecoDto);
        return Ok("Endereço removido com sucesso!");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}