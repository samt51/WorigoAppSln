namespace WorigoApp.Application.Features.Hr.Performance.Commands.CreatePerformanceReview
{
/// <summary>
/// CreatePerformanceReviewCommandResponse sınıfını temsil eder.
/// </summary>
public class CreatePerformanceReviewCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Score değerini alır veya ayarlar.
/// </summary>
public decimal Score { get; set; }
/// <summary>
/// ReviewDate değerini alır veya ayarlar.
/// </summary>
public DateTime ReviewDate { get; set; }
    }
}
