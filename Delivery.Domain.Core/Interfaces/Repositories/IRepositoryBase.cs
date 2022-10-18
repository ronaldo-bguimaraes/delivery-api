﻿using System.Collections.Generic;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryBase<T> where T : EntityBase
  {
    void Add(T obj);
    void Update(T obj);
    void Remove(T obj);
    ICollection<T> GetAll(); // Pode ser usado uma lista, mas o ICollection funciona melhor
    T GetById(int id);
  }
}
