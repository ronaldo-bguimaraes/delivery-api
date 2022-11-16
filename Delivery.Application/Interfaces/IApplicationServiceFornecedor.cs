using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceFornecedor
  {
    public void Save(FornecedorDto fornecedorDto);

    public void Remove(FornecedorDto fornecedorDto);

    public ICollection<FornecedorDto> GetAll();

    public FornecedorDto GetById(int id);

    public FornecedorDto GetByUsuarioId(int id);

  }
}
