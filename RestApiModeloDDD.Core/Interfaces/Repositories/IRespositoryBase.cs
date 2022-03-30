using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Core.Interfaces.Repositories
{
  public interface IRespositoryBase<T> where T : class{
        void Add(T obj);
        void Update (T obj);
        void Remove(T obj);
        IEnumerable<T> GetAll();   //Pode ser usado uma lista, mas o Ienumerable funciona melhor
        T GetTById(int id);
    }
}
