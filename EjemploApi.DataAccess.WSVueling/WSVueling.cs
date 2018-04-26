using System;
using System.Net.Http;
using System.Threading.Tasks;
using EjemploApi.Common.Logic;
using static EjemploApi.DataAccess.WSVueling.WSConfiguration;

namespace EjemploApi.DataAccess.WSVueling
{
    public class WSVueling<T> : IWSVueling<T> where T : IModel
    {
        private readonly HttpClient Client;

        public WSVueling(HttpClient Client)
        {
            this.Client = ServiceConfiguration.InitClient(this.Client);
        }

        public async Task<T> GetAsync()
        {
            try
            {
                var response = await Client.GetAsync($"/api/UsuarioAsync/GetAsync?key=prueba1");
                response.EnsureSuccessStatusCode();
                using (HttpContent Content = response.Content)
                {
                    return await Content.ReadAsAsync<T>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T> SetAsync(T entity)
        {
            try
            {
                var response = await Client.PostAsJsonAsync<T>($"/api/UsuarioAsync/SetAsync?key=prueba3", entity);
                response.EnsureSuccessStatusCode();
                using (HttpContent Content = response.Content)
                {
                    return await Content.ReadAsAsync<T>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
