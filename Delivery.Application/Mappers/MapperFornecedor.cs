using Delivery.Application;
using Delivery.Domain.Entities;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Infrastructure.CrossCutting.Map
{
  public class MapperFornecedor : IMapperFornecedor
  {
    public Fornecedor MapperDtoToEntity(FornecedorDto fornecedorDto)
    {
      var fornecedor = new Fornecedor
      {
        Id = fornecedorDto.Id,
        Cnpj = fornecedorDto.Cnpj,
        RazaoSocial = fornecedorDto.RazaoSocial,
        UsuarioId = fornecedorDto.UsuarioId,
      };
      return fornecedor;
    }

    public FornecedorDto MapperEntityToDto(Fornecedor fornecedor)
    {
      var fornecedorDto = new FornecedorDto
      {
        Id = fornecedor.Id,
        Cnpj = fornecedor.Cnpj,
        RazaoSocial = fornecedor.RazaoSocial,
        UsuarioId = fornecedor.UsuarioId,
      };
      return fornecedorDto;
    }

    public IEnumerable<FornecedorDto> MapperEntitiesToDtos(IEnumerable<Fornecedor> fornecedores)
    {
      var fornecedorDtos = fornecedores.Select(fornecedor => new FornecedorDto
      {
          Id = fornecedor.Id,
          Cnpj = fornecedor.Cnpj,
          RazaoSocial = fornecedor.RazaoSocial,
          UsuarioId = fornecedor.UsuarioId,
      });
      return fornecedorDtos;
    }

    public IEnumerable<Fornecedor> MapperDtosToEntities(IEnumerable<FornecedorDto> fornecedorDtos)
    {
      var fornecedores = fornecedorDtos.Select(fornecedorDto => new Fornecedor
      {
          Id = fornecedorDto.Id,
          Cnpj = fornecedorDto.Cnpj,
          RazaoSocial = fornecedorDto.RazaoSocial,
          UsuarioId = fornecedorDto.UsuarioId,
      });
      return fornecedores;
    }
  }
}
