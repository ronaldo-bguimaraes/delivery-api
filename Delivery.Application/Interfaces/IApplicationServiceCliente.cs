using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery
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
