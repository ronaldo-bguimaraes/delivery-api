using RestApiModeloDDD.Core.Interfaces.Repositories;
using RestApiModeloDDD.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestpApiModeloDDD.Domain.Core.Services
{
    public class ServiceCliente:ServiceBase<Cliente>, IserviceCliente{
        private readonly IRepositoryCliente repositoryCliente;

        public ServiceCliente(IRepositoryCliente _repositoryCliente) : base(_repositoryCliente) { 
        repositoryCliente = _repositoryCliente;
        } 
    }
}
