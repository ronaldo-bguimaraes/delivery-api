using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Domain.Core.Services
{
  public abstract class ServiceBase<T> : IServiceBase<T> where T : EntityBase
  {
    private readonly IRepositoryBase<T> repository;

    public ServiceBase(IRepositoryBase<T> _repository)
    {
      repository = _repository;
    }

    public virtual void Add(T obj)
    {
      repository.Add(obj);
    }

    public virtual void Remove(T obj)
    {
      repository.Remove(obj);
    }

    public virtual ICollection<T> All()
    {
      return repository.All().ToList();
    }

    public virtual T GetById(int id)
    {
      return repository.GetById(id);
    }

    public virtual void Update(T obj)
    {
      repository.Update(obj);
    }
  }
}
