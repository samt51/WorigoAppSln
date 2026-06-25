using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// ServiceTranslationSeedConfiguration sınıfını temsil eder.
    /// </summary>
    public class ServiceTranslationSeedConfiguration : IEntityTypeConfiguration<Translation>
    {
        private const string Tr = "tr-TR";
        private const string En = "en-US";
        private const string Ru = "ru-RU";
        private const string Fr = "fr-FR";
        private const string Es = "es-ES";
        private const string Ar = "ar-SA";
        private const string De = "de-DE";
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<Translation> builder)
        {
            var translations = new List<Translation>();
            var id = 10000;

            Add(translations, ref id, "ServiceCategory", 1, "Name", "Oda Hizmetleri", "Housekeeping", "Housekeeping", "Service d'etage", "Servicio de habitacion", "خدمات الغرف", "Housekeeping");
            Add(translations, ref id, "ServiceCategory", 2, "Name", "Teknik Servis", "Technical Service", "Technischer Service", "Service technique", "Servicio tecnico", "الخدمة الفنية", "Техническая служба");
            Add(translations, ref id, "ServiceCategory", 3, "Name", "On Buro", "Reception", "Rezeption", "Reception", "Recepcion", "الاستقبال", "Ресепшен");
            Add(translations, ref id, "ServiceCategory", 4, "Name", "Camasirhane", "Laundry", "Wascherei", "Blanchisserie", "Lavanderia", "المغسلة", "Прачечная");
            Add(translations, ref id, "ServiceCategory", 5, "Name", "Wellness ve Saglik", "Wellness and Health", "Wellness und Gesundheit", "Bien-etre et sante", "Bienestar y salud", "الصحة والعافية", "Велнес и здоровье");
            Add(translations, ref id, "ServiceCategory", 6, "Name", "Ulasim", "Transportation", "Transport", "Transport", "Transporte", "النقل", "Транспорт");
            Add(translations, ref id, "ServiceCategory", 7, "Name", "Yiyecek Icecek", "Food and Beverage", "Speisen und Getranke", "Restauration", "Alimentos y bebidas", "الأطعمة والمشروبات", "Еда и напитки");
            Add(translations, ref id, "ServiceCategory", 8, "Name", "Bilgilendirme", "Information", "Information", "Information", "Informacion", "معلومات", "Информация");

            AddDefinitionNames(translations, ref id);
            AddFieldLabels(translations, ref id);
            AddOptionLabels(translations, ref id);
            AddStatusLabels(translations, ref id);

            builder.HasData(translations);
        }

        private static void AddDefinitionNames(ICollection<Translation> translations, ref int id)
        {
            Add(translations, ref id, "ServiceDefinition", 101, "Name", "Havlu degisimi veya eksigi", "Towel replacement or missing towel", "Handtuchwechsel oder fehlendes Handtuch", "Remplacement ou manque de serviette", "Cambio o falta de toallas", "تغيير المناشف أو نقصها", "Замена или нехватка полотенец");
            Add(translations, ref id, "ServiceDefinition", 102, "Name", "Oda genel temizlik", "General room cleaning", "Allgemeine Zimmerreinigung", "Nettoyage general de la chambre", "Limpieza general de habitacion", "تنظيف عام للغرفة", "Общая уборка номера");
            Add(translations, ref id, "ServiceDefinition", 103, "Name", "Carsaf veya yatak yuzu degisimi", "Sheet or bed linen change", "Bettwaesche wechseln", "Changement des draps", "Cambio de sabanas", "تغيير الشراشف", "Смена постельного белья");
            Add(translations, ref id, "ServiceDefinition", 201, "Name", "Bagaj Tasima", "Luggage assistance", "Gepaeckservice", "Assistance bagages", "Asistencia con equipaje", "مساعدة الأمتعة", "Помощь с багажом");
            Add(translations, ref id, "ServiceDefinition", 301, "Name", "Utu", "Ironing", "Buegeln", "Repassage", "Planchado", "كي الملابس", "Глажка");
            Add(translations, ref id, "ServiceDefinition", 302, "Name", "T-Shirt", "T-Shirt", "T-Shirt", "T-shirt", "Camiseta", "قميص", "Футболка");
            Add(translations, ref id, "ServiceDefinition", 303, "Name", "Kaban-Mont", "Coat/Jacket", "Mantel/Jacke", "Manteau/Veste", "Abrigo/Chaqueta", "معطف/سترة", "Пальто/Куртка");
            Add(translations, ref id, "ServiceDefinition", 304, "Name", "Kuru Temizleme", "Dry cleaning", "Chemische Reinigung", "Nettoyage a sec", "Limpieza en seco", "تنظيف جاف", "Химчистка");
            Add(translations, ref id, "ServiceDefinition", 305, "Name", "T-Shirt Kuru Temizleme", "T-Shirt dry cleaning", "T-Shirt chemische Reinigung", "Nettoyage a sec T-shirt", "Limpieza en seco de camiseta", "تنظيف جاف للقميص", "Химчистка футболки");
            Add(translations, ref id, "ServiceDefinition", 306, "Name", "Kaban-Mont Kuru Temizleme", "Coat/Jacket dry cleaning", "Mantel/Jacke chemische Reinigung", "Nettoyage a sec manteau/veste", "Limpieza en seco de abrigo/chaqueta", "تنظيف جاف للمعطف/السترة", "Химчистка пальто/куртки");
            Add(translations, ref id, "ServiceDefinition", 307, "Name", "Pantolon", "Trousers", "Hose", "Pantalon", "Pantalones", "بنطال", "Брюки");
            Add(translations, ref id, "ServiceDefinition", 401, "Name", "Uzak Dogu", "Far Eastern massage", "Fernost-Massage", "Massage oriental", "Masaje oriental", "مساج شرقي", "Восточный массаж");
            Add(translations, ref id, "ServiceDefinition", 402, "Name", "Tayland Masaji", "Thai massage", "Thai-Massage", "Massage thailandais", "Masaje tailandes", "مساج تايلاندي", "Тайский массаж");
            Add(translations, ref id, "ServiceDefinition", 501, "Name", "Transfer Talebi", "Transfer request", "Transferanfrage", "Demande de transfert", "Solicitud de traslado", "طلب نقل", "Запрос трансфера");
            Add(translations, ref id, "ServiceDefinition", 502, "Name", "Vale Hizmeti", "Valet service", "Parkservice", "Service voiturier", "Servicio de valet", "خدمة صف السيارات", "Услуга парковщика");
            Add(translations, ref id, "ServiceDefinition", 601, "Name", "Minibar Talebi", "Minibar request", "Minibar-Anfrage", "Demande de minibar", "Solicitud de minibar", "طلب ميني بار", "Запрос мини-бара");
            Add(translations, ref id, "ServiceDefinition", 602, "Name", "Uyandirma Servisi", "Wake-up call", "Weckruf", "Service de reveil", "Servicio despertador", "خدمة الإيقاظ", "Услуга будильника");
            Add(translations, ref id, "ServiceDefinition", 603, "Name", "Konaklama Uzatma", "Stay extension", "Aufenthalt verlaengern", "Prolongation du sejour", "Extension de estancia", "تمديد الإقامة", "Продление проживания");
            Add(translations, ref id, "ServiceDefinition", 604, "Name", "Oda Malzemesi Talebi", "Room amenity request", "Zimmerausstattung anfordern", "Demande d'equipement de chambre", "Solicitud de amenidades", "طلب مستلزمات الغرفة", "Запрос принадлежностей для номера");
            Add(translations, ref id, "ServiceDefinition", 605, "Name", "Medikal Yardim", "Medical assistance", "Medizinische Hilfe", "Assistance medicale", "Asistencia medica", "مساعدة طبية", "Медицинская помощь");
            Add(translations, ref id, "ServiceDefinition", 606, "Name", "Saglik ve Guvenlik", "Health and safety", "Gesundheit und Sicherheit", "Sante et securite", "Salud y seguridad", "الصحة والسلامة", "Здоровье и безопасность");
            Add(translations, ref id, "ServiceDefinition", 607, "Name", "Otel Bilgilendirme ve Duyuru", "Hotel information and announcements", "Hotelinformationen und Ankuendigungen", "Informations et annonces de l'hotel", "Informacion y anuncios del hotel", "معلومات وإعلانات الفندق", "Информация и объявления отеля");
            Add(translations, ref id, "ServiceDefinition", 608, "Name", "Menu Siparisi", "Menu order", "Menuebestellung", "Commande de menu", "Pedido de menu", "طلب قائمة الطعام", "Заказ меню");
        }

        private static void AddFieldLabels(ICollection<Translation> translations, ref int id)
        {
            foreach (var fieldId in Enumerable.Range(1, 14))
            {
                Add(translations, ref id, "ServiceDefinitionField", fieldId, fieldId % 2 == 1 ? "Label" : "Label",
                    fieldId % 2 == 1 ? "Ariza aciklamasi" : "Fotograf",
                    fieldId % 2 == 1 ? "Issue description" : "Photo",
                    fieldId % 2 == 1 ? "Problembeschreibung" : "Foto",
                    fieldId % 2 == 1 ? "Description du probleme" : "Photo",
                    fieldId % 2 == 1 ? "Descripcion del problema" : "Foto",
                    fieldId % 2 == 1 ? "وصف المشكلة" : "صورة",
                    fieldId % 2 == 1 ? "Описание проблемы" : "Фото");
            }

            AddMany(translations, ref id, new[] { 15, 16, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47, 52, 57, 59, 61, 64 }, "Not", "Note", "Notiz", "Note", "Nota", "ملاحظة", "Примечание");
            AddMany(translations, ref id, new[] { 18 }, "Bagaj adedi", "Number of bags", "Anzahl Gepaeckstuecke", "Nombre de bagages", "Cantidad de equipaje", "عدد الحقائب", "Количество багажа");
            AddMany(translations, ref id, new[] { 19 }, "Alinacak konum", "Pickup location", "Abholort", "Lieu de prise en charge", "Lugar de recogida", "مكان الاستلام", "Место получения");
            AddMany(translations, ref id, new[] { 21, 24, 27, 30, 33, 36, 39, 63 }, "Adet", "Quantity", "Anzahl", "Quantite", "Cantidad", "العدد", "Количество");
            AddMany(translations, ref id, new[] { 22, 25, 28, 31, 34, 37, 40 }, "Teslim alinma saati", "Pickup time", "Abholzeit", "Heure de prise en charge", "Hora de recogida", "وقت الاستلام", "Время получения");
            AddMany(translations, ref id, new[] { 42, 45, 67 }, "Randevu zamani", "Appointment time", "Terminzeit", "Heure du rendez-vous", "Hora de cita", "وقت الموعد", "Время записи");
            AddMany(translations, ref id, new[] { 43, 46 }, "Terapist tercihi", "Therapist preference", "Therapeutenwunsch", "Preference de therapeute", "Preferencia de terapeuta", "تفضيل المعالج", "Предпочтение терапевта");
            AddMany(translations, ref id, new[] { 48 }, "Nereden", "From", "Von", "De", "Desde", "من", "Откуда");
            AddMany(translations, ref id, new[] { 49 }, "Nereye", "To", "Nach", "Vers", "Hacia", "إلى", "Куда");
            AddMany(translations, ref id, new[] { 50 }, "Kisi sayisi", "Passenger count", "Personenzahl", "Nombre de personnes", "Numero de personas", "عدد الأشخاص", "Количество пассажиров");
            AddMany(translations, ref id, new[] { 51, 55 }, "Talep edilen zaman", "Requested time", "Gewuenschte Zeit", "Heure demandee", "Hora solicitada", "الوقت المطلوب", "Запрошенное время");
            AddMany(translations, ref id, new[] { 53 }, "Plaka", "Plate number", "Kennzeichen", "Plaque d'immatriculation", "Matricula", "رقم اللوحة", "Номер автомобиля");
            AddMany(translations, ref id, new[] { 54 }, "Arac konumu", "Vehicle location", "Fahrzeugstandort", "Emplacement du vehicule", "Ubicacion del vehiculo", "موقع المركبة", "Местоположение автомобиля");
            AddMany(translations, ref id, new[] { 56 }, "Urunler", "Items", "Artikel", "Articles", "Articulos", "العناصر", "Товары");
            AddMany(translations, ref id, new[] { 58 }, "Uyandirma saati", "Wake-up time", "Weckzeit", "Heure de reveil", "Hora de despertar", "وقت الإيقاظ", "Время будильника");
            AddMany(translations, ref id, new[] { 60 }, "Talep edilen cikis saati", "Requested checkout time", "Gewuenschte Check-out-Zeit", "Heure de depart demandee", "Hora de salida solicitada", "وقت المغادرة المطلوب", "Запрошенное время выезда");
            AddMany(translations, ref id, new[] { 62 }, "Malzeme tipi", "Amenity type", "Ausstattungstyp", "Type d'equipement", "Tipo de amenidad", "نوع المستلزمات", "Тип принадлежности");
            AddMany(translations, ref id, new[] { 65 }, "Belirti/aciklama", "Symptoms/description", "Symptome/Beschreibung", "Symptomes/description", "Sintomas/descripcion", "الأعراض/الوصف", "Симптомы/описание");
            AddMany(translations, ref id, new[] { 66 }, "Doktor gerekli mi?", "Is a doctor required?", "Ist ein Arzt erforderlich?", "Un medecin est-il necessaire?", "Se requiere medico?", "هل الطبيب مطلوب؟", "Нужен врач?");
            AddMany(translations, ref id, new[] { 68 }, "Bildirim tipi", "Incident type", "Meldungstyp", "Type d'incident", "Tipo de incidencia", "نوع البلاغ", "Тип сообщения");
            AddMany(translations, ref id, new[] { 69 }, "Aciklama", "Description", "Beschreibung", "Description", "Descripcion", "الوصف", "Описание");
            AddMany(translations, ref id, new[] { 70 }, "Fotograf", "Photo", "Foto", "Photo", "Foto", "صورة", "Фото");
            AddMany(translations, ref id, new[] { 71 }, "Konu", "Topic", "Thema", "Sujet", "Tema", "الموضوع", "Тема");
            AddMany(translations, ref id, new[] { 72 }, "Soru", "Question", "Frage", "Question", "Pregunta", "سؤال", "Вопрос");
            AddMany(translations, ref id, new[] { 73 }, "Siparis notu", "Order note", "Bestellnotiz", "Note de commande", "Nota del pedido", "ملاحظة الطلب", "Примечание к заказу");
        }

        private static void AddOptionLabels(ICollection<Translation> translations, ref int id)
        {
            Add(translations, ref id, "ServiceDefinitionFieldOption", 1, "Label", "Ek yastik", "Extra pillow", "Zusatzkissen", "Oreiller supplementaire", "Almohada extra", "وسادة إضافية", "Дополнительная подушка");
            Add(translations, ref id, "ServiceDefinitionFieldOption", 2, "Label", "Bebek yatagi", "Baby bed", "Babybett", "Lit bebe", "Cuna", "سرير طفل", "Детская кровать");
            Add(translations, ref id, "ServiceDefinitionFieldOption", 3, "Label", "Battaniye", "Blanket", "Decke", "Couverture", "Manta", "بطانية", "Одеяло");
            Add(translations, ref id, "ServiceDefinitionFieldOption", 4, "Label", "Utu masasi", "Ironing board", "Buegelbrett", "Planche a repasser", "Tabla de planchar", "طاولة كي", "Гладильная доска");
            Add(translations, ref id, "ServiceDefinitionFieldOption", 5, "Label", "Diger", "Other", "Andere", "Autre", "Otro", "أخرى", "Другое");
            Add(translations, ref id, "ServiceDefinitionFieldOption", 6, "Label", "Saglik", "Health", "Gesundheit", "Sante", "Salud", "صحة", "Здоровье");
            Add(translations, ref id, "ServiceDefinitionFieldOption", 7, "Label", "Guvenlik", "Security", "Sicherheit", "Securite", "Seguridad", "الأمن", "Безопасность");
            Add(translations, ref id, "ServiceDefinitionFieldOption", 8, "Label", "Ilk yardim", "First aid", "Erste Hilfe", "Premiers secours", "Primeros auxilios", "إسعافات أولية", "Первая помощь");
            Add(translations, ref id, "ServiceDefinitionFieldOption", 9, "Label", "Diger", "Other", "Andere", "Autre", "Otro", "أخرى", "Другое");
        }

        private static void AddStatusLabels(ICollection<Translation> translations, ref int id)
        {
            Add(translations, ref id, "ServiceRequestStatus", 1, "DisplayName", "Bekliyor", "Pending", "Ausstehend", "En attente", "Pendiente", "قيد الانتظار", "Ожидает");
            Add(translations, ref id, "ServiceRequestStatus", 2, "DisplayName", "Hazirlaniyor", "Preparing", "In Vorbereitung", "En preparation", "Preparando", "قيد التحضير", "Готовится");
            Add(translations, ref id, "ServiceRequestStatus", 8, "DisplayName", "Yolda", "On the way", "Unterwegs", "En route", "En camino", "في الطريق", "В пути");
            Add(translations, ref id, "ServiceRequestStatus", 5, "DisplayName", "Tamamlandi", "Completed", "Abgeschlossen", "Termine", "Completado", "مكتمل", "Завершено");
            Add(translations, ref id, "ServiceRequestStatus", 6, "DisplayName", "Iptal Edildi", "Cancelled", "Storniert", "Annule", "Cancelado", "ملغي", "Отменено");
        }

        private static void AddMany(ICollection<Translation> translations, ref int id, IEnumerable<int> recordIds, string tr, string en, string de, string fr, string es, string ar, string ru)
        {
            foreach (var recordId in recordIds)
            {
                Add(translations, ref id, "ServiceDefinitionField", recordId, "Label", tr, en, de, fr, es, ar, ru);
            }
        }

        private static void Add(ICollection<Translation> translations, ref int id, string table, int recordId, string field, string tr, string en, string de, string fr, string es, string ar, string ru)
        {
            translations.Add(new Translation(id++, table, recordId, field, tr, Tr));
            translations.Add(new Translation(id++, table, recordId, field, en, En));
            translations.Add(new Translation(id++, table, recordId, field, ru, Ru));
            translations.Add(new Translation(id++, table, recordId, field, fr, Fr));
            translations.Add(new Translation(id++, table, recordId, field, es, Es));
            translations.Add(new Translation(id++, table, recordId, field, ar, Ar));
            translations.Add(new Translation(id++, table, recordId, field, de, De));
        }
    }
}
