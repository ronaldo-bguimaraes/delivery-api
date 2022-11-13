using System.Collections.Generic;
using Delivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryBase<T> where T : EntityBase
  {
    void Add(T obj);
    void Update(T obj);
    void Remove(T obj);
    DbSet<T> All();
    T GetById(int id);
  }
}
