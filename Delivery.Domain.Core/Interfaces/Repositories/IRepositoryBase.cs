using System.Collections.Generic;
using Delivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryBase<T> where T : EntityBase
  {
    public void Add(T obj);
    public void Update(T obj);
    public void Remove(T obj);
    public DbSet<T> All();
    public T GetById(int id);
  }
}
