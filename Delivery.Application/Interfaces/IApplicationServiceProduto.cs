using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationProduto
  {

    void Add(ProdutoDto produtoDto);

    void Update(ProdutoDto produtoDtoo);

    void Remove(ProdutoDto produtoDto);

    IEnumerable<ProdutoDto> GetAll();

   PagamentoDto GetById(int id);
  }
}
