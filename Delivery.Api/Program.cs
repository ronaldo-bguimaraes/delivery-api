using Autofac;
using Autofac.Extensions.DependencyInjection;
using Delivery.Infrastructure.CrossCutting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Delivery.Api
{
  public class Program
  {
    public static void Main(string[] args)
    {
      CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {

      return Host.CreateDefaultBuilder(args)
      .UseServiceProviderFactory(new AutofacServiceProviderFactory())
      .ConfigureContainer<ContainerBuilder>(builder =>
      {
        builder.RegisterModule(new ModuleIoc());
      })
      .ConfigureWebHostDefaults(webBuilder =>
      {
        webBuilder.UseStartup<Startup>();
      });
    }
  }
}
