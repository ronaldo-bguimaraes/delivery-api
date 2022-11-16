using System.Collections.Generic;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryBase<T> where T : EntityBase
  {
    public void Add(T obj);
    public void Update(T obj);
    public void Remove(T obj);
    public ICollection<T> GetAll();
    public T GetById(int id);
  }
}
