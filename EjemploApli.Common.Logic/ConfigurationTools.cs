using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploApi.Common.Logic
{
    public static class ConfigurationTools
    {
        public static string GetRedisConfiguration()
        {
            return ConfigurationManager.AppSettings["RedisEndPoint"];
        }
    }
}
