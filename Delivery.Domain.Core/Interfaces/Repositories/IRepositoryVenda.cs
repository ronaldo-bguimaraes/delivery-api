using System.Collections.Generic;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryVenda : IRepositoryBase<Venda>
  {
    ICollection<Venda> GetByClienteId(int clienteId);
  }
}
