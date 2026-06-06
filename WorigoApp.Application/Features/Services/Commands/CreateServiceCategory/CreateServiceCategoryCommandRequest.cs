using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Services.Commands.CreateServiceCategory
{
    public class CreateServiceCategoryCommandRequest : IRequest<ResponseDto<CreateServiceCategoryCommandResponse>>
    {
        public int HotelId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? IconUrl { get; set; }
        public string? IconKey { get; set; }
        public int DisplayOrder { get; set; }
        public bool ShowOnHome { get; set; }
        public bool IsPopular { get; set; }
        public int? HomeDisplayOrder { get; set; }
        public ServicesEnum? LegacyServiceType { get; set; }
    }
}
