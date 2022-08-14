using Delivery.Dtos;
using System;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceProduto
  {
    [Obsolete("Add is deprecated, please use Save instead.")]
    void Add(ProdutoDto produtoDto);

    void Save(ProdutoDto produtoDto);

    [Obsolete("Update is deprecated, please use Save instead.")]
    void Update(ProdutoDto produtoDto);

    void Remove(ProdutoDto produtoDto);

    IEnumerable<ProdutoDto> GetAll();

    ProdutoDto GetById(int id);
  }
}
