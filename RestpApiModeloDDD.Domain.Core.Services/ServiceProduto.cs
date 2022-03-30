using RestApiModeloDDD.Core.Interfaces.Repositories;
using RestApiModeloDDD.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestpApiModeloDDD.Domain.Core.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IserviceProduto

    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto _repositoryProduto) : base(_repositoryProduto)
        {
            repositoryProduto = _repositoryProduto;
        }
    }
}
