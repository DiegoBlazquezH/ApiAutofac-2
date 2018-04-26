using System;
using System.Net.Http;
using System.Threading.Tasks;
using EjemploApi.Common.Logic;
using static EjemploApi.DataAccess.WSVueling.WSConfiguration;

namespace EjemploApi.DataAccess.WSVueling
{
    public class WSVueling : IWSVueling
    {
        private readonly HttpClient Client;

        public WSVueling(HttpClient Client)
        {
            //Configuramos el cliente
            this.Client = ServiceConfiguration.InitClient(this.Client);
        }

        public async Task<Usuario> GetAsync()
        {
            try
            {

                var response = await Client.GetAsync($"/api/UsuarioAsync/GetAsync/");
                response.EnsureSuccessStatusCode();
                using (HttpContent Content = response.Content)
                {
                    return await Content.ReadAsAsync<Usuario>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Usuario> SetAsync(Usuario usuario)
        {
            try
            {

                var response = await Client.PostAsJsonAsync<Usuario>($"/api/UsuarioAsync/SetAsync/", usuario);
                response.EnsureSuccessStatusCode();
                using (HttpContent Content = response.Content)
                {
                    return await Content.ReadAsAsync<Usuario>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
