using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// ServiceDefinitionFieldConfiguration sınıfını temsil eder.
    /// </summary>
    public class ServiceDefinitionFieldConfiguration : IEntityTypeConfiguration<ServiceDefinitionField>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<ServiceDefinitionField> builder)
        {
            var fields = new List<ServiceDefinitionField>();
            var id = 1;

            AddSharedTechnicalFields(fields, ref id, 1, 7);
            AddSharedNoteField(fields, ref id, 101, 103, "Not", false);
            AddFields(fields, ref id, 201,
                Field("luggageCount", "Bagaj adedi", ServiceDefinitionFieldTypeEnum.Number, false, 1),
                Field("pickupLocation", "Alinacak konum", ServiceDefinitionFieldTypeEnum.Text, false, 2),
                Field("note", "Not", ServiceDefinitionFieldTypeEnum.TextArea, false, 3));

            for (var definitionId = 301; definitionId <= 307; definitionId++)
            {
                AddFields(fields, ref id, definitionId,
                    Field("quantity", "Adet", ServiceDefinitionFieldTypeEnum.Number, false, 1),
                    Field("pickupTime", "Teslim alinma saati", ServiceDefinitionFieldTypeEnum.DateTime, false, 2),
                    Field("note", "Not", ServiceDefinitionFieldTypeEnum.TextArea, false, 3));
            }

            AddAppointmentFields(fields, ref id, 401, 402);
            AddFields(fields, ref id, 501,
                Field("pickupLocation", "Nereden", ServiceDefinitionFieldTypeEnum.Text, true, 1),
                Field("destination", "Nereye", ServiceDefinitionFieldTypeEnum.Text, true, 2),
                Field("passengerCount", "Kisi sayisi", ServiceDefinitionFieldTypeEnum.Number, false, 3),
                Field("requestedAt", "Talep edilen zaman", ServiceDefinitionFieldTypeEnum.DateTime, true, 4),
                Field("note", "Not", ServiceDefinitionFieldTypeEnum.TextArea, false, 5));
            AddFields(fields, ref id, 502,
                Field("plateNumber", "Plaka", ServiceDefinitionFieldTypeEnum.Text, true, 1),
                Field("vehicleLocation", "Arac konumu", ServiceDefinitionFieldTypeEnum.Text, false, 2),
                Field("requestedAt", "Talep edilen zaman", ServiceDefinitionFieldTypeEnum.DateTime, false, 3));
            AddFields(fields, ref id, 601,
                Field("items", "Urunler", ServiceDefinitionFieldTypeEnum.TextArea, true, 1),
                Field("note", "Not", ServiceDefinitionFieldTypeEnum.TextArea, false, 2));
            AddFields(fields, ref id, 602,
                Field("wakeUpTime", "Uyandirma saati", ServiceDefinitionFieldTypeEnum.DateTime, true, 1),
                Field("note", "Not", ServiceDefinitionFieldTypeEnum.TextArea, false, 2));
            AddFields(fields, ref id, 603,
                Field("requestedCheckoutTime", "Talep edilen cikis saati", ServiceDefinitionFieldTypeEnum.DateTime, true, 1),
                Field("note", "Not", ServiceDefinitionFieldTypeEnum.TextArea, false, 2));
            AddFields(fields, ref id, 604,
                Field("amenityType", "Malzeme tipi", ServiceDefinitionFieldTypeEnum.Select, true, 1, "[\"Ek yastik\",\"Bebek yatagi\",\"Battaniye\",\"Utu masasi\",\"Diger\"]"),
                Field("quantity", "Adet", ServiceDefinitionFieldTypeEnum.Number, false, 2),
                Field("note", "Not", ServiceDefinitionFieldTypeEnum.TextArea, false, 3));
            AddFields(fields, ref id, 605,
                Field("symptoms", "Belirti/aciklama", ServiceDefinitionFieldTypeEnum.TextArea, true, 1),
                Field("requiresDoctor", "Doktor gerekli mi?", ServiceDefinitionFieldTypeEnum.Boolean, false, 2),
                Field("appointmentTime", "Randevu zamani", ServiceDefinitionFieldTypeEnum.DateTime, false, 3));
            AddFields(fields, ref id, 606,
                Field("incidentType", "Bildirim tipi", ServiceDefinitionFieldTypeEnum.Select, true, 1, "[\"Saglik\",\"Guvenlik\",\"Ilk yardim\",\"Diger\"]"),
                Field("description", "Aciklama", ServiceDefinitionFieldTypeEnum.TextArea, true, 2),
                Field("photo", "Fotograf", ServiceDefinitionFieldTypeEnum.Photo, false, 3));
            AddFields(fields, ref id, 607,
                Field("topic", "Konu", ServiceDefinitionFieldTypeEnum.Text, false, 1),
                Field("question", "Soru", ServiceDefinitionFieldTypeEnum.TextArea, false, 2));
            AddFields(fields, ref id, 608,
                Field("note", "Siparis notu", ServiceDefinitionFieldTypeEnum.TextArea, false, 1));

            builder.HasData(fields);
        }

        private static void AddSharedTechnicalFields(List<ServiceDefinitionField> fields, ref int id, int startDefinitionId, int endDefinitionId)
        {
            for (var definitionId = startDefinitionId; definitionId <= endDefinitionId; definitionId++)
            {
                AddFields(fields, ref id, definitionId,
                    Field("issueDescription", "Ariza aciklamasi", ServiceDefinitionFieldTypeEnum.TextArea, true, 1),
                    Field("photo", "Fotograf", ServiceDefinitionFieldTypeEnum.Photo, false, 2));
            }
        }

        private static void AddSharedNoteField(List<ServiceDefinitionField> fields, ref int id, int startDefinitionId, int endDefinitionId, string label, bool required)
        {
            for (var definitionId = startDefinitionId; definitionId <= endDefinitionId; definitionId++)
            {
                AddFields(fields, ref id, definitionId, Field("note", label, ServiceDefinitionFieldTypeEnum.TextArea, required, 1));
            }
        }

        private static void AddAppointmentFields(List<ServiceDefinitionField> fields, ref int id, params int[] definitionIds)
        {
            foreach (var definitionId in definitionIds)
            {
                AddFields(fields, ref id, definitionId,
                    Field("appointmentTime", "Randevu zamani", ServiceDefinitionFieldTypeEnum.DateTime, true, 1),
                    Field("therapistPreference", "Terapist tercihi", ServiceDefinitionFieldTypeEnum.Text, false, 2),
                    Field("note", "Not", ServiceDefinitionFieldTypeEnum.TextArea, false, 3));
            }
        }

        private static void AddFields(List<ServiceDefinitionField> fields, ref int id, int definitionId, params ServiceDefinitionField[] newFields)
        {
            foreach (var field in newFields)
            {
                field.Id = id++;
                field.ServiceDefinitionId = definitionId;
                fields.Add(field);
            }
        }

        private static ServiceDefinitionField Field(
            string key,
            string label,
            ServiceDefinitionFieldTypeEnum fieldType,
            bool isRequired,
            int displayOrder,
            string? optionsJson = null)
        {
            return new ServiceDefinitionField
            {
                FieldKey = key,
                Label = label,
                FieldType = fieldType,
                IsRequired = isRequired,
                DisplayOrder = displayOrder,
                OptionsJson = optionsJson
            };
        }
    }
}
