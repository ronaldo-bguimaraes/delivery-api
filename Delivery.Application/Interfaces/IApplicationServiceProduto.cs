using System.Collections.Generic;
using Delivery.Application.Dtos;

namespace Delivery.Application
{
  public interface IApplicationServiceProduto
  {
    void Save(ProdutoDto produtoDto);

    void Remove(ProdutoDto produtoDto);

    ICollection<ProdutoDto> GetAll();

    ProdutoDto GetById(int id);
  }
}
