using System;
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
      RuleFor(e => e.ClienteId).NotNull();
      RuleFor(e => e.Condicao).NotNull();
      RuleFor(e => e.DataVenda).NotNull().LessThanOrEqualTo(DateTime.UtcNow);

      RuleFor(e => e.Desconto)
        .NotNull()
        .GreaterThanOrEqualTo(0)
        .LessThanOrEqualTo(e => e.Subtotal);

      RuleFor(e => e.Frete)
        .NotNull()
        .GreaterThanOrEqualTo(0);

      RuleFor(e => e.ItensProduto)
        .NotNull()
        .NotEmpty()
        .Must(e => e != null && e.GroupBy(e => e.FornecedorId).Count() == 1);
    }
  }
}
