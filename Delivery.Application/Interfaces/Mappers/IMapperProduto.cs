using Delivery.Domain.Entities;
using Delivery.Application.Dtos;

namespace Delivery.Application.Interfaces.Mappers
{
  public interface IMapperProduto : IMapperBase<ProdutoDto, Produto> { }
}
