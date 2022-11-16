using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Domain.Core.Services
{
  public abstract class ServiceBase<T> : IServiceBase<T> where T : EntityBase
  {
    private readonly IRepositoryBase<T> Repository;

    public ServiceBase(IRepositoryBase<T> repository)
    {
      Repository = repository;
    }

    public virtual void Add(T obj)
    {
      Repository.Add(obj);
    }

    public virtual void Remove(T obj)
    {
      Repository.Remove(obj);
    }

    public virtual ICollection<T> GetAll()
    {
      return Repository.GetAll();
    }

    public virtual T GetById(int id)
    {
      return Repository.GetById(id);
    }

    public virtual void Update(T obj)
    {
      Repository.Update(obj);
    }
  }
}
