using Delivery.Domain.Entities;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Infrastructure.CrossCutting.Map
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDto clientedto)
        {
            MapperUsuario usuarioMapper = new MapperUsuario();
            var cliente = new Cliente()
            {
                Id = clientedto.Id,
                Cpf = clientedto.Cpf,
                DataNascimento = clientedto.DataNascimento,
                Usuario = usuarioMapper.MapperDtoToEntity(clientedto.Usuario)
            };
            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            MapperUsuario usuarioMapper = new MapperUsuario();

            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Cpf = cliente.Cpf,
                DataNascimento = cliente.DataNascimento,
                Usuario = usuarioMapper.MapperEntityToDto(cliente.Usuario)

            };
            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperlistClientesDto(IEnumerable<Cliente> clientes)
        {
            MapperUsuario usuarioMapper = new MapperUsuario();
            var dto = clientes.Select(clienteDto => new ClienteDto
            {
                Id = clienteDto.Id,
               
                Cpf = clienteDto.Cpf,
                DataNascimento = clienteDto.DataNascimento,
                Usuario = usuarioMapper.MapperEntityToDto(clienteDto.Usuario)
            });
            return dto;
        }
    }
}
