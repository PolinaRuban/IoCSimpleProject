using System.Threading.Tasks;
using IocSimpleProject.Models;

namespace IocSimpleProject.Database.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        public Task Create(T entity)
        {

        }

        public Task Update(T entity)
        {

        }

        public Task Delete(int id)
        {

        }

        public Task<T> Get(int id)
        {

        }
    }

    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
    }
}