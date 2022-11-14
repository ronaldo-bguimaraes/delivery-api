using System.Collections;
using System.Collections.Generic;
using Delivery.Domain.Entities;
using FluentValidation;

namespace Delivery.Domain.Interfaces.Validators
{
  public interface IBaseValidator<T> : IValidator<T>, IValidator, IEnumerable<IValidationRule>, IEnumerable where T : EntityBase { }
}
