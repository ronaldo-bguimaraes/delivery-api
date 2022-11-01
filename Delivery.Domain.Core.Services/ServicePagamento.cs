using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Services
{
  public class ServicePagamento : ServiceBase<Pagamento>, IServicePagamento

  {
    private readonly IRepositoryPagamento repositoryPagamento;

    public ServicePagamento(IRepositoryPagamento _repositoryPagamento) : base(_repositoryPagamento)
    {
      repositoryPagamento = _repositoryPagamento;
    }

    public override void Add(Pagamento pagamento)
    {
      pagamento.setDataPagamentoAtual();
      base.Add(pagamento);
    }

    public void validarPagamento(Pagamento pagamento) { }

    public void confirmarPagamento(Pagamento pagamento) { }
  }
}
