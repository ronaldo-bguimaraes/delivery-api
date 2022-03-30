using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestAPiModeloDDD.Infrastructure.Data.Repositories
{
    public class RepositoryBase<T> : IRespositoryBase<T> where T : class{
        private readonly SqlContext sqlContext;

        public RepositoryBase(SqlContext _sqlcontext)
        {
                sqlContext = _sqlcontext;
        }

        public void Add(T obj)
        {
            try
            { 
                sqlContext.Set<T>().Add(obj);
                sqlContext.SaveChanges();
            } catch (Exception ex)
            {
                throw ex;

            }
        }
        public void Remove(T obj)
        {
            try
            {
                sqlContext.Set<T>().Remove(obj);
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public IEnumerable<T> GetAll()
        {
            return sqlContext.Set<T>().ToList();
        }

        public T GetTById(int id)
        {
            return sqlContext.Set<T>().Find(id);
        }

        public void Update(T obj)
        {
            try
            {
                sqlContext.Entry(obj).State = EntityState.Modified;
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
