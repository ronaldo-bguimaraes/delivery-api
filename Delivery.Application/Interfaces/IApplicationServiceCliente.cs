using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceCliente
  {
    void Add(ClienteDto clienteDto);

    void Update(ClienteDto clienteDto);

    void Remove(ClienteDto clienteDto);

    IEnumerable<ClienteDto> GetAll();

    ClienteDto GetById(int id);

    ClienteDto GetByUsuarioId(int id);
  }
}
