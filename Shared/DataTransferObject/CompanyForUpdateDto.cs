namespace Shared.DataTransferObject;

public record CompanyForUpdateDto(
    string Name,
    string Address,
    string Country,
    IEnumerable<EmployeeForCreationDto> Employees);