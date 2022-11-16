using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Services
{
  public class ServiceFornecedor : ServiceBase<Fornecedor>, IServiceFornecedor
  {
    private readonly IRepositoryFornecedor RepositoryFornecedor;

    public ServiceFornecedor(IRepositoryFornecedor repositoryFornecedor) : base(repositoryFornecedor)
    {
      RepositoryFornecedor = repositoryFornecedor;
    }

    public Fornecedor GetByUsuarioId(int usuarioId)
    {
      return RepositoryFornecedor.GetByUsuarioId(usuarioId);
    }
  }
}
