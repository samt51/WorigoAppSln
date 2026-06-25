using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hotels.Queries.GetAllHotels
{
/// <summary>
/// GetAllHotelsQueryResponse sınıfını temsil eder.
/// </summary>
public class GetAllHotelsQueryResponse
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
/// Companyid değerini alır veya ayarlar.
/// </summary>
public int Companyid { get; set; }
    }
}
