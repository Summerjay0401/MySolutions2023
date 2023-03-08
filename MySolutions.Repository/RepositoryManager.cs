using MySolutions.Contracts;
using MySolutions.Contracts.IRepositories;
using MySolutions.Repository.Repositories;

namespace MySolutions.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICompanyRepository> _companyRepository;
        private readonly Lazy<IEmployeeRepository> _employeeRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _companyRepository = new Lazy<ICompanyRepository>(() => new CompanyRepository(repositoryContext));
            _employeeRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(repositoryContext));
        }
        public ICompanyRepository Company => _companyRepository.Value;
        public IEmployeeRepository Employee => _employeeRepository.Value;

        ICompanyRepository IRepositoryManager.Company => throw new NotImplementedException();

        IEmployeeRepository IRepositoryManager.Employee => throw new NotImplementedException();

        public void Save() => _repositoryContext.SaveChanges();
    }
}