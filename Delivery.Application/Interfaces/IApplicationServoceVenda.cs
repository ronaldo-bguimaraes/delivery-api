using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationVenda
  {

    void Save(VendaDto vendaDto);

    void Remove(VendaDto vendaDto);

    IEnumerable<VendaDto> GetAll();

    VendaDto GetById(int id);
  }
}
