using EjemploApi.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploApi.DataAccess.WSVueling
{
    public interface IWSVueling<T> where T : IModel
    {
        Task<T> GetAsync();
        Task<T> SetAsync(T entity);
    }
}
