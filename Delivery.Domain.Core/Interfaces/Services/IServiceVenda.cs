using System.Collections.Generic;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Services
{
  public interface IServiceVenda : IServiceBase<Venda>
  {
    public void Solicitar(Venda venda);
    public void Cancelar(Venda venda);
    public void Confirmar(Venda venda);
    public void Processar(Venda venda);
    ICollection<Venda> GetByClienteId(int clienteId);
  }
}
