using MySolutions.Contracts.IRepositories;

namespace MySolutions.Contracts
{
    public interface IRepositoryManager
    {
        ICompanyRepository Company { get; }
        IEmployeeRepository Employee { get; }
        void Save();
    }
}