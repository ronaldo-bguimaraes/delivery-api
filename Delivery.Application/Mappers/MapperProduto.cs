using Delivery.Domain.Entities;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Infrastructure.CrossCutting.Map
{
  public class MapperProduto : IMapperProduto
  {
    public Produto MapperDtoToEntity(ProdutoDto produtoDto)
    {
      var produto = new Produto
      {
        ProdutoId = produtoDto.Id,
        Descricao = produtoDto.Descricao,
        Valor = produtoDto.Valor,
        Ingredientes = produtoDto.Ingredientes,
        Disponivel = produtoDto.Disponivel
      };
      return produto;
    }

    public ProdutoDto MapperEntityToDto(Produto produto)
    {
      var produtoDto = new ProdutoDto
      {
        Id = produto.ProdutoId,
        Descricao = produto.Descricao,
        Valor = produto.Valor,
        Ingredientes = produto.Ingredientes,
        Disponivel = produto.Disponivel
      };
      return produtoDto;
    }

    public IEnumerable<ProdutoDto> MapperEntitiesToDtos(IEnumerable<Produto> produtos)
    {
      var produtoDtos = produtos.Select(produto => new ProdutoDto
      {
        Id = produto.ProdutoId,
        Descricao = produto.Descricao,
        Valor = produto.Valor,
        Ingredientes = produto.Ingredientes,
        Disponivel = produto.Disponivel
      });
      return produtoDtos;
    }

    public IEnumerable<Produto> MapperDtosToEntities(IEnumerable<ProdutoDto> produtoDtos)
    {
      var produtos = produtoDtos.Select(produtoDto => new Produto
      {
        ProdutoId = produtoDto.Id,
        Descricao = produtoDto.Descricao,
        Valor = produtoDto.Valor,
        Ingredientes = produtoDto.Ingredientes,
        Disponivel = produtoDto.Disponivel
      });
      return produtos;
    }

  }
}
