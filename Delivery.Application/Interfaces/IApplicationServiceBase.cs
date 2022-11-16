using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceBase<T> where T : class
  {
    public void Save(T clienteDto);
    public void Remove(T clienteDto);
    public ICollection<T> GetAll();
    public T GetById(int id);
  }
}
