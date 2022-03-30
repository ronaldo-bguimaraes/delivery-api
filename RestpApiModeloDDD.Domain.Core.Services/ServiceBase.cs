using RestApiModeloDDD.Core.Interfaces.Repositories;
using RestApiModeloDDD.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestpApiModeloDDD.Domain.Core.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRespositoryBase<T> repository;

        public ServiceBase(IRespositoryBase<T> _repository)
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
