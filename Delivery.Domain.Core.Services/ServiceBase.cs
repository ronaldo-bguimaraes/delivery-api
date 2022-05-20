using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace Delivery.Domain.Core.Services
{
  public class ServiceBase<T> : IServiceBase<T> where T : class
  {
    private readonly IRepositoryBase<T> repository;

    public ServiceBase(IRepositoryBase<T> _repository)
    {
      repository = _repository;
    }

    public void Add(T obj)
    {
      repository.Add(obj);

    }
    public void Remove(T obj)
    {
      repository.Remove(obj);
    }

    public IEnumerable<T> GetAll()
    {
      return repository.GetAll();
    }

    public T GetTById(int id)
    {
      return repository.GetTById(id);
    }

    public void Update(T obj)
    {
      repository.Update(obj);
    }
  }
}
