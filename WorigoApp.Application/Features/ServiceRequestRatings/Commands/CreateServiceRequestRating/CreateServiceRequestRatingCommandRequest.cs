using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceRequestRatings.Commands.CreateServiceRequestRating
{
    public class CreateServiceRequestRatingCommandRequest : IRequest<ResponseDto<CreateServiceRequestRatingCommandResponse>>
    {
        public int ServiceRequestId { get; set; }
        public int? CustomerId { get; set; }
        public decimal SpeedScore { get; set; }
        public decimal QualityScore { get; set; }
        public decimal StaffScore { get; set; }
        public string? Comment { get; set; }
    }
}
