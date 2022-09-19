using Delivery.Domain.Entities;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                UsuarioId= entregador.UsuarioId,
                Verificado = entregador.Verificado
                
            };
            return entregadorDto;
        }

        public IEnumerable<EntregadorDto> MapperEntitiesToDtos(IEnumerable<Entregador> entregadores)
        {
            var entregadorDtos = entregadores.Select(entregador => new EntregadorDto
            {
                Id = entregador.Id,
                Cpf = entregador.Cpf,
                Sexo = entregador.Sexo,
                UsuarioId = entregador.UsuarioId,
                Verificado = entregador.Verificado
            });
            return entregadorDtos;
        }

        public IEnumerable<Entregador> MapperDtosToEntities(IEnumerable<EntregadorDto> entregadorDtos)
        {
            var entregadores = entregadorDtos.Select(entregadorDto => new Entregador
            {
                Id = entregadorDto.Id,
                Cpf = entregadorDto.Cpf,
                Sexo = entregadorDto.Sexo,
                UsuarioId = entregadorDto.UsuarioId,
                Verificado = entregadorDto.Verificado,
            }) ;
            return entregadores;
        }
    }


}




