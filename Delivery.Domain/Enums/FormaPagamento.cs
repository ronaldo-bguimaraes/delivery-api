namespace Delivery.Domain.Entities
{
  public enum FormaPagamento : int
  {
    Dinheiro = 0,
    CartaoCredito = 1,
    CartaoDebito = 2,
    PIX = 3,
  }
}
