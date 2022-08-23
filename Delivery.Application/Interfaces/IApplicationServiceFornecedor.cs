using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceFornecedor
  {
    void Save(FornecedorDto fornecedorDto);

    void Remove(FornecedorDto fornecedorDto);

    IEnumerable<FornecedorDto> GetAll();

    FornecedorDto GetById(int id);

    FornecedorDto GetByUsuarioId(int id);

  }
}
