using AutoMapper;
using WorigoApp.Application.Features.Departments.Queries.GetAllDepartment;
using WorigoApp.Application.Features.EmployeeTypes.Queries.GetAllEmployeeTypes;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Concrete.Mapping
{

    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeType, GetAllEmployeeTypesQueryResponse>()
                .ForMember(dest => dest.GetAllDepartmentQueryResponse, opt => opt.MapFrom(src => src.Department));

            CreateMap<Department, GetAllDepartmentQueryResponse>();
        }
    }
}
