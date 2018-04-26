using EjemploApi.Common.Logic;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploApi.DataAccess.Redis
{
    public class RedisConfiguration
    {
        private static readonly Lazy<ConnectionMultiplexer> LazyConnection;

        static RedisConfiguration()
        {
            var configurationOptions = new ConfigurationOptions
            {
                EndPoints = { ConfigurationTools.GetRedisConfiguration() }
            };

            LazyConnection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(configurationOptions));
        }

        public static ConnectionMultiplexer Connection => LazyConnection.Value;

        public static IDatabase RedisCache => Connection.GetDatabase();
    }
}
