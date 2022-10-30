using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Services
{
  public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
  {
    private readonly IRepositoryProduto repositoryProduto;

    public ServiceProduto(IRepositoryProduto _repositoryProduto) : base(_repositoryProduto)
    {
      repositoryProduto = _repositoryProduto;
    }
  }
}
