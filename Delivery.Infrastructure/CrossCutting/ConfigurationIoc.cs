using Autofac;
using Delivery.Application;
using Delivery.Application.Mappers;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Core.Services;
using Delivery.Infrastructure.CrossCutting.Interface;
using Delivery.Infrastructure.CrossCutting.Map;
using Delivery.Infrastructure.Data.Repositories;

namespace Delivery.Infrastructure.CrossCutting
{
  public class ConfigurationIoc
  {
    public static void Load(ContainerBuilder builder)
    {
      builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
      builder.RegisterType<RepositoryUsuario>().As<IRepositoryUsuario>();
      builder.RegisterType<RepositoryEndereco>().As<IRepositoryEndereco>();
      builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
      builder.RegisterType<RepositoryVenda>().As<IRepositoryVenda>();
      builder.RegisterType<RepositoryItemProduto>().As<IRepositoryItemProduto>();
     
      builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
      builder.RegisterType<ServiceUsuario>().As<IServiceUsuario>();
      builder.RegisterType<ServiceEndereco>().As<IServiceEndereco>();
      builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
      builder.RegisterType<ServiceVenda>().As<IServiceVenda>();
      builder.RegisterType<ServiceItemProduto>().As<IServiceItemProduto>();
      //
      builder.RegisterType<MapperCliente>().As<IMapperCliente>();
      builder.RegisterType<MapperUsuario>().As<IMapperUsuario>();
      builder.RegisterType<MapperEndereco>().As<IMapperEndereco>();
      builder.RegisterType<MapperProduto>().As<IMapperProduto>();
      builder.RegisterType<MapperVenda>().As<IMapperVenda>();
      builder.RegisterType<MapperItemProduto>().As<IMapperItemProduto>();
      builder.RegisterType<MapperEntregador>().As<IMapperEntregador>();

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
      builder.RegisterType<ApplicationServiceUsuario>().As<IApplicationServiceUsuario>();
      builder.RegisterType<ApplicationServiceEndereco>().As<IApplicationServiceEndereco>();
      builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
      // builder.RegisterType<ApplicationServiceVenda>().As<IApplicationServiceVenda>();
      // builder.RegisterType<ApplicationItemProduto>().As<IApplicationItemProduto>();
    }
  }
}
