using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperFornecedor //MapeamentoDTO para entidade
    {
    Fornecedor MapperDtoToEntity(FornecedorDto fornecedordto);
    IEnumerable<FornecedorDto> MapperEntitiesToDtos(IEnumerable<Fornecedor> Fornecedores);
    FornecedorDto MapperEntityToDto(Fornecedor fornecedor);
  }
}
