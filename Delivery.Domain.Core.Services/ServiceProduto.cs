using System.Collections.Generic;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Services
{
  public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
  {
    private readonly IRepositoryProduto RepositoryProduto;

    public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
    {
      RepositoryProduto = repositoryProduto;
    }

    public ICollection<Produto> GetByFornecedorId(int id)
    {
      return RepositoryProduto.GetByFornecedorId(id);
    }
  }
}
