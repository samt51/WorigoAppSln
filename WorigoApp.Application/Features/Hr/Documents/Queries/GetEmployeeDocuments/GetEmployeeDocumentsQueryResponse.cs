using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Documents.Queries.GetEmployeeDocuments
{
    public class GetEmployeeDocumentsQueryResponse
    {
        public int Id { get; set; }
        public DocumentTypeEnum DocumentType { get; set; }
        public string Title { get; set; } = string.Empty;
        public string FileUrl { get; set; } = string.Empty;
        public DateTime? ExpireAt { get; set; }
        public bool IsMandatory { get; set; }
    }
}
