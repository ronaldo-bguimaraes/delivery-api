using RestApiModeloDDD.Domain.Entities;
using RestApiModeloDDD.Dtos;
using RestAPiModeloDDD.Infrastructure.CrossCutting.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestAPiModeloDDD.Infrastructure.CrossCutting.Map
{
    public class MapperProduto: IMapperProduto{
        public Produto MapperDtoToEntity(ProdutoDto produtodto)
        {
            var produto = new Produto()
            {
                Id = produtodto.Id,
                Nome = produtodto.Nome,
                Valor = produtodto.Valor,
            };
            return produto;
        }

       

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor,
            
            };
            return produtoDto;
        }


        public IEnumerable<ProdutoDto> MapperlistClientesDto(IEnumerable<Produto> produto)
        {
            var dto=produto.Select(c => new ProdutoDto
            {
                Id = c.Id,
                Nome = c.Nome,
                Valor = c.Valor
            });
            return dto;
        }

        
    }
}
