using MediatR;

namespace WorigoApp.Application.Features.EmployeeTypes.Queries.GetAllEmployeeTypes
{
    public class GetAllEmployeeTypesQueryRequest : IRequest<IList<GetAllEmployeeTypesQueryResponse>>
    {
        public GetAllEmployeeTypesQueryRequest()
        {

        }
    }
}
