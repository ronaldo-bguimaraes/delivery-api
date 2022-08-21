using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperProduto //MapeamentoDTO para entidade
  {
    Produto MapperDtoToEntity(ProdutoDto produtodto);
    IEnumerable<ProdutoDto> MapperEntitiesToDtos(IEnumerable<Produto> produtos);
    ProdutoDto MapperEntityToDto(Produto produto);
  }
}
