using System.Collections.Generic;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryVenda : IRepositoryBase<Venda>
  {
    public ICollection<Venda> GetByClienteId(int id);
    public ICollection<Venda> GetByFornecedorId(int id);
  }
}
