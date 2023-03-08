using MySolutions.Contracts.IRepositories;
using MySolutions.Domain.Entities;

namespace MySolutions.Repository.Repositories
{

    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {

        }
    }

}