using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;

namespace EjemploApi.AutofacConfiguration
{
    public class IocConfig
    {
        public static IContainer Build(Assembly ApiAssemblies)
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(ApiAssemblies);

            builder.RegisterModule(new RedisModule());

            builder.RegisterModule(new WSVuelingModules());

            builder.RegisterModule(new WSVuelingModules());

            return builder.Build();
        }
    }
}
