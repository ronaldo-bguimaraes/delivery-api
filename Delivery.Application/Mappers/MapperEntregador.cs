using Delivery.Domain.Entities;
using Delivery.Application.Dtos;
using System.Collections.Generic;
using System.Linq;
using Delivery.Application.Interfaces.Mappers;

namespace Delivery.Application.Mappers
{
  public class MapperEntregador : IMapperEntregador
  {
    public Entregador MapperDtoToEntity(EntregadorDto entregadorDto)
    {
      var entregador = new Entregador
      {
        Id = entregadorDto.Id,
        Cpf = entregadorDto.Cpf,
        Sexo = entregadorDto.Sexo,
        Verificado = entregadorDto.Verificado,
        UsuarioId = entregadorDto.UsuarioId,
      };
      return entregador;
    }
    public EntregadorDto MapperEntityToDto(Entregador entregador)
    {
      var entregadorDto = new EntregadorDto
      {
        Id = entregador.Id,
        Cpf = entregador.Cpf,
        Sexo = entregador.Sexo,
        UsuarioId = entregador.UsuarioId,
        Verificado = entregador.Verificado

      };
      return entregadorDto;
    }

    public ICollection<EntregadorDto> MapperEntitiesToDtos(ICollection<Entregador> entregadores)
    {
      var entregadorDtos = entregadores.Select(entregador => new EntregadorDto
      {
        Id = entregador.Id,
        Cpf = entregador.Cpf,
        Sexo = entregador.Sexo,
        UsuarioId = entregador.UsuarioId,
        Verificado = entregador.Verificado
      });
      return entregadorDtos.ToList();
    }

    public ICollection<Entregador> MapperDtosToEntities(ICollection<EntregadorDto> entregadorDtos)
    {
      var entregadores = entregadorDtos.Select(entregadorDto => new Entregador
      {
        Id = entregadorDto.Id,
        Cpf = entregadorDto.Cpf,
        Sexo = entregadorDto.Sexo,
        UsuarioId = entregadorDto.UsuarioId,
        Verificado = entregadorDto.Verificado,
      });
      return entregadores.ToList();
    }
  }


}




