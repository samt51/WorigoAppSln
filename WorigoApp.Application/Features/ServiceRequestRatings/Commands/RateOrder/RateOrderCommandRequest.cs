using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceRequestRatings.Commands.RateOrder
{
    public class RateOrderCommandRequest : IRequest<ResponseDto<bool>>
    {
        public string SessionToken { get; set; } = string.Empty;
        public int OrderId { get; set; }
        public decimal SpeedScore { get; set; }
        public decimal QualityScore { get; set; }
        public decimal StaffScore { get; set; }
        public decimal? OverallScore { get; set; }
        public string? Comment { get; set; }
    }
}
