using Autofac;

namespace Delivery.Infrastructure.CrossCutting.Ioc
{
  public class ModuleIoc : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      ConfigurationIoc.Load(builder);
    }
  }
}
