using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceVenda
  {

    void Save(VendaDto vendaDto);

    void Remove(VendaDto vendaDto);

    IEnumerable<VendaDto> GetAll();

    VendaDto GetById(int id);
  }
}
