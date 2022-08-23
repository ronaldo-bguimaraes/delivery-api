using Autofac;
using Delivery.Application;
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
      builder.RegisterType<ApplicationServiceUsuario>().As<IApplicationServiceUsuario>();
      builder.RegisterType<ApplicationServiceEndereco>().As<IApplicationServiceEndereco>();


       //
      builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
      builder.RegisterType<ServiceEndereco>().As<IServiceEndereco>();
      //
      builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
      builder.RegisterType<RepositoryUsuario>().As<IRepositoryUsuario>();
      builder.RegisterType<RepositoryEndereco>().As<IRepositoryEndereco>();
      //
      builder.RegisterType<MapperCliente>().As<IMapperCliente>();
      builder.RegisterType<MapperUsuario>().As<IMapperFormaPagamento>();
      builder.RegisterType<MapperEndereco>().As<IMapperEndereco>();
    }
  }
}
