using RestApiModeloDDD.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPiModeloDDD.Infrastructure.Data.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext sqlContext;
        public RepositoryProduto(SqlContext _sqlcontext) 
        : base(_sqlcontext)
        {
            sqlContext = _sqlcontext;   
        }
    }
}
