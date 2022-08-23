using System.Collections.Generic;
using Delivery.Dtos;

namespace Delivery.Application
{
  public interface IApplicationServiceProduto
  {
    void Save(ProdutoDto produtoDto);

    void Remove(ProdutoDto produtoDto);

    IEnumerable<ProdutoDto> GetAll();

    ProdutoDto GetById(int id);
  }
}
