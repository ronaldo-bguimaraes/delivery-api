using RestApiModeloDDD.Domain.Entities;
using RestApiModeloDDD.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPiModeloDDD.Infrastructure.CrossCutting.Interface
{
   public interface IMapperProduto{  //MapeamentoDTO para entidade
       Produto MapperDtoToEntity(ProdutoDto clientedto); 
        IEnumerable<ProdutoDto> MapperlistClientesDto(IEnumerable<Produto>produto);
        ProdutoDto MapperEntityToDto(Produto produto);
    }
}
