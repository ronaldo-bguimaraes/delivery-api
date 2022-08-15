using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceCliente
  {
    void Save(ClienteDto clienteDto);

    void Remove(ClienteDto clienteDto);

    IEnumerable<ClienteDto> GetAll();

    ClienteDto GetById(int id);

    ClienteDto GetByUsuarioId(int id);
  }
}
