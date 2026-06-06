using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ServiceRequests.Dtos;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByGuestStay
{
    public class GetServiceRequestsByGuestStayQueryHandler : BaseHandler, IRequestHandler<GetServiceRequestsByGuestStayQueryRequest, ResponseDto<IList<GetServiceRequestsByGuestStayQueryResponse>>>
    {
        public GetServiceRequestsByGuestStayQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetServiceRequestsByGuestStayQueryResponse>>> Handle(GetServiceRequestsByGuestStayQueryRequest request, CancellationToken cancellationToken)
        {
            var guestStay = await unitOfWork.GetReadRepository<GuestStay>()
                .GetAsync(x => x.Id == request.GuestStayId && !x.IsDeleted);

            var translations = await unitOfWork.GetReadRepository<Translation>()
                .GetAllAsync(x =>
                    x.LanguageCode == guestStay.GuestLanguageCode &&
                    x.TableName == "ServiceRequestStatus" &&
                    x.FieldName == "DisplayName" &&
                    x.IsActive &&
                    !x.IsDeleted);

            var data = await unitOfWork.GetReadRepository<ServiceRequest>().GetAllAsync(
                x => x.GuestStayId == request.GuestStayId && !x.IsDeleted,
                include: query => query
                    .Include(x => x.ServiceDefinition)
                    .ThenInclude(x => x.ServiceCategory)
                    .Include(x => x.FieldValues)
                    .Include(x => x.Items),
                orderBy: x => x.OrderByDescending(y => y.RequestedAt));

            var response = data.Select(x => new GetServiceRequestsByGuestStayQueryResponse
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ServiceType = x.ServiceType,
                Status = x.Status,
                StatusKey = ResolveMobileStatusKey(x.Status),
                StatusDisplayName = ResolveMobileStatusDisplayName(x.Status, translations),
                LanguageCode = x.LanguageCode,
                RequestedAt = x.RequestedAt,
                CompletedAt = x.CompletedAt,
                AssignedEmployeeId = x.AssignedEmployeeId,
                DepartmentId = x.DepartmentId,
                ServiceDefinitionId = x.ServiceDefinitionId,
                ServiceDefinitionName = x.ServiceDefinition?.Name,
                ServiceCategoryId = x.ServiceDefinition?.ServiceCategoryId,
                ServiceCategoryName = x.ServiceDefinition?.ServiceCategory?.Name,
                ConversationId = x.ConversationId,
                FieldValues = x.FieldValues
                    .Where(fieldValue => !fieldValue.IsDeleted)
                    .Select(fieldValue => new ServiceRequestFieldValueDto
                    {
                        ServiceDefinitionFieldId = fieldValue.ServiceDefinitionFieldId,
                        FieldKey = fieldValue.FieldKey,
                        Value = fieldValue.Value
                    })
                    .ToList(),
                Items = x.Items
                    .Where(item => !item.IsDeleted)
                    .Select(item => new ServiceRequestItemDto
                    {
                        ServiceDefinitionId = item.ServiceDefinitionId,
                        ItemName = item.ItemName,
                        Quantity = item.Quantity,
                        Note = item.Note
                    })
                    .ToList()
            }).ToList();

            return new ResponseDto<IList<GetServiceRequestsByGuestStayQueryResponse>>().Success(response);
        }

        private static string ResolveMobileStatusKey(WorigoApp.Domain.Enums.ServiceRequestStatusEnum status)
        {
            return status switch
            {
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.Open => "pending",
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.Assigned => "preparing",
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.InProgress => "preparing",
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.WaitingCustomer => "pending",
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.OnTheWay => "on_the_way",
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.Completed => "completed",
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.Cancelled => "cancelled",
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.Closed => "completed",
                _ => "pending"
            };
        }

        private static string ResolveMobileStatusDisplayName(WorigoApp.Domain.Enums.ServiceRequestStatusEnum status, IList<Translation> translations)
        {
            var translated = translations.FirstOrDefault(x => x.RecordId == (int)status)?.TranslationValue;
            if (!string.IsNullOrWhiteSpace(translated))
            {
                return translated;
            }

            return status switch
            {
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.Open => "Bekliyor",
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.Assigned => "Hazirlaniyor",
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.InProgress => "Hazirlaniyor",
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.WaitingCustomer => "Bekliyor",
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.OnTheWay => "Yolda",
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.Completed => "Tamamlandi",
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.Cancelled => "Iptal Edildi",
                WorigoApp.Domain.Enums.ServiceRequestStatusEnum.Closed => "Tamamlandi",
                _ => "Bekliyor"
            };
        }
    }
}
