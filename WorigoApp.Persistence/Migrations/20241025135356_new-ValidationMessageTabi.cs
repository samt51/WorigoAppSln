using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newValidationMessageTabi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "SystemParameter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParametreKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemParameter", x => x.Id);
                });


            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordId = table.Column<int>(type: "int", nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TranslationValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.Id);
                });


            migrationBuilder.CreateTable(
                name: "ValidationMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValidationMessageType = table.Column<int>(type: "int", nullable: false),
                    ValidationMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidationMessages", x => x.Id);
                });



            migrationBuilder.CreateTable(
                name: "SystemParametreValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemParametreId = table.Column<int>(type: "int", nullable: false),
                    ParametreValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SystemParametreValueId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemParametreValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemParametreValues_SystemParameter_SystemParametreId",
                        column: x => x.SystemParametreId,
                        principalTable: "SystemParameter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });



            migrationBuilder.InsertData(
                table: "SystemParameter",
                columns: new[] { "Id", "IsDeleted", "ParametreKey" },
                values: new object[,]
                {
                    { 1, false, "PriceStatus" },
                    { 2, false, "OrderStatus" },
                    { 3, false, "RoomFoodTypeStatus" },
                    { 4, false, "RoomTypeStatus" },
                    { 5, false, "ServicesStatus" },
                    { 6, false, "StatusType" },
                    { 7, false, "TypesOfHealthAndSports" }
                });


            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedDate", "FieldName", "IsActive", "IsDeleted", "LanguageCode", "ModifyDate", "RecordId", "TableName", "TranslationValue" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9753), "UnknownError", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9756), 0, "", "İşlem yaparken bir sorun oluştu. Lütfen tekrar deneyiniz." },
                    { 2, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9759), "UnknownError", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9759), 0, "", "There was a problem while processing the transaction. Please try again." },
                    { 3, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9760), "UnknownError", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9760), 0, "", "Во время обработки возникла проблема. Пожалуйста, попробуйте еще раз." },
                    { 4, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9761), "UnknownError", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9761), 0, "", "Un problème est survenu lors du traitement. Veuillez réessayer." },
                    { 5, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9762), "UnknownError", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9763), 0, "", "Hubo un problema durante el procesamiento. Por favor inténtalo de nuevo." },
                    { 6, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9763), "UnknownError", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9764), 0, "", "حدثت مشكلة أثناء المعالجة. يرجى المحاولة مرة أخرى." },
                    { 7, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9764), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9765), 5, "SystemParametreValue", "Hazırlanıyor" },
                    { 8, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9765), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9766), 6, "SystemParametreValue", "Geliyor" },
                    { 9, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9766), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9767), 7, "SystemParametreValue", "İptal Edildi" },
                    { 10, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9767), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9768), 5, "SystemParametreValue", "Preparing" },
                    { 11, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9768), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9769), 6, "SystemParametreValue", "IsComing" },
                    { 12, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9769), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9770), 7, "SystemParametreValue", "Delivered" },
                    { 13, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9770), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9771), 5, "SystemParametreValue", "Preparándose" },
                    { 14, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9771), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9771), 6, "SystemParametreValue", "A punto de venir" },
                    { 15, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9772), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9772), 7, "SystemParametreValue", "Entregado" },
                    { 16, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9773), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9773), 5, "SystemParametreValue", "Se préparer" },
                    { 17, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9774), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9774), 6, "SystemParametreValue", "Sur le point de venir." },
                    { 18, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9775), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9775), 7, "SystemParametreValue", "A été livré." },
                    { 19, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9776), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9776), 5, "SystemParametreValue", "готовлюсь." },
                    { 20, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9777), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9777), 6, "SystemParametreValue", "Скоро придет" },
                    { 21, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9778), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9778), 7, "SystemParametreValue", "Доставленный." },
                    { 22, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9779), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9779), 5, "SystemParametreValue", "الاستعداد" },
                    { 23, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9780), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9780), 6, "SystemParametreValue", "على وشك المجيء" },
                    { 24, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9781), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9781), 7, "SystemParametreValue", "تم التوصيل" },
                    { 25, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9782), "Name", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9782), 1, "TechnicalNeed", "Air conditioning" },
                    { 26, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9784), "Description", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9784), 1, "TechnicalNeed", "Malfunction situations with air conditioning" },
                    { 27, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9785), "Name", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9785), 1, "TechnicalNeed", "Aire acondicionado" },
                    { 28, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9786), "Description", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9786), 1, "TechnicalNeed", "Situaciones de avería con el aire acondicionado." },
                    { 29, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9787), "Name", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9787), 1, "TechnicalNeed", "Кондиционер" },
                    { 30, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9787), "Description", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9788), 1, "TechnicalNeed", "Ситуации неисправности кондиционера" },
                    { 31, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9788), "Name", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9789), 1, "TechnicalNeed", "Climatisation" },
                    { 32, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9789), "Description", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9790), 1, "TechnicalNeed", "Situations de dysfonctionnement de la climatisation" },
                    { 33, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9790), "Name", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9791), 1, "TechnicalNeed", "تكييف" },
                    { 34, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9791), "Description", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9792), 1, "TechnicalNeed", "حالات الأعطال بالتكييف" },
                    { 35, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9792), "Name", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9792), 1, "TechnicalNeed", "Klima" },
                    { 36, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9793), "Description", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9793), 1, "TechnicalNeed", "Klima ile arıza durumları" },
                    { 37, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9794), "Name", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9794), 2, "TechnicalNeed", "TV" },
                    { 38, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9795), "Description", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9795), 2, "TechnicalNeed", "Malfunction situations with TV" },
                    { 39, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9796), "Name", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9796), 2, "TechnicalNeed", "TELEVISOR" },
                    { 40, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9797), "Description", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9797), 2, "TechnicalNeed", "Situaciones de mal funcionamiento con TV." },
                    { 41, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9798), "Name", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9798), 2, "TechnicalNeed", "ТВ" },
                    { 42, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9799), "Description", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9799), 2, "TechnicalNeed", "Неисправные ситуации с телевизором" },
                    { 43, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9800), "Name", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9800), 2, "TechnicalNeed", "TV" },
                    { 44, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9801), "Description", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9801), 2, "TechnicalNeed", "Situations de dysfonctionnement avec la télévision" },
                    { 45, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9801), "Name", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9802), 2, "TechnicalNeed", "تلفزيون" },
                    { 46, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9802), "Description", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9803), 2, "TechnicalNeed", "حالات الأعطال بالتلفاز" },
                    { 47, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9803), "Name", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9804), 2, "TechnicalNeed", "TV" },
                    { 48, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9804), "Description", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9805), 2, "TechnicalNeed", "TV ile arıza durumları" },
                    { 49, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9805), "Name", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9806), 3, "TechnicalNeed", "Mini-bar" },
                    { 50, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9806), "Description", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9806), 3, "TechnicalNeed", "Malfunction situations with minibar" },
                    { 51, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9807), "Name", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9807), 3, "TechnicalNeed", "Mini-bar" },
                    { 52, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9809), "Description", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9809), 3, "TechnicalNeed", "Situaciones de avería con el minibar" },
                    { 53, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9810), "Name", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9810), 3, "TechnicalNeed", "мини-бар" },
                    { 54, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9811), "Description", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9811), 3, "TechnicalNeed", "Ситуации неисправности мини-бара" },
                    { 55, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9812), "Name", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9812), 3, "TechnicalNeed", "Mini-bar" },
                    { 56, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9813), "Description", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9813), 3, "TechnicalNeed", "Situations de dysfonctionnement du minibar" },
                    { 57, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9814), "Name", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9814), 3, "TechnicalNeed", "ميني بار" },
                    { 58, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9815), "Description", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9815), 3, "TechnicalNeed", "حالات الأعطال بالميني بار" },
                    { 59, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9816), "Name", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9816), 3, "TechnicalNeed", "Minibar" },
                    { 60, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9816), "Description", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9817), 3, "TechnicalNeed", "Minibar ile arıza durumları" },
                    { 61, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9817), "Name", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9818), 4, "TechnicalNeed", "Door" },
                    { 62, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9818), "Description", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9819), 4, "TechnicalNeed", "Fault situations with door" },
                    { 63, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9819), "Name", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9820), 4, "TechnicalNeed", "Puerta" },
                    { 64, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9820), "Description", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9821), 4, "TechnicalNeed", "Situaciones de avería con el puerta" },
                    { 65, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9821), "Name", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9822), 4, "TechnicalNeed", "Дверь" },
                    { 66, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9822), "Description", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9822), 4, "TechnicalNeed", "Неисправные ситуации с дверью" },
                    { 67, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9823), "Name", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9824), 4, "TechnicalNeed", "Porte" },
                    { 68, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9824), "Description", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9824), 4, "TechnicalNeed", "Situations de défauts avec la porte" },
                    { 69, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9825), "Name", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9825), 4, "TechnicalNeed", "باب" },
                    { 70, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9826), "Description", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9826), 4, "TechnicalNeed", "حالات خطأ مع الباب" },
                    { 71, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9827), "Name", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9827), 4, "TechnicalNeed", "Kapı" },
                    { 72, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9828), "Description", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9828), 4, "TechnicalNeed", "Kapı ile arıza durumları" },
                    { 73, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9829), "Name", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9829), 5, "TechnicalNeed", "Electric" },
                    { 74, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9830), "Description", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9830), 5, "TechnicalNeed", "Electrical fault situations" },
                    { 75, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9831), "Name", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9831), 5, "TechnicalNeed", "Eléctrico" },
                    { 76, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9831), "Description", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9832), 5, "TechnicalNeed", "Situaciones de falla eléctrica" },
                    { 77, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9833), "Name", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9833), 5, "TechnicalNeed", "Электрический" },
                    { 78, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9833), "Description", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9834), 5, "TechnicalNeed", "Ситуации электрических неисправностей" },
                    { 79, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9835), "Name", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9836), 5, "TechnicalNeed", "Électrique" },
                    { 80, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9836), "Description", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9837), 5, "TechnicalNeed", "Situations de panne électrique" },
                    { 81, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9837), "Name", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9838), 5, "TechnicalNeed", "كهربائي" },
                    { 82, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9838), "Description", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9839), 5, "TechnicalNeed", "حالات الأعطال الكهربائية" },
                    { 83, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9839), "Name", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9839), 5, "TechnicalNeed", "Elektrik" },
                    { 84, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9840), "Description", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9840), 5, "TechnicalNeed", "Elektrik ile arıza durumları" },
                    { 85, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9841), "Name", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9841), 6, "TechnicalNeed", "Lighting" },
                    { 86, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9842), "Description", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9842), 6, "TechnicalNeed", "Malfunction situations with lighting" },
                    { 87, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9843), "Name", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9843), 6, "TechnicalNeed", "Iluminación" },
                    { 88, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9844), "Description", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9844), 6, "TechnicalNeed", "Situaciones de mal funcionamiento con la iluminación." },
                    { 89, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9845), "Name", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9845), 6, "TechnicalNeed", "Освещение" },
                    { 90, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9846), "Description", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9846), 6, "TechnicalNeed", "Ситуации неисправности с освещением" },
                    { 91, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9846), "Name", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9847), 6, "TechnicalNeed", "Éclairage" },
                    { 92, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9848), "Description", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9848), 6, "TechnicalNeed", "Situations de dysfonctionnement de l'éclairage" },
                    { 93, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9848), "Name", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9849), 6, "TechnicalNeed", "إضاءة" },
                    { 94, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9849), "Description", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9850), 6, "TechnicalNeed", "حالات الأعطال بالإضاءة" },
                    { 95, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9850), "Name", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9851), 6, "TechnicalNeed", "Aydınlatma" },
                    { 96, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9851), "Description", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9852), 6, "TechnicalNeed", "Aydınlatma ile arıza durumları" },
                    { 97, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9881), "Name", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9882), 7, "TechnicalNeed", "Shower and Toilet" },
                    { 98, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9883), "Description", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9883), 7, "TechnicalNeed", "Malfunction situations with shower and toilet" },
                    { 99, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9884), "Name", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9884), 7, "TechnicalNeed", "Ducha y WC" },
                    { 100, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9885), "Description", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9885), 7, "TechnicalNeed", "Situaciones de avería en ducha y WC" },
                    { 101, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9886), "Name", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9886), 7, "TechnicalNeed", "Душ и туалет" },
                    { 102, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9886), "Description", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9887), 7, "TechnicalNeed", "Ситуации неисправности с душем и туалетом" },
                    { 103, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9887), "Name", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9888), 7, "TechnicalNeed", "Douche et WC" },
                    { 104, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9888), "Description", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9889), 7, "TechnicalNeed", "Situations de dysfonctionnement avec douche et toilettes" },
                    { 105, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9889), "Name", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9890), 7, "TechnicalNeed", "دش ومرحاض" },
                    { 106, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9891), "Description", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9892), 7, "TechnicalNeed", "حالات خلل في الدش والمرحاض" },
                    { 107, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9892), "Name", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9893), 7, "TechnicalNeed", "Duş ve Tuvalet" },
                    { 108, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9893), "Description", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9893), 7, "TechnicalNeed", "Duş ve Tuvalet ile arıza durumları" },
                    { 109, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9894), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9894), 26, "SystemParametreValue", "In Proccess" },
                    { 110, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9895), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9895), 27, "SystemParametreValue", "Completed" },
                    { 111, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9896), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9896), 28, "SystemParametreValue", "Waiting" },
                    { 112, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9897), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9897), 26, "SystemParametreValue", "En proceso" },
                    { 113, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9898), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9898), 27, "SystemParametreValue", "Terminado" },
                    { 114, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9899), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9899), 28, "SystemParametreValue", "Espera" },
                    { 115, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9900), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9900), 26, "SystemParametreValue", "в процессе" },
                    { 116, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9901), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9901), 27, "SystemParametreValue", "завершенный" },
                    { 117, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9902), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9902), 28, "SystemParametreValue", "ожидающий" },
                    { 118, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9903), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9903), 26, "SystemParametreValue", "En Cours" },
                    { 119, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9904), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9904), 27, "SystemParametreValue", "Complété" },
                    { 120, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9904), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9905), 28, "SystemParametreValue", "En Attendant" },
                    { 121, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9905), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9906), 26, "SystemParametreValue", "قيد المعالجة" },
                    { 122, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9906), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9907), 27, "SystemParametreValue", "مكتمل" },
                    { 123, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9907), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9908), 28, "SystemParametreValue", "منتظر" },
                    { 124, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9908), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9909), 26, "SystemParametreValue", "İşlemde" },
                    { 125, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9909), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9909), 27, "SystemParametreValue", "Tamamlandı" },
                    { 126, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9910), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9910), 28, "SystemParametreValue", "Bekleniyor" },
                    { 127, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9911), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9911), 29, "SystemParametreValue", "Spa" },
                    { 128, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9912), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9912), 30, "SystemParametreValue", "Massage" },
                    { 129, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9913), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9913), 31, "SystemParametreValue", "Fitness" },
                    { 130, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9914), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9914), 32, "SystemParametreValue", "Poor" },
                    { 131, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9915), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9915), 29, "SystemParametreValue", "Spa" },
                    { 132, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9916), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9916), 30, "SystemParametreValue", "Masaje" },
                    { 133, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9917), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9918), 31, "SystemParametreValue", "Aptitud fisica" },
                    { 134, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9918), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9919), 32, "SystemParametreValue", "Piscina" },
                    { 135, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9919), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9920), 29, "SystemParametreValue", "Спа" },
                    { 136, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9920), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9921), 30, "SystemParametreValue", "Массаж" },
                    { 137, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9921), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9922), 31, "SystemParametreValue", "Фитнес" },
                    { 138, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9922), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9923), 32, "SystemParametreValue", "Бассейн" },
                    { 139, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9923), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9923), 29, "SystemParametreValue", "سبا" },
                    { 140, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9924), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9924), 30, "SystemParametreValue", "تدليك" },
                    { 141, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9925), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9925), 31, "SystemParametreValue", "لياقة بدنية" },
                    { 142, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9926), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9926), 32, "SystemParametreValue", "حمام السباحة" },
                    { 143, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9927), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9927), 29, "SystemParametreValue", "Spa" },
                    { 144, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9928), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9928), 30, "SystemParametreValue", "massage" },
                    { 145, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9929), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9929), 31, "SystemParametreValue", "Aptitude" },
                    { 146, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9930), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9930), 32, "SystemParametreValue", "Piscine" },
                    { 147, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9930), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9931), 29, "SystemParametreValue", "Spa" },
                    { 148, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9931), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9932), 30, "SystemParametreValue", "Masaj" },
                    { 149, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9932), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9933), 31, "SystemParametreValue", "Fitness" },
                    { 150, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9933), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9934), 32, "SystemParametreValue", "Havuz" },
                    { 151, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9934), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9935), 17, "SystemParametreValue", "Menu" },
                    { 152, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9935), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9935), 17, "SystemParametreValue", "Menú" },
                    { 153, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9936), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9936), 17, "SystemParametreValue", "Меню" },
                    { 154, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9937), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9937), 17, "SystemParametreValue", "Menu" },
                    { 155, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9938), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9938), 17, "SystemParametreValue", "قائمة طعام" },
                    { 156, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9939), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9939), 17, "SystemParametreValue", "Menü" },
                    { 157, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9940), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9940), 18, "SystemParametreValue", "Technical Needs" },
                    { 158, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9941), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9941), 18, "SystemParametreValue", "Necesidades técnicas" },
                    { 159, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9942), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9942), 18, "SystemParametreValue", "Технические потребности" },
                    { 160, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9944), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9944), 18, "SystemParametreValue", "Besoins techniques" },
                    { 161, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9945), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9945), 18, "SystemParametreValue", "الاحتياجات الفنية" },
                    { 162, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9945), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9946), 18, "SystemParametreValue", "Teknik İhtiyaçlar" },
                    { 163, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9946), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9947), 19, "SystemParametreValue", "BellBoy" },
                    { 164, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9947), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9948), 19, "SystemParametreValue", "Bellboy" },
                    { 165, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9948), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9949), 19, "SystemParametreValue", "БеллБой" },
                    { 166, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9949), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9950), 19, "SystemParametreValue", "Groom" },
                    { 167, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9950), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9951), 19, "SystemParametreValue", "خادم الفندق" },
                    { 168, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9951), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9951), 19, "SystemParametreValue", "Bellboy" },
                    { 169, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9952), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9952), 20, "SystemParametreValue", "Wi-Fi" },
                    { 170, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9953), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9953), 20, "SystemParametreValue", "Wi-Fi" },
                    { 171, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9954), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9954), 20, "SystemParametreValue", "Wi-Fi" },
                    { 172, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9955), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9955), 20, "SystemParametreValue", "Wi-Fi" },
                    { 173, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9956), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9956), 20, "SystemParametreValue", "Wi-Fi" },
                    { 174, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9957), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9957), 20, "SystemParametreValue", "Wi-Fi" },
                    { 175, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9957), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9958), 21, "SystemParametreValue", "Dry Cleaning" },
                    { 176, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9958), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9959), 21, "SystemParametreValue", "Limpieza en seco" },
                    { 177, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9959), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9960), 21, "SystemParametreValue", "химчистка" },
                    { 178, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9960), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9960), 21, "SystemParametreValue", "Nettoyage à sec" },
                    { 179, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9961), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9961), 21, "SystemParametreValue", "التنظيف الجاف" },
                    { 180, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9962), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9962), 21, "SystemParametreValue", "Kuru Temizleme" },
                    { 181, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9963), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9963), 22, "SystemParametreValue", "House Keeping" },
                    { 182, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9964), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9964), 22, "SystemParametreValue", "House Keeping" },
                    { 183, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9965), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9965), 22, "SystemParametreValue", "House Keeping" },
                    { 184, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9966), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9966), 22, "SystemParametreValue", "House Keeping" },
                    { 185, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9967), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9967), 22, "SystemParametreValue", "الأعمال المنزلية" },
                    { 186, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9967), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9968), 22, "SystemParametreValue", "House Keeping" },
                    { 187, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9969), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9970), 23, "SystemParametreValue", "Spa Message" },
                    { 188, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9970), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9971), 23, "SystemParametreValue", "Spa Message" },
                    { 189, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9971), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9972), 23, "SystemParametreValue", "Spa Message" },
                    { 190, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9972), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9972), 23, "SystemParametreValue", "Spa Message" },
                    { 191, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9973), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9973), 23, "SystemParametreValue", "Spa Message" },
                    { 192, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9974), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9974), 23, "SystemParametreValue", "Spa Message" },
                    { 193, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9975), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9975), 24, "SystemParametreValue", "Health and First Aid" },
                    { 194, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9976), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9976), 24, "SystemParametreValue", "Salud y primeros auxilios" },
                    { 195, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9977), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9977), 24, "SystemParametreValue", "Здоровье и первая помощь" },
                    { 196, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9978), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9978), 24, "SystemParametreValue", "Santé et premiers secours" },
                    { 197, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9979), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9979), 24, "SystemParametreValue", "الصحة والإسعافات الأولية" },
                    { 198, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9979), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9980), 24, "SystemParametreValue", "Sağlık ve İlk Yardım" },
                    { 199, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9989), "ParametreValue", true, false, "en-US", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9989), 25, "SystemParametreValue", "Travel Or Transportation" },
                    { 200, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9990), "ParametreValue", true, false, "es-ES", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9990), 25, "SystemParametreValue", "Viajes o transporte" },
                    { 201, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9990), "ParametreValue", true, false, "ru-RU", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9991), 25, "SystemParametreValue", "Путешествие или транспорт" },
                    { 202, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9991), "ParametreValue", true, false, "fr-FR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9992), 25, "SystemParametreValue", "Voyage ou transport" },
                    { 203, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9992), "ParametreValue", true, false, "ar-SA", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9993), 25, "SystemParametreValue", "السفر أو النقل" },
                    { 204, new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9993), "ParametreValue", true, false, "tr-TR", new DateTime(2024, 10, 25, 16, 53, 55, 618, DateTimeKind.Local).AddTicks(9994), 25, "SystemParametreValue", "Seyahat Veya Ulaşım" }
                });

            migrationBuilder.InsertData(
                table: "ValidationMessages",
                columns: new[] { "Id", "IsDeleted", "LanguageCode", "ValidationMessage", "ValidationMessageType" },
                values: new object[,]
                {
                    { 1, false, "tr-TR", "{0} alanı boş olamaz.", 1 },
                    { 2, false, "en-US", "{0} field cannot be empty.", 1 },
                    { 3, false, "es-ES", "{0} el campo no puede estar vacío", 1 },
                    { 4, false, "fr-FR", "{0} le champ ne peut pas être vide.", 1 },
                    { 5, false, "ru-RU", "{0} поле не может быть пустым", 1 },
                    { 6, false, "ar-SA", "{0} لا يمكن أن يكون الحقل فارغًا", 1 },
                    { 7, false, "tr-TR", "Geçerli bir email adresi giriniz.", 4 },
                    { 8, false, "en-US", "Please enter a valid email address.", 4 },
                    { 9, false, "es-ES", "Por favor, introduce una dirección de correo electrónico válida.", 4 },
                    { 10, false, "fr-FR", "S'il vous plaît, mettez une adresse email valide", 4 },
                    { 11, false, "ru-RU", "Пожалуйста, введите действительный адрес электронной почты", 4 },
                    { 12, false, "ar-SA", "يرجى إدخال عنوان بريد إلكتروني صالح", 4 }
                });


            migrationBuilder.InsertData(
                table: "SystemParametreValues",
                columns: new[] { "Id", "Description", "IsDeleted", "ParametreValue", "SystemParametreId", "SystemParametreValueId" },
                values: new object[,]
                {
                    { 1, "Türk Lirası", false, "₺", 1, 1 },
                    { 2, "Dolar", false, "$", 1, 2 },
                    { 3, "Euro", false, "€", 1, 3 },
                    { 5, "", false, "Preparing", 2, 1 },
                    { 6, "", false, "IsComing", 2, 2 },
                    { 7, "", false, "Delivered", 2, 3 },
                    { 8, "", false, "Breakfast", 3, 1 },
                    { 9, "", false, "HalfPension", 3, 2 },
                    { 10, "", false, "FullPension", 3, 3 },
                    { 11, "", false, "AllInclusive", 3, 4 },
                    { 12, "", false, "UltraAllInclusive", 3, 5 },
                    { 13, "", false, "Standart", 4, 1 },
                    { 14, "", false, "SingleRoom", 4, 2 },
                    { 15, "", false, "DoubleRoom", 4, 3 },
                    { 16, "", false, "SuitRoom", 4, 4 },
                    { 17, "", false, "Menu", 5, 1 },
                    { 18, "", false, "TechnicalNeed", 5, 2 },
                    { 19, "", false, "BellBoy", 5, 3 },
                    { 20, "", false, "Connection", 5, 4 },
                    { 21, "", false, "DryCleaner", 5, 5 },
                    { 22, "", false, "HouseKeeping", 5, 6 },
                    { 23, "", false, "SpaMessage", 5, 7 },
                    { 24, "", false, "HealthAndSafety", 5, 8 },
                    { 25, "", false, "TravelOrTransportation", 5, 9 },
                    { 26, "", false, "Proccess", 6, 2 },
                    { 27, "", false, "Completed", 6, 3 },
                    { 28, "", false, "Waiting", 6, 1 },
                    { 29, "", false, "Spa", 7, 1 },
                    { 30, "", false, "Massage", 7, 2 },
                    { 31, "", false, "Fitness", 7, 3 },
                    { 32, "", false, "Poor", 7, 4 }
                });


            migrationBuilder.CreateIndex(
                name: "IX_SystemParametreValues_SystemParametreId",
                table: "SystemParametreValues",
                column: "SystemParametreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemParametreValues");



            migrationBuilder.DropTable(
                name: "Translations");



            migrationBuilder.DropTable(
                name: "SystemParameter");


        }
    }
}
