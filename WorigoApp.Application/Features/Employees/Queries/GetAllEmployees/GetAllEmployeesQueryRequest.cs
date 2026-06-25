using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Employees.Queries.GetAllEmployees
{
/// <summary>
/// GetAllEmployeesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetAllEmployeesQueryRequest : IRequest<ResponseDto<IList<GetAllEmployeesQueryResponse>>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// GetAllEmployeesQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllEmployeesQueryRequest(int hotelid)
        {
            this.HotelId = hotelid;
        }
    }
}
