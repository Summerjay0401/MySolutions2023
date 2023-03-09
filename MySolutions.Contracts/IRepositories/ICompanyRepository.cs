using MySolutions.Domain.Entities;

namespace MySolutions.Contracts.IRepositories
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
    }
}