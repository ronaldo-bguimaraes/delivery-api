using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceVenda
  {

    void Save(VendaDto vendaDto);

    void Remove(VendaDto vendaDto);

    ICollection<VendaDto> GetAll();

    VendaDto GetById(int id);

    ICollection<VendaDto> GetByClienteId(int clienteId);
  }
}
