using System.Collections.Generic;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Services
{
  public interface IServiceVenda : IServiceBase<Venda> {
    public void realizarVenda(Venda venda);
    public void validarVenda(Venda venda);
    ICollection<Venda> GetByClienteId(int clienteId);
  }
}
