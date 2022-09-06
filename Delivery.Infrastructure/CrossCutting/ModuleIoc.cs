using Autofac;

namespace Delivery.Infrastructure.CrossCutting
{
  public class ModuleIoc : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      ConfigurationIoc.Load(builder);
    }
  }
}
