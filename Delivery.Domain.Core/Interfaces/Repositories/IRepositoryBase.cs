using System.Collections.Generic;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryBase<T> where T : class
  {
    void Add(T obj);
    void Update(T obj);
    void Remove(T obj);
    IEnumerable<T> GetAll();   //Pode ser usado uma lista, mas o Ienumerable funciona melhor
    T GetTById(int id);
  }
}
