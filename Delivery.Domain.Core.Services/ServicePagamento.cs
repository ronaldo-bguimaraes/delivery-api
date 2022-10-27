using System;
using System.Linq;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;
using Delivery.Domain.Enums;

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
      pagamento.setDataPagamento();
      base.Add(pagamento);
    }

    public void validarPagamento(Pagamento pagamento) { }

    public void confirmarPagamento(Pagamento pagamento) { }
  }
}
