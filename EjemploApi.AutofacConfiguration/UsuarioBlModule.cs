using Autofac;
using EjemploApi.Business.Logic;
using EjemploApi.DataAccess.Redis;
using EjemploApi.DataAccess.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploApi.AutofacConfiguration
{
    class UsuarioBlModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<UsuarioBlAsync>()
                .As<IUsuarioBlAsync>()
                .InstancePerRequest();

            base.Load(builder);
        }
    }
}
