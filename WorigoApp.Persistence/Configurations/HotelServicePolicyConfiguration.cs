using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// HotelServicePolicyConfiguration sınıfını temsil eder.
    /// </summary>
    public class HotelServicePolicyConfiguration : IEntityTypeConfiguration<HotelServicePolicy>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<HotelServicePolicy> builder)
        {
            var policies = new List<HotelServicePolicy>();
            var id = 1;

            foreach (AccommodationConceptTypeEnum concept in Enum.GetValues(typeof(AccommodationConceptTypeEnum)))
            {
                AddPolicy(policies, ref id, ServicesEnum.HouseKeeping, concept, included: true, chargeable: false);
                AddPolicy(policies, ref id, ServicesEnum.AmenityRequest, concept, included: true, chargeable: false);
                AddPolicy(policies, ref id, ServicesEnum.TechnicalNeed, concept, included: true, chargeable: false);
                AddPolicy(policies, ref id, ServicesEnum.BellBoy, concept, included: true, chargeable: false);
                AddPolicy(policies, ref id, ServicesEnum.WakeUpCall, concept, included: true, chargeable: false);
                AddPolicy(policies, ref id, ServicesEnum.HealthAndSafety, concept, included: true, chargeable: false);

                AddPolicy(policies, ref id, ServicesEnum.Menu, concept, included: concept >= AccommodationConceptTypeEnum.AllInclusive, chargeable: concept < AccommodationConceptTypeEnum.AllInclusive);
                AddPolicy(policies, ref id, ServicesEnum.Minibar, concept, included: concept == AccommodationConceptTypeEnum.UltraAllInclusive, chargeable: concept != AccommodationConceptTypeEnum.UltraAllInclusive);
                AddPolicy(policies, ref id, ServicesEnum.DryCleaner, concept, included: false, chargeable: true);
                AddPolicy(policies, ref id, ServicesEnum.SpaMessage, concept, included: false, chargeable: true);
                AddPolicy(policies, ref id, ServicesEnum.TravelOrTransportation, concept, included: false, chargeable: true);
                AddPolicy(policies, ref id, ServicesEnum.ValetParking, concept, included: false, chargeable: true);
                AddPolicy(policies, ref id, ServicesEnum.StayExtension, concept, included: false, chargeable: true);
                AddPolicy(policies, ref id, ServicesEnum.MedicalAssistance, concept, included: false, chargeable: false);
            }

            builder.HasData(policies);
        }

        private static void AddPolicy(
            IList<HotelServicePolicy> policies,
            ref int id,
            ServicesEnum serviceType,
            AccommodationConceptTypeEnum concept,
            bool included,
            bool chargeable)
        {
            policies.Add(new HotelServicePolicy
            {
                Id = id++,
                HotelId = 1,
                ServiceType = serviceType,
                AccommodationConceptType = concept,
                IsVisible = true,
                IsIncludedInPackage = included,
                IsChargeable = chargeable,
                AllowRoomCharge = true,
                AllowOnlinePayment = false,
                AllowOnSitePayment = true,
                CurrencyCode = "TRY"
            });
        }
    }
}
