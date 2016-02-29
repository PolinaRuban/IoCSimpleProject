using IocSimpleProject.Models;

namespace IocSimpleProject.Database.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
    }

    public class UserRepository : Repository<User>, IUserRepository
    {

    }
}