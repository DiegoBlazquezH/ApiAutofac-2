using EjemploApi.Common.Logic;
using EjemploApi.Common.Logic.Logger;
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http;
using EjemploApi.Common.Logic.Properties;

namespace EjemploApi.Business.Logic.Facade.Controllers
{
    public class UsuarioAsyncController : ApiController
    {
        private readonly IUsuarioBlAsync _usuarioBlAsync;
        private readonly ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);

        public UsuarioAsyncController(IUsuarioBlAsync usuarioBlAsync)
        {
            this._usuarioBlAsync = usuarioBlAsync;
        }

        /// <summary>
        /// Get Usuario with specific key
        /// </summary>
        /// <param name="key"> </param>
        /// <returns>Usuario selected</returns>
        [HttpGet]
        public async Task<IHttpActionResult> GetAsync(string key)
        {
            try
            {
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " empieza, realizando Get, key: " + key);
                var result = await this._usuarioBlAsync.GetAsync(key);
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + "devuelve: " + result.ToString());
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                return InternalServerError();
            }
        }

        /// <summary>
        /// Set Usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="key"></param>
        /// <returns>Inserted Usuario</returns>
        [HttpPost]
        public async Task<IHttpActionResult> SetAsync(Usuario usuario, string key)
        {
            try
            {
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " empieza, Usuario: " + usuario.ToString() + ", Key: " + key);
                var result = await this._usuarioBlAsync.SetAsync(usuario, key);
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " termina, Usuario insertado: " + result.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                return InternalServerError();
            }
        }

        [HttpGet]
        public IHttpActionResult Status()
        {
            return Ok();
        }
    }
}
