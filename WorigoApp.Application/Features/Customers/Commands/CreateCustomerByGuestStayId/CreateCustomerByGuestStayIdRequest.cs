using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Customers.Commands.CreateCustomerByGuestStayId
{
/// <summary>
/// CreateCustomerByGuestStayIdRequest sınıfını temsil eder.
/// </summary>
public class CreateCustomerByGuestStayIdRequest : IRequest<ResponseDto<CreateCustomerByGuestStayIdResponse>>
    {
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
/// <summary>
/// SurName değerini alır veya ayarlar.
/// </summary>
public string SurName { get; set; }
/// <summary>
/// Gender değerini alır veya ayarlar.
/// </summary>
public bool Gender { get; set; }
/// <summary>
/// CreateCustomerByGuestStayIdRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateCustomerByGuestStayIdRequest(int guestStayId, string name, string surName, bool gender)
        {
            this.GuestStayId = guestStayId;
            this.Name = name;
            this.SurName = surName;
            this.Gender = gender;
        }
    }
}
