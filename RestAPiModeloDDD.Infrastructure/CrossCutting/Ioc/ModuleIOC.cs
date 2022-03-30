using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPiModeloDDD.Infrastructure.CrossCutting.Ioc
{
    public class ModuleIOC: Module {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIoc.Load(builder);
        }
    }
}
