using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace Delivery.Domain.Core.Services
{
  public abstract class ServiceBase<T> : IServiceBase<T> where T : class
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

    public virtual ICollection<T> GetAll()
    {
      return repository.GetAll();
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
