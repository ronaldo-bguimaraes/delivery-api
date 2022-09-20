using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Services
{
  public class ServiceFornecedor : ServiceBase<Fornecedor>, IServiceFornecedor
  {
    private readonly IRepositoryFornecedor repositoryFornecedor;

    public ServiceFornecedor(IRepositoryFornecedor _repositoryFornecedor) : base(_repositoryFornecedor)
    {
      repositoryFornecedor = _repositoryFornecedor;
    }

    public Fornecedor GetByUsuarioId(int usuarioId)
    {
      return repositoryFornecedor.GetByUsuarioId(usuarioId);
    }
  }
}
