using Delivery.Domain.Entities;
using Delivery.Application.Dtos;
using System.Collections.Generic;
using System.Linq;
using Delivery.Application.Interfaces.Mappers;

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

    public ICollection<FornecedorDto> MapperEntitiesToDtos(ICollection<Fornecedor> fornecedores)
    {
      var fornecedorDtos = fornecedores.Select(fornecedor => new FornecedorDto
      {
        Id = fornecedor.Id,
        Cnpj = fornecedor.Cnpj,
        RazaoSocial = fornecedor.RazaoSocial,
        UsuarioId = fornecedor.UsuarioId,
      });
      return fornecedorDtos.ToList();
    }

    public ICollection<Fornecedor> MapperDtosToEntities(ICollection<FornecedorDto> fornecedorDtos)
    {
      var fornecedores = fornecedorDtos.Select(fornecedorDto => new Fornecedor
      {
        Id = fornecedorDto.Id,
        Cnpj = fornecedorDto.Cnpj,
        RazaoSocial = fornecedorDto.RazaoSocial,
        UsuarioId = fornecedorDto.UsuarioId,
      });
      return fornecedores.ToList();
    }
  }
}
