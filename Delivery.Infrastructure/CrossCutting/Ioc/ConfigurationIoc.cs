using Autofac;
using Delivery.Application;
using Delivery.Application.Mappers;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Core.Services;
using Delivery.Infrastructure.CrossCutting.Interface;
using Delivery.Infrastructure.CrossCutting.Map;
using Delivery.Infrastructure.Data.Repositories;

namespace Delivery.Infrastructure.CrossCutting.Ioc
{
  public class ConfigurationIoc
  {
    public static void Load(ContainerBuilder builder)
    {
      builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
      builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
      builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
      builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
      builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
      builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
      builder.RegisterType<MapperCliente>().As<IMapperCliente>();
      builder.RegisterType<MapperProduto>().As<IMapperProduto>();
    }

  }
}
