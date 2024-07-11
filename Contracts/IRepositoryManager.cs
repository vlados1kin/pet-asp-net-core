namespace Contracts;

public interface IRepositoryManager
{
    IEmployeeRepository Employee { get; }
    ICompanyRepository Company { get; }
    Task SaveAsync();
}