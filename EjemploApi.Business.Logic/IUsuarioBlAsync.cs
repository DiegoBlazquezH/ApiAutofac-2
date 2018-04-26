using EjemploApi.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploApi.Business.Logic
{
    public interface IUsuarioBlAsync
    {
        Task<Usuario> GetAsync(string key);
        Task<Usuario> SetAsync(Usuario usuario, string key);
    }
}
