using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceVenda : IApplicationServiceBase<VendaDto>
  {
    public ICollection<VendaDto> GetByClienteId(int id);
    public ICollection<VendaDto> GetByFornecedorId(int id);
    public void Confirmar(int id);
    public void Cancelar(int id);
  }
}
