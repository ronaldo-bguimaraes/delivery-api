using Delivery.Domain.Entities;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delivery.Application.Mappers
{
    public class MapperItemProduto: IMapperItemProduto
    {

        public ItemProduto MapperDtoToEntity(ItemProdutoDto itemProdutoDto)
        {
            var itemProduto = new ItemProduto
            {
                Id = itemProdutoDto.Id,
                ProdutoId = itemProdutoDto.ProdutoId,
                VendaId = itemProdutoDto.VendaId,
                Valor = itemProdutoDto.Valor,

            };
            return itemProduto;
        }

        public ItemProdutoDto MapperEntityToDto(ItemProduto itemProduto)
        {
            var itemProdutoDto = new ItemProdutoDto
            {
                Id = itemProduto.Id,
                ProdutoId = itemProduto.ProdutoId,
                VendaId = itemProduto.VendaId,
                Valor = itemProduto.Valor,
            };
            return itemProdutoDto;
        }

        public IEnumerable<ItemProdutoDto> MapperEntitiesToDtos(IEnumerable<ItemProduto> itemProdutos)
        {
            var itemProdutoDtos = itemProdutos.Select(itemProduto => new ItemProdutoDto
            {
                Id = itemProduto.Id,
                ProdutoId = itemProduto.ProdutoId,
                VendaId = itemProduto.VendaId,
                Valor = itemProduto.Valor,
            });
            return itemProdutoDtos;
        }

        public IEnumerable<ItemProduto> MapperDtosToEntities(IEnumerable<ItemProdutoDto> itemProdutoDtos)
        {
            var itemProduto = itemProdutoDtos.Select(itemProdutoDto => new ItemProduto
            {
                Id = itemProdutoDto.Id,
                ProdutoId = itemProdutoDto.ProdutoId,
                VendaId = itemProdutoDto.VendaId,
                Valor = itemProdutoDto.Valor,
            });
            return itemProduto;
        }

        IEnumerable<ItemProduto> IMapperItemProduto.MapperEntitiesToDtos(IEnumerable<ItemProduto> itensProduto)
        {
            throw new NotImplementedException();
        }
    }
}



