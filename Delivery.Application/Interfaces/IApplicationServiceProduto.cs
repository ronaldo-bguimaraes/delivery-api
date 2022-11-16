using System.Collections.Generic;
using Delivery.Application.Dtos;

namespace Delivery.Application
{
  public interface IApplicationServiceProduto
  {
    public void Save(ProdutoDto produtoDto);

    public void Remove(ProdutoDto produtoDto);

    public ICollection<ProdutoDto> GetAll();

    public ProdutoDto GetById(int id);
  }
}
