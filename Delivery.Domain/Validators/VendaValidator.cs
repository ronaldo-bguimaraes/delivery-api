using System.Linq;
using Delivery.Domain.Entities;
using Delivery.Domain.Interfaces.Validators;
using FluentValidation;

namespace Delivery.Domain.Validators
{
  public class VendaValidator : AbstractValidator<Venda>, IVendaValidator
  {
    public VendaValidator()
    {
      RuleFor(venda => venda.ClienteId).NotNull();
      RuleFor(venda => venda.Condicao).NotNull();
      RuleFor(venda => venda.DataVenda).NotNull();
      RuleFor(venda => venda.Desconto).GreaterThanOrEqualTo(0).LessThanOrEqualTo(venda => venda.Total);
      RuleFor(venda => venda.Frete).NotNull().GreaterThanOrEqualTo(0);
      RuleFor(venda => venda.ItensProduto).NotNull().Must(x => x.Any());
    }
  }
}