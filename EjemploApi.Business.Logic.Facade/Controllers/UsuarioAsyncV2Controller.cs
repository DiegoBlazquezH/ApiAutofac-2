using EjemploApi.Common.Logic;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;


namespace EjemploApi.Business.Logic.Facade.Controllers
{
    public class UsuarioAsyncV2Controller : ApiController
    {
        private readonly IUsuarioBlAsync _usuarioBlAsync;

        public UsuarioAsyncV2Controller(IUsuarioBlAsync usuarioBlAsync)
        {
            this._usuarioBlAsync = usuarioBlAsync;
        }

        /// <summary>
        /// Get Usuario with specific key V2
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IHttpActionResult> GetAsync(string key)
        {
            Thread.Sleep(5000);
            var result = await this._usuarioBlAsync.GetAsync(key);
            return Ok(result);
        }

        /// <summary>
        /// Set Usuario V2
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IHttpActionResult> SetAsync(Usuario usuario, string key)
        {
            Thread.Sleep(5000);
            var result = await this._usuarioBlAsync.SetAsync(usuario, key);
            return Ok(result);
        }
    }
}