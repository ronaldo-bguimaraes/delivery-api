using System.Collections.Generic;
using Delivery.Domain.Entities;
using Delivery.Application.Dtos;

namespace Delivery.Application.Interfaces.Mappers
{
  public interface IMapperBase<T, U> where T : EntityDto where U : EntityBase
  {
    public U MapperDtoToEntity(T dto);
    public T MapperEntityToDto(U entity);
    public ICollection<U> MapperDtosToEntities(ICollection<T> dtos);
    public ICollection<T> MapperEntitiesToDtos(ICollection<U> entities);
  }
}
