using AutoMapper;
using Entities.Models;
using Shared.DataTransferObject;

namespace UltimateASPNETApp;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Company, CompanyDto>().ForMember(c => c.FullAddress,
            options => options.MapFrom(x => string.Join(' ', x.Address, x.Country)));
        // CreateMap<Company, CompanyDto>()
        //     .ForCtorParam("FullAddress", options => options.MapFrom(x => string.Join(' ', x.Address, x.Country)));
        //
        CreateMap<Employee, EmployeeDto>();
        
        CreateMap<CompanyForCreationDto, Company>();
    }
}