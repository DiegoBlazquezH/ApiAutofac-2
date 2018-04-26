using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploApi.Common.Logic;
using EjemploApi.DataAccess.Redis;
using EjemploApi.DataAccess.WSVueling;

namespace EjemploApi.Business.Logic
{
    public class UsuarioBlAsync : IUsuarioBlAsync
    {
        private readonly IGetAsync<Usuario> Get;
        private readonly ISetAsync<Usuario> Set;
        private readonly IWSVueling<Usuario> WsVueling;

        public UsuarioBlAsync(IGetAsync<Usuario> get, ISetAsync<Usuario> set, IWSVueling<Usuario> wsVueling)
        {
            this.Get = get;
            this.Set = set;
            this.WsVueling = wsVueling;
        }

        public async Task<Usuario> GetAsync(string key)
        {
            return await this.Get.GetAsync(key);
        }

        public async Task<Usuario> SetAsync(Usuario usuario, string key)
        {
            return await this.Set.AddAsync(usuario, key);
        }

        public async Task<Usuario> GetAsyncWS()
        {
            return await this.WsVueling.GetAsync();
        }
    }
}
