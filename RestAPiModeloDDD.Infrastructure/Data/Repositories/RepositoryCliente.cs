using RestApiModeloDDD.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPiModeloDDD.Infrastructure.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext _sqlcontext) : base(_sqlcontext)
        {
          sqlContext = _sqlcontext;
        }
    }
}
