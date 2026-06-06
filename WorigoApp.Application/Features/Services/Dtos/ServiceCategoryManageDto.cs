using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Services.Dtos
{
    public class ServiceCategoryManageDto
    {
        public int Id { get; set; }
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
        public bool IsActive { get; set; }
    }
}
