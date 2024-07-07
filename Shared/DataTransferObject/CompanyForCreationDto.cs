using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObject;

public record CompanyForCreationDto
{
    [Required(ErrorMessage = "Name of a company is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximum length for Name is 30 characters.")]
    public string? Name { get; init; }

    [Required(ErrorMessage = "Address of a company is a required field.")]
    [MaxLength(50, ErrorMessage = "Maximum length for Address is 50 characters.")]
    public string? Address { get; init; }

    [Required(ErrorMessage = "Country is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximum length for Country is 30 characters.")]
    public string? Country { get; init; }

    public IEnumerable<EmployeeForCreationDto>? Employees { get; init; }
}