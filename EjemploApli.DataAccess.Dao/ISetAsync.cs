using EjemploApi.Common.Logic;
using System.Threading.Tasks;

namespace EjemploApi.DataAccess.Redis
{
    public interface ISetAsync<T> where T : IModel
    {
        Task<T> AddAsync(T entity, string key);
    }
}
