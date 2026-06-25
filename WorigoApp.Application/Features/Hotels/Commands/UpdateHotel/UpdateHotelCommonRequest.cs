using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hotels.Commands.UpdateHotel
{
/// <summary>
/// UpdateHotelCommonRequest sınıfını temsil eder.
/// </summary>
public class UpdateHotelCommonRequest :IRequest<ResponseDto<UpdateHotelCommonResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
/// <summary>
/// Location değerini alır veya ayarlar.
/// </summary>
public string Location { get; set; }
/// <summary>
/// Adress değerini alır veya ayarlar.
/// </summary>
public string Adress { get; set; }
/// <summary>
/// PhoneNumber değerini alır veya ayarlar.
/// </summary>
public string PhoneNumber { get; set; }
/// <summary>
/// Email değerini alır veya ayarlar.
/// </summary>
public string Email { get; set; }
/// <summary>
/// NumberOfStar değerini alır veya ayarlar.
/// </summary>
public int NumberOfStar { get; set; }
/// <summary>
/// UpdateHotelCommonRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateHotelCommonRequest(int id,string name, string location, string adress, string phoneNumber, string email, int numberOfStar)
        {
            this.Id = id;
            this.Name = name;
            this.Location = location;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.NumberOfStar = numberOfStar;
        }
    }
}
