using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceCliente
  {
    void Save(ClienteDto clienteDto);

    void Remove(ClienteDto clienteDto);

    ICollection<ClienteDto> GetAll();

    ClienteDto GetById(int id);

    ClienteDto GetByUsuarioId(int id);
  }
}
