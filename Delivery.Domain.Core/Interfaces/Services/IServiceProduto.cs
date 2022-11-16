using Delivery.Domain.Entities;
using System.Collections.Generic;

namespace Delivery.Domain.Core.Interfaces.Services
{
  public interface IServiceProduto : IServiceBase<Produto>
  {
    public ICollection<Produto> GetByFornecedorId(int id);
  }
}
