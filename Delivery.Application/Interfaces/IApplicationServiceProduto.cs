using System.Collections.Generic;
using Delivery.Application.Dtos;

namespace Delivery.Application
{
  public interface IApplicationServiceProduto : IApplicationServiceBase<ProdutoDto>
  {
    public ICollection<ProdutoDto> GetByFornecedorId(int id);
  }
}
