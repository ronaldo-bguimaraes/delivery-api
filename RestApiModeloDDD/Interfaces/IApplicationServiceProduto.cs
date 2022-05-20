using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceProduto
  {

    void Add(ProdutoDto produtoDto);

    void Update(ProdutoDto produtoDto);

    void Remove(ProdutoDto produtoDto);

    IEnumerable<ProdutoDto> GetAll();

    ProdutoDto GetById(int id);
  }
}
