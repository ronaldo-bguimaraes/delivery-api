using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceCliente
  {
    public void Save(ClienteDto clienteDto);

    public void Remove(ClienteDto clienteDto);

    public ICollection<ClienteDto> GetAll();

    public ClienteDto GetById(int id);

    public ClienteDto GetByUsuarioId(int id);
  }
}
