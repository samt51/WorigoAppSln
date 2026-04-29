using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Reports.Queries.GetTaskSummaryReport
{
    public class GetTaskSummaryReportQueryHandler : BaseHandler, IRequestHandler<GetTaskSummaryReportQueryRequest, ResponseDto<GetTaskSummaryReportQueryResponse>>
    {
        public GetTaskSummaryReportQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<GetTaskSummaryReportQueryResponse>> Handle(GetTaskSummaryReportQueryRequest request, CancellationToken cancellationToken)
        {
            var tasks = await unitOfWork.GetReadRepository<Domain.Entites.EmployeeTask>().GetAllAsync(x => x.HotelId == request.HotelId && !x.IsDeleted);
            var now = DateTime.UtcNow;

            return new ResponseDto<GetTaskSummaryReportQueryResponse>().Success(new GetTaskSummaryReportQueryResponse
            {
                TotalTaskCount = tasks.Count,
                OpenTaskCount = tasks.Count(x => x.Status == EmployeeTaskStatusEnum.Open),
                InProgressTaskCount = tasks.Count(x => x.Status == EmployeeTaskStatusEnum.InProgress),
                CompletedTaskCount = tasks.Count(x => x.Status == EmployeeTaskStatusEnum.Completed),
                OverdueTaskCount = tasks.Count(x => x.DueAt.HasValue && x.DueAt < now && x.Status != EmployeeTaskStatusEnum.Completed && x.Status != EmployeeTaskStatusEnum.Cancelled)
            });
        }
    }
}
