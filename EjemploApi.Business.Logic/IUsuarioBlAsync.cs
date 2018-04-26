using EjemploApi.Common.Logic;
using System.Threading.Tasks;

namespace EjemploApi.Business.Logic
{
    public interface IUsuarioBlAsync
    {
        Task<Usuario> GetAsync(string key);
        Task<Usuario> SetAsync(Usuario usuario, string key);
        Task<Usuario> GetAsyncWS();
    }
}
