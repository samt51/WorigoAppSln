using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Documents.Commands.CreateEmployeeDocument
{
    public class CreateEmployeeDocumentCommandRequest : IRequest<ResponseDto<CreateEmployeeDocumentCommandResponse>>
    {
        public int HotelId { get; set; }
        public int EmployeeId { get; set; }
        public DocumentTypeEnum DocumentType { get; set; }
        public string Title { get; set; } = string.Empty;
        public string FileUrl { get; set; } = string.Empty;
        public string? DocumentNumber { get; set; }
        public DateTime? IssuedAt { get; set; }
        public DateTime? ExpireAt { get; set; }
        public bool IsMandatory { get; set; }
        public int? VerifiedByEmployeeId { get; set; }
        public string? Note { get; set; }
    }
}
