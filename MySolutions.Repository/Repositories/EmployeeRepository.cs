using MySolutions.Contracts.IRepositories;
using MySolutions.Domain.Entities;

namespace MySolutions.Repository.Repositories
{
    public class NewBaseType
    {
    }

    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }
    }
}