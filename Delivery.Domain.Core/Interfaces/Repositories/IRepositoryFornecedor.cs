using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryFornecedor : IRepositoryBase<Fornecedor>
  {
    public Fornecedor GetByUsuarioId(int usuarioId);
  }
}
