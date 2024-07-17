using Entities.LinkModels;
using Microsoft.AspNetCore.Http;
using Shared.DataTransferObject;

namespace Contracts;

public interface IEmployeeLinks
{
    LinkResponse TryGenerateLinks(IEnumerable<EmployeeDto> employeesDto, string fields, Guid companyId, HttpContext httpContext);
}