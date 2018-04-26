using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploApi.Common.Logic;
using EjemploApi.DataAccess.Redis;

namespace EjemploApi.Business.Logic
{
    public class UsuarioBlAsync : IUsuarioBlAsync
    {
        private readonly IGetAsync<Usuario> _get;
        private readonly ISetAsync<Usuario> _set;

        public UsuarioBlAsync(IGetAsync<Usuario> get, ISetAsync<Usuario> set)
        {
            _get = get;
            _set = set;
        }

        public Task<Usuario> GetAsync(string key)
        {
            return _get.GetAsync(key);
        }

        public Task<Usuario> SetAsync(Usuario usuario, string key)
        {
            return _set.AddAsync(usuario, key);
        }
    }
}
