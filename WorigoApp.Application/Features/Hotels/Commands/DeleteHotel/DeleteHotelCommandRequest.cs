using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hotels.Commands.DeleteHotel
{
/// <summary>
/// DeleteHotelCommandRequest sınıfını temsil eder.
/// </summary>
public class DeleteHotelCommandRequest : IRequest<ResponseDto<DeleteHotelCommandResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
    }
}
