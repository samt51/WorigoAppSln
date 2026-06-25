using AutoMapper;
using WorigoApp.Application.Features.Companies.Queries.GetAllCompanies;
using WorigoApp.Application.Features.Departments.Queries.GetAllDepartment;
using WorigoApp.Application.Features.EmployeeTypes.Queries.GetAllEmployeeTypes;
using WorigoApp.Application.Features.Foods.Commands.CreateFood;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Concrete.Mapping
{

    /// <summary>
    /// MappingProfile sınıfını temsil eder.
    /// </summary>
    public class MappingProfile : Profile
    {
/// <summary>
/// MappingProfile sınıfının yeni bir örneğini başlatır.
/// </summary>
public MappingProfile()
        {
            CreateMap<EmployeeType, GetAllEmployeeTypesQueryResponse>()
                .ForMember(dest => dest.GetAllDepartmentQueryResponse, opt => opt.MapFrom(src => src.Department));

            CreateMap<Department, GetAllDepartmentQueryResponse>();

            CreateMap<GetAllCompaniesQueryResponse, Company>().ReverseMap();

            CreateMap<Food, CreateFoodCommonRequest>()
                .ForMember(dest => dest.contentOfFoodRequestAndResponseDto, opt => opt.Ignore());
        }
    }
}
