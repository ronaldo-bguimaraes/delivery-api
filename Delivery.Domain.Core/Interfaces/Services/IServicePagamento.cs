using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Services
{
  public interface IServicePagamento : IServiceBase<Pagamento>
  {
    public void ValidarPagamento(Pagamento pagamento);
    public void ConfirmarPagamento(Pagamento pagamento);
  }
}
