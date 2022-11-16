using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Services
{
  public class ServicePagamento : ServiceBase<Pagamento>, IServicePagamento

  {
    private readonly IRepositoryPagamento RepositoryPagamento;

    public ServicePagamento(IRepositoryPagamento repositoryPagamento) : base(repositoryPagamento)
    {
      RepositoryPagamento = repositoryPagamento;
    }

    public override void Add(Pagamento pagamento)
    {
      pagamento.SetDataPagamentoAtual();
      base.Add(pagamento);
    }

    public void ValidarPagamento(Pagamento pagamento) { }

    public void ConfirmarPagamento(Pagamento pagamento) { }
  }
}
