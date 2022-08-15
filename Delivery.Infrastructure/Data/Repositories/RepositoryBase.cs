using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Infrastructure.Data.Repositories
{
  public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
  {
    private readonly SqlContext sqlContext;

    public RepositoryBase(SqlContext _sqlcontext)
    {
      sqlContext = _sqlcontext;
    }

    public virtual void Add(T obj)
    {
      sqlContext.Set<T>().Add(obj);
      sqlContext.SaveChanges();
    }

    public virtual void Remove(T obj)
    {
      var entity = sqlContext.Set<T>().Find(obj.Id);
      sqlContext.Set<T>().Remove(entity);
      sqlContext.SaveChanges();
    }

    public virtual ICollection<T> GetAll()
    {
      return sqlContext.Set<T>().ToList();
    }

    public virtual T GetById(int id)
    {
      return sqlContext.Set<T>().Find(id);
    }

    public virtual void Update(T obj)
    {
      var entity = sqlContext.Set<T>().Find(obj.Id);
      sqlContext.Entry(entity).CurrentValues.SetValues(obj);
      sqlContext.SaveChanges();
    }
  }
}
