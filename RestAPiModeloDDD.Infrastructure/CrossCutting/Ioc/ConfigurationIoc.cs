using Autofac;
using RestApiModeloDDD;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Mappers;
using RestApiModeloDDD.Core.Interfaces.Repositories;
using RestApiModeloDDD.Core.Interfaces.Services;
using RestAPiModeloDDD.Infrastructure.CrossCutting.Interface;
using RestAPiModeloDDD.Infrastructure.CrossCutting.Map;
using RestAPiModeloDDD.Infrastructure.Data.Repositories;
using RestpApiModeloDDD.Domain.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPiModeloDDD.Infrastructure.CrossCutting.Ioc
{
    // Baixar autofac antes de trabalhar na classe
    public class ConfigurationIoc {
     public static void Load(ContainerBuilder builder)
        {
            #region IOC
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceCliente>().As<IserviceCliente>();
            builder.RegisterType<ServiceProduto>().As<IserviceProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion
        }

    }
}
