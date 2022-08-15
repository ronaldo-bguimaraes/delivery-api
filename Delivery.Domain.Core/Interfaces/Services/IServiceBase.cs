using System.Collections.Generic;

namespace Delivery.Domain.Core.Interfaces.Services
{
  public interface IServiceBase<T> where T : class
  {
    void Add(T obj);
    void Update(T obj);
    void Remove(T obj);
    ICollection<T> GetAll();   //Pode ser usado uma lista, mas o Ienumerable funciona melhor
    T GetById(int id);
  }
}
