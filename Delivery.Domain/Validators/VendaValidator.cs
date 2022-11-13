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
      RuleFor(x => x.ClienteId)
        .NotNull();
      RuleFor(x => x.Condicao)
        .NotNull();
      RuleFor(x => x.DataVenda)
        .NotNull()
        .LessThanOrEqualTo(DateTime.UtcNow);
      RuleFor(x => x.Desconto)
        .NotNull()
        .GreaterThanOrEqualTo(0)
        .LessThanOrEqualTo(x => x.Subtotal);
      RuleFor(x => x.Frete)
        .NotNull()
        .GreaterThanOrEqualTo(0);
      RuleFor(x => x.ItensProduto)
        .NotNull()
        .NotEmpty()
        .Must(x => x != null && x.GroupBy(x => x.Produto.FornecedorId).Count() == 1);
    }
  }
}