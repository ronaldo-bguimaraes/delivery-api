using Delivery.Dtos;
using System;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceCliente
  {
    [Obsolete("Add is deprecated, please use Save instead.")]
    void Add(ClienteDto clienteDto);

    [Obsolete("Update is deprecated, please use Save instead.")]
    void Update(ClienteDto clienteDto);

    void Save(ClienteDto clienteDto);

    void Remove(ClienteDto clienteDto);

    IEnumerable<ClienteDto> GetAll();

    ClienteDto GetById(int id);

    ClienteDto GetByUsuarioId(int id);

  }
}
