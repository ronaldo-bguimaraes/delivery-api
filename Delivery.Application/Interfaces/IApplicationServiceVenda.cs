using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceVenda
  {

    public void Save(VendaDto vendaDto);

    public void Remove(VendaDto vendaDto);

    public ICollection<VendaDto> GetAll();

    public VendaDto GetById(int id);

    public ICollection<VendaDto> GetByClienteId(int id);
  }
}
