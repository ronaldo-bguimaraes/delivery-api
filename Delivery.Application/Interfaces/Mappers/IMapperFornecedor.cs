using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperFornecedor //MapeamentoDTO para entidade
    {
    Fornecedor MapperDtoToEntity(FornecedorDto fornecedorDto);
    IEnumerable<FornecedorDto> MapperEntitiesToDtos(IEnumerable<Fornecedor> fornecedores);
    FornecedorDto MapperEntityToDto(Fornecedor fornecedor);
  }
}
