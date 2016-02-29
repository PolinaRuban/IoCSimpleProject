using System.Threading.Tasks;
using IocSimpleProject.Models;

namespace IocSimpleProject.Database.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task Create(T entity);

        Task Update(T entity);

        Task Delete(int id);

        Task<T> Get(int id);
    }
}