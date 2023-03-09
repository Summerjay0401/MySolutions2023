using MySolutions.Domain.Entities;

namespace MySolutions.Service.Contracts
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
    }
}
