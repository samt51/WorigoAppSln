using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Application.Helpers;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class TranslationConfiguration : IEntityTypeConfiguration<Translation>
    {
        public void Configure(EntityTypeBuilder<Translation> builder)
        {
            #region SystemException
            var data1 = new Translation(1, string.Empty, 0, "UnknownError", "İşlem yaparken bir sorun oluştu. Lütfen tekrar deneyiniz.", LanguageCodeEnum.TR);
            var data2 = new Translation(2, string.Empty, 0, "UnknownError", "There was a problem while processing the transaction. Please try again.", LanguageCodeEnum.US);
            var data3 = new Translation(3, string.Empty, 0, "UnknownError", "Во время обработки возникла проблема. Пожалуйста, попробуйте еще раз.", LanguageCodeEnum.RU);
            var data4 = new Translation(4, string.Empty, 0, "UnknownError", "Un problème est survenu lors du traitement. Veuillez réessayer.", LanguageCodeEnum.FR);
            var data5 = new Translation(5, string.Empty, 0, "UnknownError", "Hubo un problema durante el procesamiento. Por favor inténtalo de nuevo.", LanguageCodeEnum.ES);
            var data6 = new Translation(6, string.Empty, 0, "UnknownError", "حدثت مشكلة أثناء المعالجة. يرجى المحاولة مرة أخرى.", LanguageCodeEnum.SA);

            #endregion

            #region Order Status
            var orderStatus = new Translation(7, "SystemParametreValue", 5, "ParametreValue", "Hazırlanıyor", LanguageCodeEnum.TR);
            var orderStatus2 = new Translation(8, "SystemParametreValue", 6, "ParametreValue", "Geliyor", LanguageCodeEnum.TR);
            var orderStatus3 = new Translation(9, "SystemParametreValue", 7, "ParametreValue", "İptal Edildi", LanguageCodeEnum.TR);

            var orderStatus4 = new Translation(10, "SystemParametreValue", 5, "ParametreValue", "Preparing", LanguageCodeEnum.US);
            var orderStatus5 = new Translation(11, "SystemParametreValue", 6, "ParametreValue", "IsComing", LanguageCodeEnum.US);
            var orderStatus6 = new Translation(12, "SystemParametreValue", 7, "ParametreValue", "Delivered", LanguageCodeEnum.US);

            var orderStatus7 = new Translation(13, "SystemParametreValue", 5, "ParametreValue", "Preparándose", LanguageCodeEnum.ES);
            var orderStatus8 = new Translation(14, "SystemParametreValue", 6, "ParametreValue", "A punto de venir", LanguageCodeEnum.ES);
            var orderStatus9 = new Translation(15, "SystemParametreValue", 7, "ParametreValue", "Entregado", LanguageCodeEnum.ES);

            var orderStatus10 = new Translation(16, "SystemParametreValue", 5, "ParametreValue", "Se préparer", LanguageCodeEnum.FR);
            var orderStatus11 = new Translation(17, "SystemParametreValue", 6, "ParametreValue", "Sur le point de venir.", LanguageCodeEnum.FR);
            var orderStatus12 = new Translation(18, "SystemParametreValue", 7, "ParametreValue", "A été livré.", LanguageCodeEnum.FR);

            var orderStatus13 = new Translation(19, "SystemParametreValue", 5, "ParametreValue", "готовлюсь.", LanguageCodeEnum.RU);
            var orderStatus14 = new Translation(20, "SystemParametreValue", 6, "ParametreValue", "Скоро придет", LanguageCodeEnum.RU);
            var orderStatus15 = new Translation(21, "SystemParametreValue", 7, "ParametreValue", "Доставленный.", LanguageCodeEnum.RU);

            var orderStatus16 = new Translation(22, "SystemParametreValue", 5, "ParametreValue", "الاستعداد", LanguageCodeEnum.SA);
            var orderStatus17 = new Translation(23, "SystemParametreValue", 6, "ParametreValue", "على وشك المجيء", LanguageCodeEnum.SA);
            var orderStatus18 = new Translation(24, "SystemParametreValue", 7, "ParametreValue", "تم التوصيل", LanguageCodeEnum.SA);
            #endregion

            #region Teknik İhtiyaçlar Klima

            var tecnicalNeedsUs = new Translation(25, "TechnicalNeed", 1, "Name", "Air conditioning", LanguageCodeEnum.US);
            var tecnicalNeedsUs2 = new Translation(26, "TechnicalNeed", 1, "Description", "Malfunction situations with air conditioning", LanguageCodeEnum.US);

            var tecnicalNeedsEs = new Translation(27, "TechnicalNeed", 1, "Name", "Aire acondicionado", LanguageCodeEnum.ES);
            var tecnicalNeedsEs2 = new Translation(28, "TechnicalNeed", 1, "Description", "Situaciones de avería con el aire acondicionado.", LanguageCodeEnum.ES);


            var tecnicalNeedsRu = new Translation(29, "TechnicalNeed", 1, "Name", "Кондиционер", LanguageCodeEnum.RU);
            var tecnicalNeedsRu2 = new Translation(30, "TechnicalNeed", 1, "Description", "Ситуации неисправности кондиционера", LanguageCodeEnum.RU);


            var tecnicalNeedsFr = new Translation(31, "TechnicalNeed", 1, "Name", "Climatisation", LanguageCodeEnum.FR);
            var tecnicalNeedsFr2 = new Translation(32, "TechnicalNeed", 1, "Description", "Situations de dysfonctionnement de la climatisation", LanguageCodeEnum.FR);


            var tecnicalNeedsAr = new Translation(33, "TechnicalNeed", 1, "Name", "تكييف", LanguageCodeEnum.SA);
            var tecnicalNeedsAr2 = new Translation(34, "TechnicalNeed", 1, "Description", "حالات الأعطال بالتكييف", LanguageCodeEnum.SA);


            var tecnicalNeedsTr = new Translation(35, "TechnicalNeed", 1, "Name", "Klima", LanguageCodeEnum.TR);
            var tecnicalNeedsTr2 = new Translation(36, "TechnicalNeed", 1, "Description", "Klima ile arıza durumları", LanguageCodeEnum.TR);

            #endregion

            #region Teknik İhtiyaçlar TV

            var tecnicalNeedsTvUs = new Translation(37, "TechnicalNeed", 2, "Name", "TV", LanguageCodeEnum.US);
            var tecnicalNeedsTvUs2 = new Translation(38, "TechnicalNeed", 2, "Description", "Malfunction situations with TV", LanguageCodeEnum.US);

            var tecnicalNeedsTvEs = new Translation(39, "TechnicalNeed", 2, "Name", "TELEVISOR", LanguageCodeEnum.ES);
            var tecnicalNeedsTvEs2 = new Translation(40, "TechnicalNeed", 2, "Description", "Situaciones de mal funcionamiento con TV.", LanguageCodeEnum.ES);


            var tecnicalNeedsTvRu = new Translation(41, "TechnicalNeed", 2, "Name", "ТВ", LanguageCodeEnum.RU);
            var tecnicalNeedsTvRu2 = new Translation(42, "TechnicalNeed", 2, "Description", "Неисправные ситуации с телевизором", LanguageCodeEnum.RU);


            var tecnicalNeedsTvFr = new Translation(43, "TechnicalNeed", 2, "Name", "TV", LanguageCodeEnum.FR);
            var tecnicalNeedsTvFr2 = new Translation(44, "TechnicalNeed", 2, "Description", "Situations de dysfonctionnement avec la télévision", LanguageCodeEnum.FR);


            var tecnicalNeedsTvAr = new Translation(45, "TechnicalNeed", 2, "Name", "تلفزيون", LanguageCodeEnum.SA);
            var tecnicalNeedsTvAr2 = new Translation(46, "TechnicalNeed", 2, "Description", "حالات الأعطال بالتلفاز", LanguageCodeEnum.SA);


            var tecnicalNeedsTvTr = new Translation(47, "TechnicalNeed", 2, "Name", "TV", LanguageCodeEnum.TR);
            var tecnicalNeedsTvTr2 = new Translation(48, "TechnicalNeed", 2, "Description", "TV ile arıza durumları", LanguageCodeEnum.TR);

            #endregion

            #region Teknik İhtiyaçlar Minibar

            var tecnicalNeedsMinibarUs = new Translation(49, "TechnicalNeed", 3, "Name", "Mini-bar", LanguageCodeEnum.US);
            var tecnicalNeedsMinibarUs2 = new Translation(50, "TechnicalNeed", 3, "Description", "Malfunction situations with minibar", LanguageCodeEnum.US);

            var tecnicalNeedsMinibarEs = new Translation(51, "TechnicalNeed", 3, "Name", "Mini-bar", LanguageCodeEnum.ES);
            var tecnicalNeedsMinibarEs2 = new Translation(52, "TechnicalNeed", 3, "Description", "Situaciones de avería con el minibar", LanguageCodeEnum.ES);


            var tecnicalNeedsMinibarRu = new Translation(53, "TechnicalNeed", 3, "Name", "мини-бар", LanguageCodeEnum.RU);
            var tecnicalNeedsMinibarRu2 = new Translation(54, "TechnicalNeed", 3, "Description", "Ситуации неисправности мини-бара", LanguageCodeEnum.RU);


            var tecnicalNeedsMinibarFr = new Translation(55, "TechnicalNeed", 3, "Name", "Mini-bar", LanguageCodeEnum.FR);
            var tecnicalNeedsMinibarFr2 = new Translation(56, "TechnicalNeed", 3, "Description", "Situations de dysfonctionnement du minibar", LanguageCodeEnum.FR);


            var tecnicalNeedsMinibarAr = new Translation(57, "TechnicalNeed", 3, "Name", "ميني بار", LanguageCodeEnum.SA);
            var tecnicalNeedsMinibarAr2 = new Translation(58, "TechnicalNeed", 3, "Description", "حالات الأعطال بالميني بار", LanguageCodeEnum.SA);


            var tecnicalNeedsMinibarTr = new Translation(59, "TechnicalNeed", 3, "Name", "Minibar", LanguageCodeEnum.TR);
            var tecnicalNeedsMinibarTr2 = new Translation(60, "TechnicalNeed", 3, "Description", "Minibar ile arıza durumları", LanguageCodeEnum.TR);

            #endregion

            #region Teknik İhtiyaçlar Kapı

            var tecnicalNeedsDoorUs = new Translation(61, "TechnicalNeed", 4, "Name", "Door", LanguageCodeEnum.US);
            var tecnicalNeedsDoorUs2 = new Translation(62, "TechnicalNeed", 4, "Description", "Fault situations with door", LanguageCodeEnum.US);

            var tecnicalNeedsDoorEs = new Translation(63, "TechnicalNeed", 4, "Name", "Puerta", LanguageCodeEnum.ES);
            var tecnicalNeedsDoorEs2 = new Translation(64, "TechnicalNeed", 4, "Description", "Situaciones de avería con el puerta", LanguageCodeEnum.ES);


            var tecnicalNeedsDoorRu = new Translation(65, "TechnicalNeed", 4, "Name", "Дверь", LanguageCodeEnum.RU);
            var tecnicalNeedsDoorRu2 = new Translation(66, "TechnicalNeed", 4, "Description", "Неисправные ситуации с дверью", LanguageCodeEnum.RU);


            var tecnicalNeedsDoorFr = new Translation(67, "TechnicalNeed", 4, "Name", "Porte", LanguageCodeEnum.FR);
            var tecnicalNeedsDoorFr2 = new Translation(68, "TechnicalNeed", 4, "Description", "Situations de défauts avec la porte", LanguageCodeEnum.FR);


            var tecnicalNeedsDoorAr = new Translation(69, "TechnicalNeed", 4, "Name", "باب", LanguageCodeEnum.SA);
            var tecnicalNeedsDoorAr2 = new Translation(70, "TechnicalNeed", 4, "Description", "حالات خطأ مع الباب", LanguageCodeEnum.SA);


            var tecnicalNeedsDoorTr = new Translation(71, "TechnicalNeed", 4, "Name", "Kapı", LanguageCodeEnum.TR);
            var tecnicalNeedsDoorTr2 = new Translation(72, "TechnicalNeed", 4, "Description", "Kapı ile arıza durumları", LanguageCodeEnum.TR);

            #endregion

            #region Teknik İhtiyaçlar Elektrik

            var tecnicalNeedsElektrikUs = new Translation(73, "TechnicalNeed", 5, "Name", "Electric", LanguageCodeEnum.US);
            var tecnicalNeedsElektrikUs2 = new Translation(74, "TechnicalNeed", 5, "Description", "Electrical fault situations", LanguageCodeEnum.US);

            var tecnicalNeedsElektrikEs = new Translation(75, "TechnicalNeed", 5, "Name", "Eléctrico", LanguageCodeEnum.ES);
            var tecnicalNeedsElektrikEs2 = new Translation(76, "TechnicalNeed", 5, "Description", "Situaciones de falla eléctrica", LanguageCodeEnum.ES);


            var tecnicalNeedsElektrikRu = new Translation(77, "TechnicalNeed", 5, "Name", "Электрический", LanguageCodeEnum.RU);
            var tecnicalNeedsElektrikRu2 = new Translation(78, "TechnicalNeed", 5, "Description", "Ситуации электрических неисправностей", LanguageCodeEnum.RU);


            var tecnicalNeedsElektrikFr = new Translation(79, "TechnicalNeed", 5, "Name", "Électrique", LanguageCodeEnum.FR);
            var tecnicalNeedsElektrikFr2 = new Translation(80, "TechnicalNeed", 5, "Description", "Situations de panne électrique", LanguageCodeEnum.FR);


            var tecnicalNeedsElektrikAr = new Translation(81, "TechnicalNeed", 5, "Name", "كهربائي", LanguageCodeEnum.SA);
            var tecnicalNeedsElektrikAr2 = new Translation(82, "TechnicalNeed", 5, "Description", "حالات الأعطال الكهربائية", LanguageCodeEnum.SA);


            var tecnicalNeedsElektrikTr = new Translation(83, "TechnicalNeed", 5, "Name", "Elektrik", LanguageCodeEnum.TR);
            var tecnicalNeedsElektrikTr2 = new Translation(84, "TechnicalNeed", 5, "Description", "Elektrik ile arıza durumları", LanguageCodeEnum.TR);

            #endregion

            #region Teknik İhtiyaçlar Aydınlatma

            var tecnicalNeedsAydınlatmaUs = new Translation(85, "TechnicalNeed", 6, "Name", "Lighting", LanguageCodeEnum.US);
            var tecnicalNeedsAydınlatmaUs2 = new Translation(86, "TechnicalNeed", 6, "Description", "Malfunction situations with lighting", LanguageCodeEnum.US);

            var tecnicalNeedsAydınlatmaEs = new Translation(87, "TechnicalNeed", 6, "Name", "Iluminación", LanguageCodeEnum.ES);
            var tecnicalNeedsAydınlatmaEs2 = new Translation(88, "TechnicalNeed", 6, "Description", "Situaciones de mal funcionamiento con la iluminación.", LanguageCodeEnum.ES);


            var tecnicalNeedsAydınlatmaRu = new Translation(89, "TechnicalNeed", 6, "Name", "Освещение", LanguageCodeEnum.RU);
            var tecnicalNeedsAydınlatmaRu2 = new Translation(90, "TechnicalNeed", 6, "Description", "Ситуации неисправности с освещением", LanguageCodeEnum.RU);


            var tecnicalNeedsAydınlatmaFr = new Translation(91, "TechnicalNeed", 6, "Name", "Éclairage", LanguageCodeEnum.FR);
            var tecnicalNeedsAydınlatmaFr2 = new Translation(92, "TechnicalNeed", 6, "Description", "Situations de dysfonctionnement de l'éclairage", LanguageCodeEnum.FR);


            var tecnicalNeedsAydınlatmaAr = new Translation(93, "TechnicalNeed", 6, "Name", "إضاءة", LanguageCodeEnum.SA);
            var tecnicalNeedsAydınlatmaAr2 = new Translation(94, "TechnicalNeed", 6, "Description", "حالات الأعطال بالإضاءة", LanguageCodeEnum.SA);


            var tecnicalNeedsAydınlatmaTr = new Translation(95, "TechnicalNeed", 6, "Name", "Aydınlatma", LanguageCodeEnum.TR);
            var tecnicalNeedsAydınlatmaTr2 = new Translation(96, "TechnicalNeed", 6, "Description", "Aydınlatma ile arıza durumları", LanguageCodeEnum.TR);

            #endregion

            #region Teknik İhtiyaçlar Duş ve Tuvalet

            var tecnicalNeedsDusUs = new Translation(97, "TechnicalNeed", 7, "Name", "Shower and Toilet", LanguageCodeEnum.US);
            var tecnicalNeedsDusUs2 = new Translation(98, "TechnicalNeed", 7, "Description", "Malfunction situations with shower and toilet", LanguageCodeEnum.US);

            var tecnicalNeedsDusEs = new Translation(99, "TechnicalNeed", 7, "Name", "Ducha y WC", LanguageCodeEnum.ES);
            var tecnicalNeedsDusEs2 = new Translation(100, "TechnicalNeed", 7, "Description", "Situaciones de avería en ducha y WC", LanguageCodeEnum.ES);


            var tecnicalNeedsDusRu = new Translation(101, "TechnicalNeed", 7, "Name", "Душ и туалет", LanguageCodeEnum.RU);
            var tecnicalNeedsDusRu2 = new Translation(102, "TechnicalNeed", 7, "Description", "Ситуации неисправности с душем и туалетом", LanguageCodeEnum.RU);


            var tecnicalNeedsDusFr = new Translation(103, "TechnicalNeed", 7, "Name", "Douche et WC", LanguageCodeEnum.FR);
            var tecnicalNeedDusFr2 = new Translation(104, "TechnicalNeed", 7, "Description", "Situations de dysfonctionnement avec douche et toilettes", LanguageCodeEnum.FR);


            var tecnicalNeedsDusAr = new Translation(105, "TechnicalNeed", 7, "Name", "دش ومرحاض", LanguageCodeEnum.SA);
            var tecnicalNeedsDusAr2 = new Translation(106, "TechnicalNeed", 7, "Description", "حالات خلل في الدش والمرحاض", LanguageCodeEnum.SA);


            var tecnicalNeedsDusTr = new Translation(107, "TechnicalNeed", 7, "Name", "Duş ve Tuvalet", LanguageCodeEnum.TR);
            var tecnicalNeedsDusTr2 = new Translation(108, "TechnicalNeed", 7, "Description", "Duş ve Tuvalet ile arıza durumları", LanguageCodeEnum.TR);

            #endregion

            #region StatusType

            var statusType = new Translation(109, "SystemParametreValue", 26, "ParametreValue", "In Proccess", LanguageCodeEnum.US);
            var statusType2 = new Translation(110, "SystemParametreValue", 27, "ParametreValue", "Completed", LanguageCodeEnum.US);
            var statusType3 = new Translation(111, "SystemParametreValue", 28, "ParametreValue", "Waiting", LanguageCodeEnum.US);

            var statusTypeEs = new Translation(112, "SystemParametreValue", 26, "ParametreValue", "En proceso", LanguageCodeEnum.ES);
            var statusTypeEs2 = new Translation(113, "SystemParametreValue", 27, "ParametreValue", "Terminado", LanguageCodeEnum.ES);
            var statusTypeEs3 = new Translation(114, "SystemParametreValue", 28, "ParametreValue", "Espera", LanguageCodeEnum.ES);

            var statusTypeRu = new Translation(115, "SystemParametreValue", 26, "ParametreValue", "в процессе", LanguageCodeEnum.RU);
            var statusTypeRu2 = new Translation(116, "SystemParametreValue", 27, "ParametreValue", "завершенный", LanguageCodeEnum.RU);
            var statusTypeRu3 = new Translation(117, "SystemParametreValue", 28, "ParametreValue", "ожидающий", LanguageCodeEnum.RU);

            var statusTypeFr = new Translation(118, "SystemParametreValue", 26, "ParametreValue", "En Cours", LanguageCodeEnum.FR);
            var statusTypeFr2 = new Translation(119, "SystemParametreValue", 27, "ParametreValue", "Complété", LanguageCodeEnum.FR);
            var statusTypeFr3 = new Translation(120, "SystemParametreValue", 28, "ParametreValue", "En Attendant", LanguageCodeEnum.FR);

            var statusTypeSu = new Translation(121, "SystemParametreValue", 26, "ParametreValue", "قيد المعالجة", LanguageCodeEnum.SA);
            var statusTypeSu2 = new Translation(122, "SystemParametreValue", 27, "ParametreValue", "مكتمل", LanguageCodeEnum.SA);
            var statusTypeSu3 = new Translation(123, "SystemParametreValue", 28, "ParametreValue", "منتظر", LanguageCodeEnum.SA);

            var statusTypeTr = new Translation(124, "SystemParametreValue", 26, "ParametreValue", "İşlemde", LanguageCodeEnum.TR);
            var statusTypeTr2 = new Translation(125, "SystemParametreValue", 27, "ParametreValue", "Tamamlandı", LanguageCodeEnum.TR);
            var statusTypeTr3 = new Translation(126, "SystemParametreValue", 28, "ParametreValue", "Bekleniyor", LanguageCodeEnum.TR);

            #endregion

            #region TypesOfHealthAndSports

            var typeOfHealthAndSports = new Translation(127, "SystemParametreValue", 29, "ParametreValue", "Spa", LanguageCodeEnum.US);
            var typeOfHealthAndSports2 = new Translation(128, "SystemParametreValue", 30, "ParametreValue", "Massage", LanguageCodeEnum.US);
            var typeOfHealthAndSports3 = new Translation(129, "SystemParametreValue", 31, "ParametreValue", "Fitness", LanguageCodeEnum.US);
            var typeOfHealthAndSports4 = new Translation(130, "SystemParametreValue", 32, "ParametreValue", "Poor", LanguageCodeEnum.US);

            var typeOfHealthAndSportsEs = new Translation(131, "SystemParametreValue", 29, "ParametreValue", "Spa", LanguageCodeEnum.ES);
            var typeOfHealthAndSportsEs2 = new Translation(132, "SystemParametreValue", 30, "ParametreValue", "Masaje", LanguageCodeEnum.ES);
            var typeOfHealthAndSportsEs3 = new Translation(133, "SystemParametreValue", 31, "ParametreValue", "Aptitud fisica", LanguageCodeEnum.ES);
            var typeOfHealthAndSportsEs4 = new Translation(134, "SystemParametreValue", 32, "ParametreValue", "Piscina", LanguageCodeEnum.ES);

            var typeOfHealthAndSportsRu = new Translation(135, "SystemParametreValue", 29, "ParametreValue", "Спа", LanguageCodeEnum.RU);
            var typeOfHealthAndSportsRu2 = new Translation(136, "SystemParametreValue", 30, "ParametreValue", "Массаж", LanguageCodeEnum.RU);
            var typeOfHealthAndSportsRu3 = new Translation(137, "SystemParametreValue", 31, "ParametreValue", "Фитнес", LanguageCodeEnum.RU);
            var typeOfHealthAndSportsRu4 = new Translation(138, "SystemParametreValue", 32, "ParametreValue", "Бассейн", LanguageCodeEnum.RU);

            var typeOfHealthAndSportsSu = new Translation(139, "SystemParametreValue", 29, "ParametreValue", "سبا", LanguageCodeEnum.SA);
            var typeOfHealthAndSportsSu2 = new Translation(140, "SystemParametreValue", 30, "ParametreValue", "تدليك", LanguageCodeEnum.SA);
            var typeOfHealthAndSportsSu3 = new Translation(141, "SystemParametreValue", 31, "ParametreValue", "لياقة بدنية", LanguageCodeEnum.SA);
            var typeOfHealthAndSportsSu4 = new Translation(142, "SystemParametreValue", 32, "ParametreValue", "حمام السباحة", LanguageCodeEnum.SA);

            var typeOfHealthAndSportsFr = new Translation(143, "SystemParametreValue", 29, "ParametreValue", "Spa", LanguageCodeEnum.FR);
            var typeOfHealthAndSportsFr2 = new Translation(144, "SystemParametreValue", 30, "ParametreValue", "massage", LanguageCodeEnum.FR);
            var typeOfHealthAndSportsFr3 = new Translation(145, "SystemParametreValue", 31, "ParametreValue", "Aptitude", LanguageCodeEnum.FR);
            var typeOfHealthAndSportsFr4 = new Translation(146, "SystemParametreValue", 32, "ParametreValue", "Piscine", LanguageCodeEnum.FR);

            var typeOfHealthAndSportsTr = new Translation(147, "SystemParametreValue", 29, "ParametreValue", "Spa", LanguageCodeEnum.TR);
            var typeOfHealthAndSportsTr2 = new Translation(148, "SystemParametreValue", 30, "ParametreValue", "Masaj", LanguageCodeEnum.TR);
            var typeOfHealthAndSportsTr3 = new Translation(149, "SystemParametreValue", 31, "ParametreValue", "Fitness", LanguageCodeEnum.TR);
            var typeOfHealthAndSportsTr4 = new Translation(150, "SystemParametreValue", 32, "ParametreValue", "Havuz", LanguageCodeEnum.TR);

            #endregion

            #region Services

            var serviceMenuUs = new Translation(151, "SystemParametreValue", 17, "ParametreValue", "Menu", LanguageCodeEnum.US);
            var serviceMenuEs = new Translation(152, "SystemParametreValue", 17, "ParametreValue", "Menú", LanguageCodeEnum.ES);
            var serviceMenuRu = new Translation(153, "SystemParametreValue", 17, "ParametreValue", "Меню", LanguageCodeEnum.RU);
            var serviceMenuFr = new Translation(154, "SystemParametreValue", 17, "ParametreValue", "Menu", LanguageCodeEnum.FR);
            var serviceMenuSa = new Translation(155, "SystemParametreValue", 17, "ParametreValue", "قائمة طعام", LanguageCodeEnum.SA);
            var serviceMenuTr = new Translation(156, "SystemParametreValue", 17, "ParametreValue", "Menü", LanguageCodeEnum.TR);

            var serviceTechnicalUs = new Translation(157, "SystemParametreValue", 18, "ParametreValue", "Technical Needs", LanguageCodeEnum.US);
            var serviceTechnicaEs = new Translation(158, "SystemParametreValue", 18, "ParametreValue", "Necesidades técnicas", LanguageCodeEnum.ES);
            var serviceTechnicaRu = new Translation(159, "SystemParametreValue", 18, "ParametreValue", "Технические потребности", LanguageCodeEnum.RU);
            var serviceTechnicaFr = new Translation(160, "SystemParametreValue", 18, "ParametreValue", "Besoins techniques", LanguageCodeEnum.FR);
            var serviceTechnicaSa = new Translation(161, "SystemParametreValue", 18, "ParametreValue", "الاحتياجات الفنية", LanguageCodeEnum.SA);
            var serviceTechnicaTr = new Translation(162, "SystemParametreValue", 18, "ParametreValue", "Teknik İhtiyaçlar", LanguageCodeEnum.TR);

            var serviceBellBoyUs = new Translation(163, "SystemParametreValue", 19, "ParametreValue", "BellBoy", LanguageCodeEnum.US);
            var serviceBellBoyEs = new Translation(164, "SystemParametreValue", 19, "ParametreValue", "Bellboy", LanguageCodeEnum.ES);
            var serviceBellBoyRu = new Translation(165, "SystemParametreValue", 19, "ParametreValue", "БеллБой", LanguageCodeEnum.RU);
            var serviceBellBoyFr = new Translation(166, "SystemParametreValue", 19, "ParametreValue", "Groom", LanguageCodeEnum.FR);
            var serviceBellBoySa = new Translation(167, "SystemParametreValue", 19, "ParametreValue", "خادم الفندق", LanguageCodeEnum.SA);
            var serviceBellBoyTr = new Translation(168, "SystemParametreValue", 19, "ParametreValue", "Bellboy", LanguageCodeEnum.TR);

            var serviceConnectionUs = new Translation(169, "SystemParametreValue", 20, "ParametreValue", "Wi-Fi", LanguageCodeEnum.US);
            var serviceConnectionEs = new Translation(170, "SystemParametreValue", 20, "ParametreValue", "Wi-Fi", LanguageCodeEnum.ES);
            var serviceConnectionRu = new Translation(171, "SystemParametreValue", 20, "ParametreValue", "Wi-Fi", LanguageCodeEnum.RU);
            var serviceConnectionFr = new Translation(172, "SystemParametreValue", 20, "ParametreValue", "Wi-Fi", LanguageCodeEnum.FR);
            var serviceConnectionSa = new Translation(173, "SystemParametreValue", 20, "ParametreValue", "Wi-Fi", LanguageCodeEnum.SA);
            var serviceConnectionTr = new Translation(174, "SystemParametreValue", 20, "ParametreValue", "Wi-Fi", LanguageCodeEnum.TR);

            var serviceDryCleanerUs = new Translation(175, "SystemParametreValue", 21, "ParametreValue", "Dry Cleaning", LanguageCodeEnum.US);
            var serviceDryCleanerEs = new Translation(176, "SystemParametreValue", 21, "ParametreValue", "Limpieza en seco", LanguageCodeEnum.ES);
            var serviceDryCleanerRu = new Translation(177, "SystemParametreValue", 21, "ParametreValue", "химчистка", LanguageCodeEnum.RU);
            var serviceDryCleanerFr = new Translation(178, "SystemParametreValue", 21, "ParametreValue", "Nettoyage à sec", LanguageCodeEnum.FR);
            var serviceDryCleanerSa = new Translation(179, "SystemParametreValue", 21, "ParametreValue", "التنظيف الجاف", LanguageCodeEnum.SA);
            var serviceDryCleanerTr = new Translation(180, "SystemParametreValue", 21, "ParametreValue", "Kuru Temizleme", LanguageCodeEnum.TR);

            var serviceHouseKeepingUs = new Translation(181, "SystemParametreValue", 22, "ParametreValue", "House Keeping", LanguageCodeEnum.US);
            var serviceHouseKeepingEs = new Translation(182, "SystemParametreValue", 22, "ParametreValue", "House Keeping", LanguageCodeEnum.ES);
            var serviceHouseKeepingRu = new Translation(183, "SystemParametreValue", 22, "ParametreValue", "House Keeping", LanguageCodeEnum.RU);
            var serviceHouseKeepingFr = new Translation(184, "SystemParametreValue", 22, "ParametreValue", "House Keeping", LanguageCodeEnum.FR);
            var serviceHouseKeepingSa = new Translation(185, "SystemParametreValue", 22, "ParametreValue", "الأعمال المنزلية", LanguageCodeEnum.SA);
            var serviceHouseKeepingTr = new Translation(186, "SystemParametreValue", 22, "ParametreValue", "House Keeping", LanguageCodeEnum.TR);

            var serviceSpaMessageUs = new Translation(187, "SystemParametreValue", 23, "ParametreValue", "Spa Message", LanguageCodeEnum.US);
            var serviceSpaMessageEs = new Translation(188, "SystemParametreValue", 23, "ParametreValue", "Spa Message", LanguageCodeEnum.ES);
            var serviceSpaMessageRu = new Translation(189, "SystemParametreValue", 23, "ParametreValue", "Spa Message", LanguageCodeEnum.RU);
            var serviceSpaMessageFr = new Translation(190, "SystemParametreValue", 23, "ParametreValue", "Spa Message", LanguageCodeEnum.FR);
            var serviceSpaMessageSa = new Translation(191, "SystemParametreValue", 23, "ParametreValue", "Spa Message", LanguageCodeEnum.SA);
            var serviceSpaMessageTr = new Translation(192, "SystemParametreValue", 23, "ParametreValue", "Spa Message", LanguageCodeEnum.TR);


            var serviceHealthAndSafetyUs = new Translation(193, "SystemParametreValue", 24, "ParametreValue", "Health and First Aid", LanguageCodeEnum.US);
            var serviceHealthAndSafetyEs = new Translation(194, "SystemParametreValue", 24, "ParametreValue", "Salud y primeros auxilios", LanguageCodeEnum.ES);
            var serviceHealthAndSafetyRu = new Translation(195, "SystemParametreValue", 24, "ParametreValue", "Здоровье и первая помощь", LanguageCodeEnum.RU);
            var serviceHealthAndSafetyFr = new Translation(196, "SystemParametreValue", 24, "ParametreValue", "Santé et premiers secours", LanguageCodeEnum.FR);
            var serviceHealthAndSafetySa = new Translation(197, "SystemParametreValue", 24, "ParametreValue", "الصحة والإسعافات الأولية", LanguageCodeEnum.SA);
            var serviceHealthAndSafetyTr = new Translation(198, "SystemParametreValue", 24, "ParametreValue", "Sağlık ve İlk Yardım", LanguageCodeEnum.TR);


            var serviceTravelOrTransportationUs = new Translation(199, "SystemParametreValue", 25, "ParametreValue", "Travel Or Transportation", LanguageCodeEnum.US);
            var serviceTravelOrTransportationEs = new Translation(200, "SystemParametreValue", 25, "ParametreValue", "Viajes o transporte", LanguageCodeEnum.ES);
            var serviceTravelOrTransportationRu = new Translation(201, "SystemParametreValue", 25, "ParametreValue", "Путешествие или транспорт", LanguageCodeEnum.RU);
            var serviceTravelOrTransportationFr = new Translation(202, "SystemParametreValue", 25, "ParametreValue", "Voyage ou transport", LanguageCodeEnum.FR);
            var serviceTravelOrTransportationSa = new Translation(203, "SystemParametreValue", 25, "ParametreValue", "السفر أو النقل", LanguageCodeEnum.SA);
            var serviceTravelOrTransportationTr = new Translation(204, "SystemParametreValue", 25, "ParametreValue", "Seyahat Veya Ulaşım", LanguageCodeEnum.TR);

            #endregion


            //builder.HasData(data1, data2, data3, data4, data5, data6, orderStatus, orderStatus2, orderStatus3, orderStatus4, orderStatus5, orderStatus6
            //    , orderStatus7, orderStatus8, orderStatus9, orderStatus10, orderStatus11, orderStatus12, orderStatus13, orderStatus14, orderStatus15,
            //    orderStatus16, orderStatus17, orderStatus18
            //    , statusType, statusType2, statusType3, statusTypeEs, statusTypeEs2, statusTypeEs3, statusTypeFr, statusTypeFr2, statusTypeFr3, statusTypeRu
            //    , statusTypeRu2, statusTypeRu3, statusTypeSu, statusTypeSu2, statusTypeSu3, statusTypeTr, statusTypeTr2, statusTypeTr3, typeOfHealthAndSports, typeOfHealthAndSports2,
            //    typeOfHealthAndSports3, typeOfHealthAndSports4, typeOfHealthAndSportsEs, typeOfHealthAndSportsEs2, typeOfHealthAndSportsEs3,
            //    typeOfHealthAndSportsEs4, typeOfHealthAndSportsFr, typeOfHealthAndSportsFr2, typeOfHealthAndSportsFr3, typeOfHealthAndSportsFr4,
            //    typeOfHealthAndSportsRu, typeOfHealthAndSportsRu2, typeOfHealthAndSportsRu3, typeOfHealthAndSportsRu4,
            //    typeOfHealthAndSportsSu, typeOfHealthAndSportsSu2, typeOfHealthAndSportsSu3, typeOfHealthAndSportsSu4,
            //    typeOfHealthAndSportsTr, typeOfHealthAndSportsTr2, typeOfHealthAndSportsTr3, typeOfHealthAndSportsTr4, tecnicalNeedsTvUs, tecnicalNeedsTvUs2,
            //    tecnicalNeedsTvEs, tecnicalNeedsTvEs2, tecnicalNeedsTvRu, tecnicalNeedsTvRu2, tecnicalNeedsTvFr, tecnicalNeedsTvFr2, tecnicalNeedsTvAr,
            //    tecnicalNeedsTvAr2, tecnicalNeedsTvTr, tecnicalNeedsTvTr2, tecnicalNeedsMinibarUs, tecnicalNeedsMinibarUs2, tecnicalNeedsMinibarEs, tecnicalNeedsMinibarEs2,
            //    tecnicalNeedsMinibarRu, tecnicalNeedsMinibarRu2, tecnicalNeedsMinibarFr, tecnicalNeedsMinibarFr2, tecnicalNeedsMinibarAr, tecnicalNeedsMinibarAr2, tecnicalNeedsMinibarTr, tecnicalNeedsMinibarTr2,
            //    tecnicalNeedsDoorUs, tecnicalNeedsDoorUs2, tecnicalNeedsDoorEs, tecnicalNeedsDoorEs2, tecnicalNeedsDoorRu, tecnicalNeedsDoorRu2, tecnicalNeedsDoorFr, tecnicalNeedsDoorFr2,
            //    tecnicalNeedsDoorAr, tecnicalNeedsDoorAr, tecnicalNeedsDoorTr, tecnicalNeedsDoorTr2, tecnicalNeedsElektrikUs, tecnicalNeedsElektrikUs2, tecnicalNeedsElektrikEs, tecnicalNeedsElektrikEs2
            //    , tecnicalNeedsElektrikRu, tecnicalNeedsElektrikRu2, tecnicalNeedsElektrikFr, tecnicalNeedsElektrikFr2, tecnicalNeedsElektrikAr, tecnicalNeedsElektrikAr2, tecnicalNeedsElektrikTr,
            //    tecnicalNeedsElektrikTr2, tecnicalNeedsAydınlatmaUs, tecnicalNeedsAydınlatmaUs2, tecnicalNeedsAydınlatmaEs, tecnicalNeedsAydınlatmaEs2, tecnicalNeedsAydınlatmaRu, tecnicalNeedsAydınlatmaRu2,
            //    tecnicalNeedsAydınlatmaFr, tecnicalNeedsAydınlatmaFr2, tecnicalNeedsAydınlatmaAr, tecnicalNeedsAydınlatmaAr2, tecnicalNeedsAydınlatmaTr, tecnicalNeedsAydınlatmaTr2,
            //    tecnicalNeedsDusUs, tecnicalNeedsDusUs2, tecnicalNeedsDusEs, tecnicalNeedsDusEs2, tecnicalNeedsDusRu, tecnicalNeedsDusRu2, tecnicalNeedsDusFr, tecnicalNeedDusFr2,
            //    tecnicalNeedsDusAr, tecnicalNeedsDusAr2, tecnicalNeedsDusTr, tecnicalNeedsDusTr2, serviceMenuUs, serviceMenuEs, serviceMenuRu, serviceMenuFr, serviceMenuSa, serviceMenuTr,
            //    serviceTechnicalUs, serviceTechnicaEs, serviceTechnicaRu, serviceTechnicaFr, serviceTechnicaSa, serviceTechnicaTr, serviceBellBoyUs, serviceBellBoyEs, serviceBellBoyRu,
            //    serviceBellBoyFr, serviceBellBoySa, serviceBellBoyTr, serviceConnectionUs, serviceConnectionEs, serviceConnectionFr, serviceConnectionSa, serviceConnectionTr, serviceConnectionRu,
            //    serviceDryCleanerUs, serviceDryCleanerEs, serviceDryCleanerRu, serviceDryCleanerFr, serviceDryCleanerSa, serviceDryCleanerTr, serviceHouseKeepingUs, serviceHouseKeepingEs,
            //    serviceHouseKeepingRu, serviceHouseKeepingFr, serviceHouseKeepingSa, serviceHouseKeepingTr, serviceSpaMessageUs, serviceSpaMessageEs, serviceSpaMessageFr, serviceSpaMessageRu,
            //    serviceSpaMessageSa, serviceSpaMessageTr, serviceHealthAndSafetyUs, serviceHealthAndSafetyEs, serviceHealthAndSafetyRu, serviceHealthAndSafetyFr, serviceHealthAndSafetySa
            //    , serviceHealthAndSafetyTr, serviceTravelOrTransportationUs, serviceTravelOrTransportationEs, serviceTravelOrTransportationFr, serviceTravelOrTransportationRu, serviceTravelOrTransportationSa
            //    , serviceTravelOrTransportationTr);

            builder.HasData(
    data1, data2, data3, data4, data5, data6,
    orderStatus, orderStatus2, orderStatus3, orderStatus4, orderStatus5, orderStatus6,
    orderStatus7, orderStatus8, orderStatus9, orderStatus10, orderStatus11, orderStatus12, orderStatus13,
    orderStatus14, orderStatus15, orderStatus16, orderStatus17, orderStatus18,
    tecnicalNeedsUs, tecnicalNeedsUs2, tecnicalNeedsEs, tecnicalNeedsEs2, tecnicalNeedsRu, tecnicalNeedsRu2,
    tecnicalNeedsFr, tecnicalNeedsFr2, tecnicalNeedsAr, tecnicalNeedsAr2, tecnicalNeedsTr, tecnicalNeedsTr2,
    tecnicalNeedsTvUs, tecnicalNeedsTvUs2, tecnicalNeedsTvEs, tecnicalNeedsTvEs2, tecnicalNeedsTvRu,
    tecnicalNeedsTvRu2, tecnicalNeedsTvFr, tecnicalNeedsTvFr2, tecnicalNeedsTvAr, tecnicalNeedsTvAr2,
    tecnicalNeedsTvTr, tecnicalNeedsTvTr2, tecnicalNeedsMinibarUs, tecnicalNeedsMinibarUs2, tecnicalNeedsMinibarEs,
    tecnicalNeedsMinibarEs2, tecnicalNeedsMinibarRu, tecnicalNeedsMinibarRu2, tecnicalNeedsMinibarFr,
    tecnicalNeedsMinibarFr2, tecnicalNeedsMinibarAr, tecnicalNeedsMinibarAr2, tecnicalNeedsMinibarTr, tecnicalNeedsMinibarTr2,
    tecnicalNeedsDoorUs, tecnicalNeedsDoorUs2, tecnicalNeedsDoorEs, tecnicalNeedsDoorEs2, tecnicalNeedsDoorRu,
    tecnicalNeedsDoorRu2, tecnicalNeedsDoorFr, tecnicalNeedsDoorFr2, tecnicalNeedsDoorAr, tecnicalNeedsDoorAr2,
    tecnicalNeedsDoorTr, tecnicalNeedsDoorTr2, tecnicalNeedsElektrikUs, tecnicalNeedsElektrikUs2, tecnicalNeedsElektrikEs,
    tecnicalNeedsElektrikEs2, tecnicalNeedsElektrikRu, tecnicalNeedsElektrikRu2, tecnicalNeedsElektrikFr,
    tecnicalNeedsElektrikFr2, tecnicalNeedsElektrikAr, tecnicalNeedsElektrikAr2, tecnicalNeedsElektrikTr, tecnicalNeedsElektrikTr2,
    tecnicalNeedsAydınlatmaUs, tecnicalNeedsAydınlatmaUs2, tecnicalNeedsAydınlatmaEs, tecnicalNeedsAydınlatmaEs2,
    tecnicalNeedsAydınlatmaRu, tecnicalNeedsAydınlatmaRu2, tecnicalNeedsAydınlatmaFr, tecnicalNeedsAydınlatmaFr2,
    tecnicalNeedsAydınlatmaAr, tecnicalNeedsAydınlatmaAr2, tecnicalNeedsAydınlatmaTr, tecnicalNeedsAydınlatmaTr2,
    tecnicalNeedsDusUs, tecnicalNeedsDusUs2, tecnicalNeedsDusEs, tecnicalNeedsDusEs2, tecnicalNeedsDusRu, tecnicalNeedsDusRu2,
    tecnicalNeedsDusFr, tecnicalNeedDusFr2, tecnicalNeedsDusAr, tecnicalNeedsDusAr2, tecnicalNeedsDusTr, tecnicalNeedsDusTr2,
    statusType, statusType2, statusType3, statusTypeEs, statusTypeEs2, statusTypeEs3, statusTypeFr, statusTypeFr2,
    statusTypeFr3, statusTypeRu, statusTypeRu2, statusTypeRu3, statusTypeSu, statusTypeSu2, statusTypeSu3,
    statusTypeTr, statusTypeTr2, statusTypeTr3, typeOfHealthAndSports, typeOfHealthAndSports2, typeOfHealthAndSports3,
    typeOfHealthAndSports4, typeOfHealthAndSportsEs, typeOfHealthAndSportsEs2, typeOfHealthAndSportsEs3,
    typeOfHealthAndSportsEs4, typeOfHealthAndSportsFr, typeOfHealthAndSportsFr2, typeOfHealthAndSportsFr3,
    typeOfHealthAndSportsFr4, typeOfHealthAndSportsRu, typeOfHealthAndSportsRu2, typeOfHealthAndSportsRu3,
    typeOfHealthAndSportsRu4, typeOfHealthAndSportsSu, typeOfHealthAndSportsSu2, typeOfHealthAndSportsSu3,
    typeOfHealthAndSportsSu4, typeOfHealthAndSportsTr, typeOfHealthAndSportsTr2, typeOfHealthAndSportsTr3,
    typeOfHealthAndSportsTr4, serviceMenuUs, serviceMenuEs, serviceMenuRu, serviceMenuFr, serviceMenuSa,
    serviceMenuTr, serviceTechnicalUs, serviceTechnicaEs, serviceTechnicaRu, serviceTechnicaFr, serviceTechnicaSa,
    serviceTechnicaTr, serviceBellBoyUs, serviceBellBoyEs, serviceBellBoyRu, serviceBellBoyFr, serviceBellBoySa,
    serviceBellBoyTr, serviceConnectionUs, serviceConnectionEs, serviceConnectionFr, serviceConnectionSa,
    serviceConnectionTr, serviceConnectionRu, serviceDryCleanerUs, serviceDryCleanerEs, serviceDryCleanerRu,
    serviceDryCleanerFr, serviceDryCleanerSa, serviceDryCleanerTr, serviceHouseKeepingUs, serviceHouseKeepingEs,
    serviceHouseKeepingRu, serviceHouseKeepingFr, serviceHouseKeepingSa, serviceHouseKeepingTr, serviceSpaMessageUs,
    serviceSpaMessageEs, serviceSpaMessageFr, serviceSpaMessageRu, serviceSpaMessageSa, serviceSpaMessageTr,
    serviceHealthAndSafetyUs, serviceHealthAndSafetyEs, serviceHealthAndSafetyRu, serviceHealthAndSafetyFr,
    serviceHealthAndSafetySa, serviceHealthAndSafetyTr, serviceTravelOrTransportationUs, serviceTravelOrTransportationEs,
    serviceTravelOrTransportationFr, serviceTravelOrTransportationRu, serviceTravelOrTransportationSa,
    serviceTravelOrTransportationTr
);

        }
    }
}
