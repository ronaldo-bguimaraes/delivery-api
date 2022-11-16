using System.Collections.Generic;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryProduto : IRepositoryBase<Produto>
  {
    public ICollection<Produto> GetByFornecedorId(int id);
  }
}
