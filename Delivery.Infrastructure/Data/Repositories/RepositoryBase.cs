using Delivery.Domain.Core.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Infrastructure.Data.Repositories
{
  public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
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
      sqlContext.Set<T>().Remove(obj);
      sqlContext.SaveChanges();
    }

    public virtual IEnumerable<T> GetAll()
    {
      return sqlContext.Set<T>().ToList();
    }

    public virtual T GetById(int id)
    {
      return sqlContext.Set<T>().Find(id);
    }

    public virtual void Update(T obj)
    {
      sqlContext.Set<T>().Update(obj);
      sqlContext.SaveChanges();
    }
  }
}
