using Autofac;
using EjemploApi.DataAccess.WSVueling;

namespace EjemploApi.AutofacConfiguration
{
    class WSVuelingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterGeneric(typeof(WSVueling<>))
                .As(typeof(IWSVueling<>))
                .InstancePerRequest();

            base.Load(builder);
        }
    }
}
