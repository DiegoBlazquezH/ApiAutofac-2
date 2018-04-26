using EjemploApi.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploApi.DataAccess.WSVueling
{
    public interface IWSVueling
    {
        Task<Usuario> GetAsync();
        Task<Usuario> SetAsync(Usuario usuario);
    }
}
