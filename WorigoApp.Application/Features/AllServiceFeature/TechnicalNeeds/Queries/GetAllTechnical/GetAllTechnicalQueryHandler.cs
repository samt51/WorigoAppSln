using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Helpers;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites.GServices;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.AllServiceFeature.TechnicalNeeds.Queries.GetAllTechnical
{
    public class GetAllTechnicalQueryHandler : BaseHandler, IRequestHandler<GetAllTechnicalQueryRequest, Response<IList<GetAllTechnicalQueryResponse>>>
    {
        public GetAllTechnicalQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<IList<GetAllTechnicalQueryResponse>>> Handle(GetAllTechnicalQueryRequest request, CancellationToken cancellationToken)
        {
            var languageCode = Util.GetAcceptLanguageCodeFromToken();

            var data = await unitOfWork.GetReadRepository<TechnicalNeed>().GetAllAsync(x => !x.IsDeleted);

            var cache = Util.GetTranslationFromCache("translation");


            var translations = cache
    .Where(d => d.TableName == ((ServicesEnum)Enum.Parse(typeof(ServicesEnum), "TechnicalNeed")).ToString()
                && d.LanguageCode == languageCode)
    .GroupBy(d => d.RecordId)
    .ToDictionary(g => g.Key, g => g.ToDictionary(t => t.FieldName, t => t.TranslationValue));


            var query = from d1 in data
                        let translation = translations.ContainsKey(d1.Id) ? translations[d1.Id] : null
                        select new GetAllTechnicalQueryResponse
                        {
                            Id = d1.Id,
                            Name = translation != null && translation.ContainsKey("Name") ? translation["Name"] : d1.Name,
                            Description = translation != null && translation.ContainsKey("Description") ? translation["Description"] : d1.Description
                        };

            return new Response<IList<GetAllTechnicalQueryResponse>>().Success(query.ToList());

        }
    }
}
