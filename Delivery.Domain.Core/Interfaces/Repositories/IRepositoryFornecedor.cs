using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryFornecedor : IRepositoryBase<Fornecedor>
  {
    Fornecedor GetByUsuarioId(int usuarioId);
  }
}
