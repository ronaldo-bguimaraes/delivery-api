using System.Collections.Generic;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Services
{
  public interface IServiceBase<T> where T : EntityBase
  {
    void Add(T obj);
    void Update(T obj);
    void Remove(T obj);
    ICollection<T> GetAll();
    T GetById(int id);
  }
}
