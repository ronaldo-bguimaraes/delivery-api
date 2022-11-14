using System.Collections.Generic;
using Delivery.Domain.Entities;
using Delivery.Application.Dtos;

namespace Delivery.Application.Interfaces.Mappers
{
  public interface IMapperBase<T, U> where T : EntityDto where U : EntityBase
  {
    U MapperDtoToEntity(T dto);
    T MapperEntityToDto(U entity);
    ICollection<U> MapperDtosToEntities(ICollection<T> dtos);
    ICollection<T> MapperEntitiesToDtos(ICollection<U> entities);
  }
}
