using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationVenda
  {

    void Add(VendaDto vendaDto);

    void Update(VendaDto vendaDto);

    void Remove(VendaDto vendaDto);

    IEnumerable<VendaDto> GetAll();

    VendaDto GetById(int id);
  }
}
