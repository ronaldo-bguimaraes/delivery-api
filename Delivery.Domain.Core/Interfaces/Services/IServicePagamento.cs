using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Services
{
  public interface IServicePagamento : IServiceBase<Pagamento> {
    public void validarPagamento(Pagamento pagamento);
    public void confirmarPagamento(Pagamento pagamento);
  }
}
