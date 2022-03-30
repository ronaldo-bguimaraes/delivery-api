using RestApiModeloDDD.Core.Interfaces.Services;
using RestApiModeloDDD.Dtos;
using RestAPiModeloDDD.Infrastructure.CrossCutting.Interface;
using RestpApiModeloDDD.Domain.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IserviceCliente serviceCliente;
        private readonly IMapperCliente mapperCliente;

        public ApplicationServiceCliente(IserviceCliente serviceCliente
                                       , IMapperCliente _mapperCliente)
        {
            this.serviceCliente = serviceCliente;
            this.mapperCliente = _mapperCliente;
        }
        public void Add(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = serviceCliente.GetAll();
            return  mapperCliente.MapperlistClientesDto(clientes);

           
        }

        public ClienteDto GetById(int id)
        {
            var cliente = serviceCliente.GetTById(id);
            return mapperCliente.MapperEntityToDto(cliente);
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Update(cliente);
        }
    }
}
