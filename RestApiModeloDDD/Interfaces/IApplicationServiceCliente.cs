using RestApiModeloDDD.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDto clienteDto);

        void Update(ClienteDto clienteDto);

        void Remove(ClienteDto clienteDto);

        IEnumerable<ClienteDto> GetAll();
        ClienteDto GetById(int id);

    }
}
