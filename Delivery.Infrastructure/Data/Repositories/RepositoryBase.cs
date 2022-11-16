using System.Collections.Generic;
using System.Linq;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Infrastructure.Data.Repositories
{
  public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
  {
    private readonly SqlContext SqlContext;

    public RepositoryBase(SqlContext sqlcontext)
    {
      SqlContext = sqlcontext;
    }

    public virtual void Add(T obj)
    {
      SqlContext.Set<T>().Add(obj);
      SqlContext.SaveChanges();
    }

    public virtual void Remove(T obj)
    {
      var entity = SqlContext.Set<T>().Find(obj.Id);
      SqlContext.Set<T>().Remove(entity);
      SqlContext.SaveChanges();
    }

    public virtual ICollection<T> GetAll()
    {
      return SqlContext.Set<T>().ToList();
    }

    public virtual T GetById(int id)
    {
      return SqlContext.Set<T>().Find(id);
    }

    public virtual void Update(T obj)
    {
      var entity = SqlContext.Set<T>().Find(obj.Id);
      SqlContext.Entry(entity).CurrentValues.SetValues(obj);
      SqlContext.SaveChanges();
    }
  }
}
