using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allergen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmenityRequestServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    SupportsFreeText = table.Column<bool>(type: "bit", nullable: false),
                    IsChargeable = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceStatusId = table.Column<int>(type: "int", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedDurationMinutes = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmenityRequestServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BellBoy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    EstimatedDurationMinutes = table.Column<int>(type: "int", nullable: true),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BellBoy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Connection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlootNo = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContentsOfFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentsOfFood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DietaryRestriction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietaryRestriction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DryCleaner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PriceStatusId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    IsChargeable = table.Column<bool>(type: "bit", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedDurationMinutes = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DryCleaner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeedBackAndSurveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    FeedBack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBackAndSurveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomFoodTypeEnum = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealthAndSafety",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestStayId = table.Column<int>(type: "int", nullable: false),
                    HealthAndFirstHelpTypeEnum = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthAndSafety", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelInformationAndAnnouncements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    AnnouncementType = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPinned = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelInformationAndAnnouncements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseKeeping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    SupportsFreeText = table.Column<bool>(type: "bit", nullable: false),
                    EstimatedDurationMinutes = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseKeeping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageTemplate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogEvent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalAssistanceServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    SupportsFreeText = table.Column<bool>(type: "bit", nullable: false),
                    IsChargeable = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceStatusId = table.Column<int>(type: "int", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiresAppointment = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalAssistanceServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MinibarServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceStatusId = table.Column<int>(type: "int", nullable: false),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    IsChargeable = table.Column<bool>(type: "bit", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedDurationMinutes = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinibarServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomTypeEnum = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRoleAssignment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesEnumId = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    EmployeeTypeRoleId = table.Column<int>(type: "int", nullable: false),
                    IsPrimaryAssignment = table.Column<bool>(type: "bit", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    SlaMinutes = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRoleAssignment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpaMassage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    TypesOfHealthAndSports = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceStatusId = table.Column<int>(type: "int", nullable: false),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    IsChargeable = table.Column<bool>(type: "bit", nullable: false),
                    RequiresAppointment = table.Column<bool>(type: "bit", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedDurationMinutes = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpaMassage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StayExtensionServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceStatusId = table.Column<int>(type: "int", nullable: false),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    IsChargeable = table.Column<bool>(type: "bit", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiresAppointment = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StayExtensionServices", x => x.Id);
                });

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
                name: "TechnicalNeed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    SupportsFreeText = table.Column<bool>(type: "bit", nullable: false),
                    EstimatedDurationMinutes = table.Column<int>(type: "int", nullable: true),
                    SlaMinutes = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalNeed", x => x.Id);
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
                name: "TravelOrTransportation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    TransportationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransportationAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransportationVehicle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceStatusId = table.Column<int>(type: "int", nullable: false),
                    IsChargeable = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelOrTransportation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ValetParkingServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceStatusId = table.Column<int>(type: "int", nullable: false),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    IsChargeable = table.Column<bool>(type: "bit", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedDurationMinutes = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValetParkingServices", x => x.Id);
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
                name: "WakeUpCallServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    IsChargeable = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceStatusId = table.Column<int>(type: "int", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiresAppointment = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WakeUpCallServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfStar = table.Column<int>(type: "int", nullable: false),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultLanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckInTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CheckOutTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDemoHotel = table.Column<bool>(type: "bit", nullable: false),
                    Companyid = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotel_Company_Companyid",
                        column: x => x.Companyid,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferredLanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastLoginAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FailedLoginCount = table.Column<int>(type: "int", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPinned = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    AudienceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcements_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerEmployeeId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    IsGuestFacing = table.Column<bool>(type: "bit", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodMenuCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMenuCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodMenuCategory_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageCategory_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    RoomFoodTypeId = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    FloorNo = table.Column<int>(type: "int", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFull = table.Column<bool>(type: "bit", nullable: false),
                    CurrentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceStatusId = table.Column<int>(type: "int", nullable: false),
                    InternalPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_FoodType_RoomFoodTypeId",
                        column: x => x.RoomFoodTypeId,
                        principalTable: "FoodType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Room_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Room_RoomType_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    LegacyServiceType = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceCategories_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsNightShift = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shift_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeType_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinimumQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LastPurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AverageUnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsCritical = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockItems_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockItems_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceStatusId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodMenuCategoryId = table.Column<int>(type: "int", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsOnPromotion = table.Column<bool>(type: "bit", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    PREPARATIONTIME = table.Column<TimeOnly>(type: "time", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Food_FoodMenuCategory_FoodMenuCategoryId",
                        column: x => x.FoodMenuCategoryId,
                        principalTable: "FoodMenuCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestStays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    ReservationNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryCustomerId = table.Column<int>(type: "int", nullable: true),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualCheckInAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualCheckOutAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VerificationCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuestLanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMobileAccessEnabled = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccommodationConceptType = table.Column<int>(type: "int", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestStays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuestStays_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceDefinitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    ServiceCategoryId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    ServiceType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningMessage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsVisibleToGuest = table.Column<bool>(type: "bit", nullable: false),
                    IsChargeable = table.Column<bool>(type: "bit", nullable: false),
                    SupportsFreeText = table.Column<bool>(type: "bit", nullable: false),
                    RequiresAppointment = table.Column<bool>(type: "bit", nullable: false),
                    EstimatedDurationMinutes = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDefinitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceDefinitions_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceDefinitions_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceDefinitions_ServiceCategories_ServiceCategoryId",
                        column: x => x.ServiceCategoryId,
                        principalTable: "ServiceCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    HireType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftId = table.Column<int>(type: "int", nullable: true),
                    IsAvailableForTask = table.Column<bool>(type: "bit", nullable: false),
                    AverageRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LastAssignedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LanguageCodes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeType_EmployeeTypeId",
                        column: x => x.EmployeeTypeId,
                        principalTable: "EmployeeType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employee_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employee_Shift_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shift",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoodAllergen",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    AllergenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodAllergen", x => new { x.FoodId, x.AllergenId });
                    table.ForeignKey(
                        name: "FK_FoodAllergen_Allergen_AllergenId",
                        column: x => x.AllergenId,
                        principalTable: "Allergen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodAllergen_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodContentsOfFood",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    ContentsOfFoodId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodContentsOfFood", x => new { x.FoodId, x.ContentsOfFoodId });
                    table.ForeignKey(
                        name: "FK_FoodContentsOfFood_ContentsOfFood_ContentsOfFoodId",
                        column: x => x.ContentsOfFoodId,
                        principalTable: "ContentsOfFood",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodContentsOfFood_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodDietaryRestrictions",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    DietaryRestrictionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodDietaryRestrictions", x => new { x.FoodId, x.DietaryRestrictionId });
                    table.ForeignKey(
                        name: "FK_FoodDietaryRestrictions_DietaryRestriction_DietaryRestrictionId",
                        column: x => x.DietaryRestrictionId,
                        principalTable: "DietaryRestriction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodDietaryRestrictions_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NutritionalInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calories = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Protein = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Carbohydrates = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sugar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fiber = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionalInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NutritionalInfo_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferredLanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPrimaryGuest = table.Column<bool>(type: "bit", nullable: false),
                    GuestStayId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_GuestStays_GuestStayId",
                        column: x => x.GuestStayId,
                        principalTable: "GuestStays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelServicePolicies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    ServiceType = table.Column<int>(type: "int", nullable: false),
                    ServiceItemId = table.Column<int>(type: "int", nullable: true),
                    ServiceDefinitionId = table.Column<int>(type: "int", nullable: true),
                    AccommodationConceptType = table.Column<int>(type: "int", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    IsIncludedInPackage = table.Column<bool>(type: "bit", nullable: false),
                    IsChargeable = table.Column<bool>(type: "bit", nullable: false),
                    AllowRoomCharge = table.Column<bool>(type: "bit", nullable: false),
                    AllowOnlinePayment = table.Column<bool>(type: "bit", nullable: false),
                    AllowOnSitePayment = table.Column<bool>(type: "bit", nullable: false),
                    PriceOverride = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelServicePolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelServicePolicies_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HotelServicePolicies_ServiceDefinitions_ServiceDefinitionId",
                        column: x => x.ServiceDefinitionId,
                        principalTable: "ServiceDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceDefinitionFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceDefinitionId = table.Column<int>(type: "int", nullable: false),
                    FieldKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placeholder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldType = table.Column<int>(type: "int", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    OptionsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidationRegex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDefinitionFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceDefinitionFields_ServiceDefinitions_ServiceDefinitionId",
                        column: x => x.ServiceDefinitionId,
                        principalTable: "ServiceDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    ShiftId = table.Column<int>(type: "int", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlannedStartTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    PlannedEndTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    CheckInAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckOutAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    LateMinutes = table.Column<int>(type: "int", nullable: false),
                    OvertimeMinutes = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttendanceRecords_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AttendanceRecords_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AttendanceRecords_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AttendanceRecords_Shift_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shift",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    StartDateOfWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExitDateOfWork = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastOnlineTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FloorNo = table.Column<int>(type: "int", nullable: true),
                    OnlineOrOfflineNow = table.Column<bool>(type: "bit", nullable: false),
                    EmergencyContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDetail_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpireAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsMandatory = table.Column<bool>(type: "bit", nullable: false),
                    VerifiedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    VerifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDocuments_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeDocuments_Employee_VerifiedByEmployeeId",
                        column: x => x.VerifiedByEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeDocuments_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InternalAnnouncements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Audience = table.Column<int>(type: "int", nullable: false),
                    PublishAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPinned = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternalAnnouncements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternalAnnouncements_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InternalAnnouncements_Employee_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InternalAnnouncements_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    ManagerEmployeeId = table.Column<int>(type: "int", nullable: true),
                    HrEmployeeId = table.Column<int>(type: "int", nullable: true),
                    LeaveType = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalDayCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RequestedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManagerActionAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HrActionAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ManagerNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HrNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Employee_HrEmployeeId",
                        column: x => x.HrEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Employee_ManagerEmployeeId",
                        column: x => x.ManagerEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ReviewerEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeriodStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PeriodEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Score = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Strengths = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImprovementAreas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerformanceReviews_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerformanceReviews_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerformanceReviews_Employee_ReviewerEmployeeId",
                        column: x => x.ReviewerEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerformanceReviews_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockMovements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    StockItemId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    MovementType = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceId = table.Column<int>(type: "int", nullable: true),
                    OccurredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockMovements_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockMovements_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockMovements_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockMovements_StockItems_StockItemId",
                        column: x => x.StockItemId,
                        principalTable: "StockItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Conversations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    GuestStayId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    ServiceRequestId = table.Column<int>(type: "int", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ConversationType = table.Column<int>(type: "int", nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conversations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conversations_GuestStays_GuestStayId",
                        column: x => x.GuestStayId,
                        principalTable: "GuestStays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conversations_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GuestSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestStayId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    SessionToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QrCodeToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeviceToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActiveSession = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuestSessions_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GuestSessions_GuestStays_GuestStayId",
                        column: x => x.GuestStayId,
                        principalTable: "GuestStays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConversationFlowSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConversationId = table.Column<int>(type: "int", nullable: false),
                    ServiceCategoryId = table.Column<int>(type: "int", nullable: true),
                    ServiceDefinitionId = table.Column<int>(type: "int", nullable: true),
                    FlowType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentStep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateJson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversationFlowSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConversationFlowSessions_Conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "Conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConversationFlowSessions_ServiceCategories_ServiceCategoryId",
                        column: x => x.ServiceCategoryId,
                        principalTable: "ServiceCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConversationFlowSessions_ServiceDefinitions_ServiceDefinitionId",
                        column: x => x.ServiceDefinitionId,
                        principalTable: "ServiceDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConversationMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConversationId = table.Column<int>(type: "int", nullable: false),
                    SenderUserId = table.Column<int>(type: "int", nullable: true),
                    SenderCustomerId = table.Column<int>(type: "int", nullable: true),
                    SenderType = table.Column<int>(type: "int", nullable: false),
                    OriginalLanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginalText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TranslatedText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranslatedLanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReadAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MessageType = table.Column<int>(type: "int", nullable: false),
                    PayloadJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranslationProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranslationModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranslationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversationMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConversationMessages_Conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "Conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConversationMessages_Customers_SenderCustomerId",
                        column: x => x.SenderCustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConversationMessages_Users_SenderUserId",
                        column: x => x.SenderUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    GuestStayId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    ServiceType = table.Column<int>(type: "int", nullable: false),
                    ServiceCatalogItemId = table.Column<int>(type: "int", nullable: true),
                    ServiceDefinitionId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    RequestSource = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    AssignedEmployeeId = table.Column<int>(type: "int", nullable: true),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClosedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResolutionNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsChatStarted = table.Column<bool>(type: "bit", nullable: false),
                    ConversationId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_Conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "Conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_Employee_AssignedEmployeeId",
                        column: x => x.AssignedEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_GuestStays_GuestStayId",
                        column: x => x.GuestStayId,
                        principalTable: "GuestStays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceRequests_ServiceDefinitions_ServiceDefinitionId",
                        column: x => x.ServiceDefinitionId,
                        principalTable: "ServiceDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    AssignedEmployeeId = table.Column<int>(type: "int", nullable: false),
                    AssignedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    RelatedServiceRequestId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DueAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletionNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeTasks_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeTasks_Employee_AssignedByEmployeeId",
                        column: x => x.AssignedByEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeTasks_Employee_AssignedEmployeeId",
                        column: x => x.AssignedEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeTasks_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeTasks_ServiceRequests_RelatedServiceRequestId",
                        column: x => x.RelatedServiceRequestId,
                        principalTable: "ServiceRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceChargeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceStatusId = table.Column<int>(type: "int", nullable: false),
                    PaymentOption = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    IsPostedToRoom = table.Column<bool>(type: "bit", nullable: false),
                    PostedToRoomAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServiceRequestId = table.Column<int>(type: "int", nullable: true),
                    GuestStayId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_GuestStays_GuestStayId",
                        column: x => x.GuestStayId,
                        principalTable: "GuestStays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_ServiceRequests_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "ServiceRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRequestFieldValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceRequestId = table.Column<int>(type: "int", nullable: false),
                    ServiceDefinitionFieldId = table.Column<int>(type: "int", nullable: false),
                    FieldKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequestFieldValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceRequestFieldValues_ServiceDefinitionFields_ServiceDefinitionFieldId",
                        column: x => x.ServiceDefinitionFieldId,
                        principalTable: "ServiceDefinitionFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceRequestFieldValues_ServiceRequests_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "ServiceRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRequestHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceRequestId = table.Column<int>(type: "int", nullable: false),
                    OldStatus = table.Column<int>(type: "int", nullable: true),
                    NewStatus = table.Column<int>(type: "int", nullable: false),
                    ChangedByUserId = table.Column<int>(type: "int", nullable: true),
                    ChangedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequestHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceRequestHistories_ServiceRequests_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "ServiceRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceRequestHistories_Users_ChangedByUserId",
                        column: x => x.ChangedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRequestItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceRequestId = table.Column<int>(type: "int", nullable: false),
                    ServiceDefinitionId = table.Column<int>(type: "int", nullable: true),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequestItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceRequestItems_ServiceDefinitions_ServiceDefinitionId",
                        column: x => x.ServiceDefinitionId,
                        principalTable: "ServiceDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceRequestItems_ServiceRequests_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "ServiceRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRequestMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceRequestId = table.Column<int>(type: "int", nullable: false),
                    SenderUserId = table.Column<int>(type: "int", nullable: true),
                    SenderType = table.Column<int>(type: "int", nullable: false),
                    OriginalLanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginalText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TranslatedText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranslatedLanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReadAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NormalizedText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranslationProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranslationModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranslationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequestMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceRequestMessages_ServiceRequests_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "ServiceRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceRequestMessages_Users_SenderUserId",
                        column: x => x.SenderUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRequestRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceRequestId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    SpeedScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QualityScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StaffScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequestRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceRequestRatings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceRequestRatings_ServiceRequests_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "ServiceRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    RequestedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    AssignedManagerEmployeeId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    RelatedServiceRequestId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RequestedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FulfilledAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ManagerNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockRequests_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockRequests_Employee_AssignedManagerEmployeeId",
                        column: x => x.AssignedManagerEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockRequests_Employee_RequestedByEmployeeId",
                        column: x => x.RequestedByEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockRequests_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockRequests_ServiceRequests_RelatedServiceRequestId",
                        column: x => x.RelatedServiceRequestId,
                        principalTable: "ServiceRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Charges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestStayId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    ServiceRequestId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPostedToRoom = table.Column<bool>(type: "bit", nullable: false),
                    PostedToRoomAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Charges_GuestStays_GuestStayId",
                        column: x => x.GuestStayId,
                        principalTable: "GuestStays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Charges_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Charges_ServiceRequests_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "ServiceRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesEnumId = table.Column<int>(type: "int", nullable: false),
                    ServiceItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LineTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceChargeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsIncludedInPackage = table.Column<bool>(type: "bit", nullable: false),
                    AppliedHotelServicePolicyId = table.Column<int>(type: "int", nullable: true),
                    PaymentOption = table.Column<int>(type: "int", nullable: false),
                    PriceStatusId = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AppointmentLastDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    StatusTypeEnum = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockRequestItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockRequestId = table.Column<int>(type: "int", nullable: false),
                    StockItemId = table.Column<int>(type: "int", nullable: false),
                    RequestedQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ApprovedQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FulfilledQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockRequestItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockRequestItems_StockItems_StockItemId",
                        column: x => x.StockItemId,
                        principalTable: "StockItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockRequestItems_StockRequests_StockRequestId",
                        column: x => x.StockRequestId,
                        principalTable: "StockRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChargeId = table.Column<int>(type: "int", nullable: false),
                    PaymentProvider = table.Column<int>(type: "int", nullable: false),
                    ExternalTransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RedirectUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaidAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FailureReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTransactions_Charges_ChargeId",
                        column: x => x.ChargeId,
                        principalTable: "Charges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommentAndRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeedPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeePoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderItemId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentAndRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentAndRatings_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CommentAndRatings_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentAndRatings_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageCategoryId = table.Column<int>(type: "int", nullable: false),
                    OrderItemId = table.Column<int>(type: "int", nullable: true),
                    FoodId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Image_ImageCategory_ImageCategoryId",
                        column: x => x.ImageCategoryId,
                        principalTable: "ImageCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Image_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "BellBoy",
                columns: new[] { "Id", "CreatedDate", "DepartmentId", "Description", "EstimatedDurationMinutes", "HotelId", "ImageUrl", "IsActive", "IsDeleted", "IsVisibleToGuest", "ModifyDate", "Name" },
                values: new object[] { 1, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(2250), 1, "Misafirin bagaj tasima talebi icin kullanilir.", 10, 1, "1.jpeg", true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(2254), "Bagaj Tasima" });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(1233), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(1267), "Worigo" },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(1277), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(1278), "Ramada" }
                });

            migrationBuilder.InsertData(
                table: "Connection",
                columns: new[] { "Id", "CreatedDate", "FlootNo", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[] { 1, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(4189), null, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(4192), "1q2w3e4r5t" });

            migrationBuilder.InsertData(
                table: "ContentsOfFood",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(5635), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(5653), "Siyah Zeytin" },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(5656), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(5657), "Mantar" },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(5658), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(5659), "Turşu" }
                });

            migrationBuilder.InsertData(
                table: "DryCleaner",
                columns: new[] { "Id", "CreatedDate", "CurrencyCode", "DepartmentId", "Description", "DisplayOrder", "EstimatedDurationMinutes", "HotelId", "ImageUrl", "IsActive", "IsChargeable", "IsDeleted", "IsVisibleToGuest", "ModifyDate", "Name", "ParentId", "Price", "PriceStatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(6548), "TRY", 2, "Utu hizmeti", 1, null, 1, "1.jpeg", true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(6553), "Utu", null, null, 1 },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(6622), "TRY", 2, "T-Shirt", 2, null, 1, "1.jpeg", true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(6623), "T-Shirt", 1, 150m, 1 },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(6625), "TRY", 2, "Kaban-Mont", 3, null, 1, "1.jpeg", true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(6626), "Kaban-Mont", 1, 250m, 1 },
                    { 4, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(6628), "TRY", 2, "Kuru temizleme", 4, null, 1, "1.jpeg", true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(6628), "Kuru Temizleme", null, null, 1 },
                    { 5, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(6631), "TRY", 2, "T-Shirt", 5, null, 1, "1.jpeg", true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(6631), "T-Shirt", 4, 150m, 1 },
                    { 6, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(6634), "TRY", 2, "Kaban-Mont", 6, null, 1, "1.jpeg", true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(6635), "Kaban-Mont", 4, 200m, 1 },
                    { 7, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(6637), "TRY", 2, "Kot-kumas pantolonlar", 7, null, 1, "1.jpeg", true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(6637), "Pantolon", 4, 200m, 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodType",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "RoomFoodTypeEnum" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(629), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(633), 1 },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(636), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(637), 2 },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(638), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(639), 3 },
                    { 4, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(640), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(640), 4 },
                    { 5, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(641), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 120, DateTimeKind.Local).AddTicks(642), 5 }
                });

            migrationBuilder.InsertData(
                table: "HotelInformationAndAnnouncements",
                columns: new[] { "Id", "AnnouncementType", "CreatedDate", "Date", "Description", "EndDate", "HotelId", "ImageUrl", "IsActive", "IsDeleted", "IsPinned", "IsVisibleToGuest", "Location", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(443), new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(434), "Sihirbaz Gostersi", null, 1, "1.jpeg", true, false, false, true, "Ana salon", new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(444), "Animasyon" },
                    { 2, 1, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(452), new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(452), "Animasyon", null, 1, "1.jpeg", true, false, false, true, "Etkinlik alani", new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(453), "Dans Gosterisi" },
                    { 3, 1, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(455), new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(455), "Orta salonda", null, 1, "1.jpeg", true, false, true, true, "Orta salon", new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(456), "Milli Mac" },
                    { 4, 1, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(458), new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(458), "Animasyon", null, 1, "1.jpeg", true, false, false, false, "Animasyon alani", new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(459), "Dans Gosterisi" }
                });

            migrationBuilder.InsertData(
                table: "HouseKeeping",
                columns: new[] { "Id", "CreatedDate", "DepartmentId", "Description", "DisplayOrder", "EstimatedDurationMinutes", "HotelId", "ImageUrl", "IsActive", "IsDeleted", "IsVisibleToGuest", "ModifyDate", "Name", "ParentId", "SupportsFreeText" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(2402), 2, null, 1, 15, 1, "1.jpeg", true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(2406), "Havlu degisimi veya eksigi", null, true },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(2413), 2, null, 2, 45, 1, "1.jpeg", true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(2414), "Oda genel temizlik", null, true },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(2416), 2, null, 3, 20, 1, "", true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(2417), "Carsaf veya yatak yuzu degisimi", null, true }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 123, DateTimeKind.Local).AddTicks(7767), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 123, DateTimeKind.Local).AddTicks(7776), "SystemAdmin" },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 123, DateTimeKind.Local).AddTicks(7778), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 123, DateTimeKind.Local).AddTicks(7779), "HotelAdmin" },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 123, DateTimeKind.Local).AddTicks(7780), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 123, DateTimeKind.Local).AddTicks(7780), "Management" },
                    { 4, new DateTime(2026, 5, 17, 6, 37, 45, 123, DateTimeKind.Local).AddTicks(7782), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 123, DateTimeKind.Local).AddTicks(7782), "DepartmentManager" },
                    { 5, new DateTime(2026, 5, 17, 6, 37, 45, 123, DateTimeKind.Local).AddTicks(7783), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 123, DateTimeKind.Local).AddTicks(7784), "Employee" },
                    { 6, new DateTime(2026, 5, 17, 6, 37, 45, 123, DateTimeKind.Local).AddTicks(7785), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 123, DateTimeKind.Local).AddTicks(7785), "Customer" }
                });

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "RoomTypeEnum" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(1433), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(1436), 1 },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(1438), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(1438), 2 },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(1440), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(1440), 3 },
                    { 4, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(1441), true, false, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(1442), 4 }
                });

            migrationBuilder.InsertData(
                table: "ServiceRoleAssignment",
                columns: new[] { "Id", "CreatedDate", "DepartmentId", "EmployeeTypeRoleId", "HotelId", "IsActive", "IsDeleted", "IsPrimaryAssignment", "ModifyDate", "Priority", "ServiceId", "ServicesEnumId", "SlaMinutes" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(859), 3, 17, 1, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(868), 1, 1, 1, 30 },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(879), 3, 18, 1, true, false, false, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(880), 2, 1, 1, 30 },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(883), 3, 19, 1, true, false, false, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(884), 3, 1, 1, 30 },
                    { 4, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(886), 3, 20, 1, true, false, false, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(886), 4, 1, 1, 30 },
                    { 5, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(889), 1, 6, 1, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(889), 1, 3, 3, 10 }
                });

            migrationBuilder.InsertData(
                table: "SpaMassage",
                columns: new[] { "Id", "CreatedDate", "CurrencyCode", "DepartmentId", "Description", "EstimatedDurationMinutes", "HotelId", "IsActive", "IsChargeable", "IsDeleted", "IsVisibleToGuest", "ModifyDate", "Name", "ParentId", "Price", "PriceStatusId", "RequiresAppointment", "TypesOfHealthAndSports" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(4084), "TRY", 5, "Uzak Dogu masaji", 60, 1, true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(4086), "Uzak Dogu", null, 200m, 1, true, 0 },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(4095), "TRY", 5, "Tayland masaji", 60, 1, true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(4096), "Tayland Masaji", null, 200m, 1, true, 0 }
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
                table: "TechnicalNeed",
                columns: new[] { "Id", "CreatedDate", "DepartmentId", "Description", "DisplayOrder", "EstimatedDurationMinutes", "HotelId", "ImageUrl", "IsActive", "IsDeleted", "IsVisibleToGuest", "ModifyDate", "Name", "ParentId", "SlaMinutes", "SupportsFreeText" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(5693), 4, "Klima ile ariza durumlari", 1, 60, 1, "1.jpeg", true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(5696), "Klima", null, 30, true },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(5705), 4, "TV ile ariza durumlari", 2, 45, 1, "1.jpeg", true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(5705), "TV", null, 30, true },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(5708), 4, "Minibar ile ariza durumlari", 3, 45, 1, "1.jpeg", true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(5709), "Minibar", null, 30, true },
                    { 4, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(5712), 4, "Kapi ile ariza durumlari", 4, 40, 1, "1.jpeg", true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(5713), "Kapi", null, 30, true },
                    { 5, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(5716), 4, "Elektrik ile ariza durumlari", 5, 30, 1, "1.jpeg", true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(5716), "Elektrik", null, 20, true },
                    { 6, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(5719), 4, "Aydinlatma ile ariza durumlari", 6, 30, 1, "1.jpeg", true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(5719), "Aydinlatma", null, 20, true },
                    { 7, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(5722), 4, "Dus ve tuvalet ile ariza durumlari", 7, 45, 1, "1.jpeg", true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(5722), "Dus ve Tuvalet", null, 30, true }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedDate", "FieldName", "IsActive", "IsDeleted", "LanguageCode", "ModifyDate", "RecordId", "TableName", "TranslationValue" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7744), "UnknownError", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7750), 0, "", "İşlem yaparken bir sorun oluştu. Lütfen tekrar deneyiniz." },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7758), "UnknownError", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7758), 0, "", "There was a problem while processing the transaction. Please try again." },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7760), "UnknownError", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7760), 0, "", "Во время обработки возникла проблема. Пожалуйста, попробуйте еще раз." },
                    { 4, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7761), "UnknownError", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7762), 0, "", "Un problème est survenu lors du traitement. Veuillez réessayer." },
                    { 5, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7763), "UnknownError", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7764), 0, "", "Hubo un problema durante el procesamiento. Por favor inténtalo de nuevo." },
                    { 6, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7765), "UnknownError", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7765), 0, "", "حدثت مشكلة أثناء المعالجة. يرجى المحاولة مرة أخرى." },
                    { 7, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7767), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7767), 5, "SystemParametreValue", "Hazırlanıyor" },
                    { 8, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7768), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7769), 6, "SystemParametreValue", "Geliyor" },
                    { 9, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7770), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7770), 7, "SystemParametreValue", "İptal Edildi" },
                    { 10, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7771), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7772), 5, "SystemParametreValue", "Preparing" },
                    { 11, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7773), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7773), 6, "SystemParametreValue", "IsComing" },
                    { 12, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7774), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7775), 7, "SystemParametreValue", "Delivered" },
                    { 13, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7776), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7776), 5, "SystemParametreValue", "Preparándose" },
                    { 14, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7778), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7778), 6, "SystemParametreValue", "A punto de venir" },
                    { 15, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7779), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7780), 7, "SystemParametreValue", "Entregado" },
                    { 16, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7781), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7781), 5, "SystemParametreValue", "Se préparer" },
                    { 17, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7782), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7783), 6, "SystemParametreValue", "Sur le point de venir." },
                    { 18, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7785), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7785), 7, "SystemParametreValue", "A été livré." },
                    { 19, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7786), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7787), 5, "SystemParametreValue", "готовлюсь." },
                    { 20, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7788), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7788), 6, "SystemParametreValue", "Скоро придет" },
                    { 21, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7789), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7790), 7, "SystemParametreValue", "Доставленный." },
                    { 22, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7791), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7791), 5, "SystemParametreValue", "الاستعداد" },
                    { 23, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7792), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7793), 6, "SystemParametreValue", "على وشك المجيء" },
                    { 24, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7794), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7794), 7, "SystemParametreValue", "تم التوصيل" },
                    { 25, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7795), "Name", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7796), 1, "TechnicalNeed", "Air conditioning" },
                    { 26, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7797), "Description", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7797), 1, "TechnicalNeed", "Malfunction situations with air conditioning" },
                    { 27, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7798), "Name", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7799), 1, "TechnicalNeed", "Aire acondicionado" },
                    { 28, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7800), "Description", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7800), 1, "TechnicalNeed", "Situaciones de avería con el aire acondicionado." },
                    { 29, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7801), "Name", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7802), 1, "TechnicalNeed", "Кондиционер" },
                    { 30, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7803), "Description", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7803), 1, "TechnicalNeed", "Ситуации неисправности кондиционера" },
                    { 31, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7804), "Name", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7805), 1, "TechnicalNeed", "Climatisation" },
                    { 32, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7806), "Description", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7806), 1, "TechnicalNeed", "Situations de dysfonctionnement de la climatisation" },
                    { 33, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7807), "Name", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7808), 1, "TechnicalNeed", "تكييف" },
                    { 34, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7809), "Description", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7809), 1, "TechnicalNeed", "حالات الأعطال بالتكييف" },
                    { 35, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7810), "Name", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7811), 1, "TechnicalNeed", "Klima" },
                    { 36, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7812), "Description", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7812), 1, "TechnicalNeed", "Klima ile arıza durumları" },
                    { 37, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7814), "Name", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7814), 2, "TechnicalNeed", "TV" },
                    { 38, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7815), "Description", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7815), 2, "TechnicalNeed", "Malfunction situations with TV" },
                    { 39, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7817), "Name", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7817), 2, "TechnicalNeed", "TELEVISOR" },
                    { 40, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7819), "Description", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7819), 2, "TechnicalNeed", "Situaciones de mal funcionamiento con TV." },
                    { 41, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7820), "Name", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7820), 2, "TechnicalNeed", "ТВ" },
                    { 42, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7821), "Description", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7822), 2, "TechnicalNeed", "Неисправные ситуации с телевизором" },
                    { 43, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7823), "Name", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7823), 2, "TechnicalNeed", "TV" },
                    { 44, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7824), "Description", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7825), 2, "TechnicalNeed", "Situations de dysfonctionnement avec la télévision" },
                    { 45, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7827), "Name", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7828), 2, "TechnicalNeed", "تلفزيون" },
                    { 46, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7829), "Description", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7829), 2, "TechnicalNeed", "حالات الأعطال بالتلفاز" },
                    { 47, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7830), "Name", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7830), 2, "TechnicalNeed", "TV" },
                    { 48, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7831), "Description", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7832), 2, "TechnicalNeed", "TV ile arıza durumları" },
                    { 49, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7833), "Name", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7833), 3, "TechnicalNeed", "Mini-bar" },
                    { 50, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7835), "Description", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7835), 3, "TechnicalNeed", "Malfunction situations with minibar" },
                    { 51, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7836), "Name", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7836), 3, "TechnicalNeed", "Mini-bar" },
                    { 52, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7838), "Description", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7838), 3, "TechnicalNeed", "Situaciones de avería con el minibar" },
                    { 53, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7839), "Name", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7840), 3, "TechnicalNeed", "мини-бар" },
                    { 54, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7840), "Description", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7841), 3, "TechnicalNeed", "Ситуации неисправности мини-бара" },
                    { 55, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7842), "Name", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7842), 3, "TechnicalNeed", "Mini-bar" },
                    { 56, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7843), "Description", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7844), 3, "TechnicalNeed", "Situations de dysfonctionnement du minibar" },
                    { 57, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7847), "Name", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7847), 3, "TechnicalNeed", "ميني بار" },
                    { 58, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7848), "Description", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7849), 3, "TechnicalNeed", "حالات الأعطال بالميني بار" },
                    { 59, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7850), "Name", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7850), 3, "TechnicalNeed", "Minibar" },
                    { 60, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7851), "Description", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7852), 3, "TechnicalNeed", "Minibar ile arıza durumları" },
                    { 61, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7853), "Name", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7853), 4, "TechnicalNeed", "Door" },
                    { 62, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7854), "Description", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7855), 4, "TechnicalNeed", "Fault situations with door" },
                    { 63, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7856), "Name", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7856), 4, "TechnicalNeed", "Puerta" },
                    { 64, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7858), "Description", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7858), 4, "TechnicalNeed", "Situaciones de avería con el puerta" },
                    { 65, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7859), "Name", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7859), 4, "TechnicalNeed", "Дверь" },
                    { 66, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7860), "Description", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7861), 4, "TechnicalNeed", "Неисправные ситуации с дверью" },
                    { 67, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7862), "Name", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7862), 4, "TechnicalNeed", "Porte" },
                    { 68, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7864), "Description", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7864), 4, "TechnicalNeed", "Situations de défauts avec la porte" },
                    { 69, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7865), "Name", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7866), 4, "TechnicalNeed", "باب" },
                    { 70, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7867), "Description", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7867), 4, "TechnicalNeed", "حالات خطأ مع الباب" },
                    { 71, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7868), "Name", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7868), 4, "TechnicalNeed", "Kapı" },
                    { 72, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7925), "Description", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7926), 4, "TechnicalNeed", "Kapı ile arıza durumları" },
                    { 73, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7927), "Name", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7928), 5, "TechnicalNeed", "Electric" },
                    { 74, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7929), "Description", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7930), 5, "TechnicalNeed", "Electrical fault situations" },
                    { 75, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7931), "Name", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7931), 5, "TechnicalNeed", "Eléctrico" },
                    { 76, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7932), "Description", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7933), 5, "TechnicalNeed", "Situaciones de falla eléctrica" },
                    { 77, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7934), "Name", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7935), 5, "TechnicalNeed", "Электрический" },
                    { 78, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7936), "Description", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7936), 5, "TechnicalNeed", "Ситуации электрических неисправностей" },
                    { 79, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7937), "Name", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7938), 5, "TechnicalNeed", "Électrique" },
                    { 80, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7939), "Description", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7939), 5, "TechnicalNeed", "Situations de panne électrique" },
                    { 81, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7940), "Name", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7941), 5, "TechnicalNeed", "كهربائي" },
                    { 82, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7942), "Description", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7942), 5, "TechnicalNeed", "حالات الأعطال الكهربائية" },
                    { 83, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7943), "Name", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7944), 5, "TechnicalNeed", "Elektrik" },
                    { 84, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7945), "Description", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7945), 5, "TechnicalNeed", "Elektrik ile arıza durumları" },
                    { 85, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7946), "Name", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7947), 6, "TechnicalNeed", "Lighting" },
                    { 86, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7948), "Description", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7948), 6, "TechnicalNeed", "Malfunction situations with lighting" },
                    { 87, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7949), "Name", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7950), 6, "TechnicalNeed", "Iluminación" },
                    { 88, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7951), "Description", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7951), 6, "TechnicalNeed", "Situaciones de mal funcionamiento con la iluminación." },
                    { 89, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7952), "Name", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7953), 6, "TechnicalNeed", "Освещение" },
                    { 90, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7954), "Description", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7954), 6, "TechnicalNeed", "Ситуации неисправности с освещением" },
                    { 91, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7955), "Name", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7955), 6, "TechnicalNeed", "Éclairage" },
                    { 92, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7956), "Description", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7957), 6, "TechnicalNeed", "Situations de dysfonctionnement de l'éclairage" },
                    { 93, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7958), "Name", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7959), 6, "TechnicalNeed", "إضاءة" },
                    { 94, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7960), "Description", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7960), 6, "TechnicalNeed", "حالات الأعطال بالإضاءة" },
                    { 95, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7961), "Name", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7962), 6, "TechnicalNeed", "Aydınlatma" },
                    { 96, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7963), "Description", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7963), 6, "TechnicalNeed", "Aydınlatma ile arıza durumları" },
                    { 97, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7965), "Name", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7965), 7, "TechnicalNeed", "Shower and Toilet" },
                    { 98, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7966), "Description", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7967), 7, "TechnicalNeed", "Malfunction situations with shower and toilet" },
                    { 99, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7969), "Name", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7970), 7, "TechnicalNeed", "Ducha y WC" },
                    { 100, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7971), "Description", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7971), 7, "TechnicalNeed", "Situaciones de avería en ducha y WC" },
                    { 101, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7972), "Name", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7973), 7, "TechnicalNeed", "Душ и туалет" },
                    { 102, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7974), "Description", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7974), 7, "TechnicalNeed", "Ситуации неисправности с душем и туалетом" },
                    { 103, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7975), "Name", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7975), 7, "TechnicalNeed", "Douche et WC" },
                    { 104, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7976), "Description", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7977), 7, "TechnicalNeed", "Situations de dysfonctionnement avec douche et toilettes" },
                    { 105, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7978), "Name", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7978), 7, "TechnicalNeed", "دش ومرحاض" },
                    { 106, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7979), "Description", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7980), 7, "TechnicalNeed", "حالات خلل في الدش والمرحاض" },
                    { 107, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7981), "Name", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7981), 7, "TechnicalNeed", "Duş ve Tuvalet" },
                    { 108, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7982), "Description", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7983), 7, "TechnicalNeed", "Duş ve Tuvalet ile arıza durumları" },
                    { 109, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7984), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7984), 26, "SystemParametreValue", "In Proccess" },
                    { 110, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7985), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7985), 27, "SystemParametreValue", "Completed" },
                    { 111, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7986), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7987), 28, "SystemParametreValue", "Waiting" },
                    { 112, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7988), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7988), 26, "SystemParametreValue", "En proceso" },
                    { 113, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7989), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7990), 27, "SystemParametreValue", "Terminado" },
                    { 114, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7991), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7991), 28, "SystemParametreValue", "Espera" },
                    { 115, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7993), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7993), 26, "SystemParametreValue", "в процессе" },
                    { 116, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7994), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7995), 27, "SystemParametreValue", "завершенный" },
                    { 117, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7996), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7996), 28, "SystemParametreValue", "ожидающий" },
                    { 118, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7997), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7998), 26, "SystemParametreValue", "En Cours" },
                    { 119, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7999), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(7999), 27, "SystemParametreValue", "Complété" },
                    { 120, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8000), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8000), 28, "SystemParametreValue", "En Attendant" },
                    { 121, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8003), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8003), 26, "SystemParametreValue", "قيد المعالجة" },
                    { 122, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8005), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8005), 27, "SystemParametreValue", "مكتمل" },
                    { 123, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8006), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8007), 28, "SystemParametreValue", "منتظر" },
                    { 124, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8008), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8008), 26, "SystemParametreValue", "İşlemde" },
                    { 125, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8009), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8010), 27, "SystemParametreValue", "Tamamlandı" },
                    { 126, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8012), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8012), 28, "SystemParametreValue", "Bekleniyor" },
                    { 127, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8013), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8014), 29, "SystemParametreValue", "Spa" },
                    { 128, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8015), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8015), 30, "SystemParametreValue", "Massage" },
                    { 129, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8016), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8017), 31, "SystemParametreValue", "Fitness" },
                    { 130, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8018), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8018), 32, "SystemParametreValue", "Poor" },
                    { 131, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8019), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8019), 29, "SystemParametreValue", "Spa" },
                    { 132, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8021), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8021), 30, "SystemParametreValue", "Masaje" },
                    { 133, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8022), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8023), 31, "SystemParametreValue", "Aptitud fisica" },
                    { 134, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8024), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8024), 32, "SystemParametreValue", "Piscina" },
                    { 135, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8025), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8026), 29, "SystemParametreValue", "Спа" },
                    { 136, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8027), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8027), 30, "SystemParametreValue", "Массаж" },
                    { 137, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8028), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8029), 31, "SystemParametreValue", "Фитнес" },
                    { 138, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8030), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8030), 32, "SystemParametreValue", "Бассейн" },
                    { 139, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8031), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8032), 29, "SystemParametreValue", "سبا" },
                    { 140, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8033), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8033), 30, "SystemParametreValue", "تدليك" },
                    { 141, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8034), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8035), 31, "SystemParametreValue", "لياقة بدنية" },
                    { 142, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8036), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8036), 32, "SystemParametreValue", "حمام السباحة" },
                    { 143, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8037), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8038), 29, "SystemParametreValue", "Spa" },
                    { 144, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8039), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8039), 30, "SystemParametreValue", "massage" },
                    { 145, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8040), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8040), 31, "SystemParametreValue", "Aptitude" },
                    { 146, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8041), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8042), 32, "SystemParametreValue", "Piscine" },
                    { 147, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8042), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8043), 29, "SystemParametreValue", "Spa" },
                    { 148, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8044), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8044), 30, "SystemParametreValue", "Masaj" },
                    { 149, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8045), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8046), 31, "SystemParametreValue", "Fitness" },
                    { 150, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8047), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8047), 32, "SystemParametreValue", "Havuz" },
                    { 151, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8048), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8048), 17, "SystemParametreValue", "Menu" },
                    { 152, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8049), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8050), 17, "SystemParametreValue", "Menú" },
                    { 153, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8052), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8052), 17, "SystemParametreValue", "Меню" },
                    { 154, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8053), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8054), 17, "SystemParametreValue", "Menu" },
                    { 155, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8055), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8055), 17, "SystemParametreValue", "قائمة طعام" },
                    { 156, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8056), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8057), 17, "SystemParametreValue", "Menü" },
                    { 157, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8057), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8058), 18, "SystemParametreValue", "Technical Needs" },
                    { 158, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8059), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8059), 18, "SystemParametreValue", "Necesidades técnicas" },
                    { 159, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8060), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8061), 18, "SystemParametreValue", "Технические потребности" },
                    { 160, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8061), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8062), 18, "SystemParametreValue", "Besoins techniques" },
                    { 161, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8063), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8063), 18, "SystemParametreValue", "الاحتياجات الفنية" },
                    { 162, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8064), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8065), 18, "SystemParametreValue", "Teknik İhtiyaçlar" },
                    { 163, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8066), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8066), 19, "SystemParametreValue", "BellBoy" },
                    { 164, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8067), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8067), 19, "SystemParametreValue", "Bellboy" },
                    { 165, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8068), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8069), 19, "SystemParametreValue", "БеллБой" },
                    { 166, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8070), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8070), 19, "SystemParametreValue", "Groom" },
                    { 167, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8071), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8072), 19, "SystemParametreValue", "خادم الفندق" },
                    { 168, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8073), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8073), 19, "SystemParametreValue", "Bellboy" },
                    { 169, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8074), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8075), 20, "SystemParametreValue", "Wi-Fi" },
                    { 170, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8076), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8076), 20, "SystemParametreValue", "Wi-Fi" },
                    { 171, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8079), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8079), 20, "SystemParametreValue", "Wi-Fi" },
                    { 172, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8080), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8081), 20, "SystemParametreValue", "Wi-Fi" },
                    { 173, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8082), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8082), 20, "SystemParametreValue", "Wi-Fi" },
                    { 174, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8115), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8115), 20, "SystemParametreValue", "Wi-Fi" },
                    { 175, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8116), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8117), 21, "SystemParametreValue", "Dry Cleaning" },
                    { 176, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8118), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8119), 21, "SystemParametreValue", "Limpieza en seco" },
                    { 177, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8120), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8121), 21, "SystemParametreValue", "химчистка" },
                    { 178, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8122), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8122), 21, "SystemParametreValue", "Nettoyage à sec" },
                    { 179, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8123), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8124), 21, "SystemParametreValue", "التنظيف الجاف" },
                    { 180, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8127), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8127), 21, "SystemParametreValue", "Kuru Temizleme" },
                    { 181, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8128), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8128), 22, "SystemParametreValue", "House Keeping" },
                    { 182, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8130), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8130), 22, "SystemParametreValue", "House Keeping" },
                    { 183, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8131), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8132), 22, "SystemParametreValue", "House Keeping" },
                    { 184, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8133), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8133), 22, "SystemParametreValue", "House Keeping" },
                    { 185, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8134), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8134), 22, "SystemParametreValue", "الأعمال المنزلية" },
                    { 186, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8135), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8136), 22, "SystemParametreValue", "House Keeping" },
                    { 187, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8137), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8137), 23, "SystemParametreValue", "Spa Message" },
                    { 188, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8138), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8139), 23, "SystemParametreValue", "Spa Message" },
                    { 189, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8140), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8140), 23, "SystemParametreValue", "Spa Message" },
                    { 190, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8141), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8141), 23, "SystemParametreValue", "Spa Message" },
                    { 191, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8143), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8143), 23, "SystemParametreValue", "Spa Message" },
                    { 192, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8144), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8144), 23, "SystemParametreValue", "Spa Message" },
                    { 193, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8145), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8146), 24, "SystemParametreValue", "Health and First Aid" },
                    { 194, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8147), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8147), 24, "SystemParametreValue", "Salud y primeros auxilios" },
                    { 195, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8148), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8149), 24, "SystemParametreValue", "Здоровье и первая помощь" },
                    { 196, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8150), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8150), 24, "SystemParametreValue", "Santé et premiers secours" },
                    { 197, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8151), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8152), 24, "SystemParametreValue", "الصحة والإسعافات الأولية" },
                    { 198, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8153), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8153), 24, "SystemParametreValue", "Sağlık ve İlk Yardım" },
                    { 199, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8154), "ParametreValue", true, false, "en-US", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8155), 25, "SystemParametreValue", "Travel Or Transportation" },
                    { 200, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8156), "ParametreValue", true, false, "es-ES", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8156), 25, "SystemParametreValue", "Viajes o transporte" },
                    { 201, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8157), "ParametreValue", true, false, "ru-RU", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8157), 25, "SystemParametreValue", "Путешествие или транспорт" },
                    { 202, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8159), "ParametreValue", true, false, "fr-FR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8159), 25, "SystemParametreValue", "Voyage ou transport" },
                    { 203, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8160), "ParametreValue", true, false, "ar-SA", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8161), 25, "SystemParametreValue", "السفر أو النقل" },
                    { 204, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8162), "ParametreValue", true, false, "tr-TR", new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(8162), 25, "SystemParametreValue", "Seyahat Veya Ulaşım" }
                });

            migrationBuilder.InsertData(
                table: "ValidationMessages",
                columns: new[] { "Id", "IsDeleted", "LanguageCode", "ValidationMessage", "ValidationMessageType" },
                values: new object[,]
                {
                    { 1, false, "tr-TR", "Mail alanı boş olamaz.", 1 },
                    { 2, false, "en-US", "E-mail field cannot be empty.", 1 },
                    { 3, false, "es-ES", "Correo electrónico el campo no puede estar vacío", 1 },
                    { 4, false, "fr-FR", "E-mail le champ ne peut pas être vide.", 1 },
                    { 5, false, "ru-RU", "Электронная почта поле не может быть пустым", 1 },
                    { 6, false, "ar-SA", "بريد إلكتروني لا يمكن أن يكون الحقل فارغًا", 1 },
                    { 7, false, "tr-TR", "Geçerli bir email adresi giriniz.", 4 },
                    { 8, false, "en-US", "Please enter a valid email address.", 4 },
                    { 9, false, "es-ES", "Por favor, introduce una dirección de correo electrónico válida.", 4 },
                    { 10, false, "fr-FR", "S'il vous plaît, mettez une adresse email valide", 4 },
                    { 11, false, "ru-RU", "Пожалуйста, введите действительный адрес электронной почты", 4 },
                    { 12, false, "ar-SA", "يرجى إدخال عنوان بريد إلكتروني صالح", 4 },
                    { 13, false, "tr-TR", "Şifre alanı boş olamaz.", 5 },
                    { 14, false, "en-US", "Password cannot be empty.", 5 },
                    { 15, false, "es-ES", "La contraseña no puede estar vacía.", 5 },
                    { 16, false, "fr-FR", "Le mot de passe ne peut pas être vide.", 5 },
                    { 17, false, "ru-RU", "Пароль не может быть пустым.", 5 },
                    { 18, false, "ar-SA", "لا يمكن أن تكون كلمة المرور فارغة.", 5 }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "Adress", "CheckInTime", "CheckOutTime", "City", "Code", "Companyid", "Country", "CreatedDate", "DefaultLanguageCode", "Email", "IsActive", "IsDeleted", "IsDemoHotel", "Latitude", "Location", "LogoUrl", "Longitude", "ModifyDate", "Name", "NumberOfStar", "PhoneNumber", "TimeZone" },
                values: new object[] { 1, "", null, "Bağcılar", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 12, 0, 0, 0), "", "", 2, "", new DateTime(2026, 5, 17, 6, 37, 45, 122, DateTimeKind.Local).AddTicks(1345), "tr-TR", "tekstilkent@ramada.com", true, false, false, null, "Giyimkent", null, null, new DateTime(2026, 5, 17, 6, 37, 45, 122, DateTimeKind.Local).AddTicks(1352), "Tekstilkent", 4, "02126733520", "Europe/Istanbul" });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FailedLoginCount", "IsActive", "IsDeleted", "IsLocked", "LastLoginAt", "ModifyDate", "Password", "PreferredLanguageCode", "RefreshToken", "RefreshTokenExpireDate", "RoleId", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 126, DateTimeKind.Local).AddTicks(802), "samt51.m@icloud.com", 0, true, false, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 126, DateTimeKind.Local).AddTicks(806), "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "tr-TR", null, null, 1, null },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 126, DateTimeKind.Local).AddTicks(867), "ahmet51@gmail.com", 0, true, false, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 126, DateTimeKind.Local).AddTicks(867), "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "tr-TR", null, null, 5, null },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 126, DateTimeKind.Local).AddTicks(1051), "emre51@gmail.com", 0, true, false, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 126, DateTimeKind.Local).AddTicks(1052), "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "tr-TR", null, null, 5, null },
                    { 4, new DateTime(2026, 5, 17, 6, 37, 45, 126, DateTimeKind.Local).AddTicks(1102), "yunus51@gmail.com", 0, true, false, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 126, DateTimeKind.Local).AddTicks(1103), "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "tr-TR", null, null, 5, null },
                    { 5, new DateTime(2026, 5, 17, 6, 37, 45, 126, DateTimeKind.Local).AddTicks(1150), "fatih51@gmail.com", 0, true, false, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 126, DateTimeKind.Local).AddTicks(1151), "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "tr-TR", null, null, 5, null },
                    { 6, new DateTime(2026, 5, 17, 6, 37, 45, 126, DateTimeKind.Local).AddTicks(1198), "mehmet51@gmail.com", 0, true, false, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 126, DateTimeKind.Local).AddTicks(1198), "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "tr-TR", null, null, 5, null }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "CreatedDate", "Description", "DisplayOrder", "HotelId", "ImageUrl", "IsActive", "IsDeleted", "IsGuestFacing", "ManagerEmployeeId", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(8448), null, 0, 1, "1.jpeg", true, false, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(8455), "Ön Büro Resepsiyon Departmanı" },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(8462), null, 0, 1, "1.jpeg", true, false, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(8463), "Housekeeping Departmanı" },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(8466), null, 0, 1, "1.jpeg", true, false, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(8467), "Yiyecek İçecek ve Mutfak Departmanı" },
                    { 4, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(8469), null, 0, 1, "1.jpeg", true, false, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(8470), "Teknik Servis Departmanı" },
                    { 5, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(8474), null, 0, 1, "1.jpeg", true, false, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 118, DateTimeKind.Local).AddTicks(8475), "Sağlık Kulübü & Spa Departmanı" }
                });

            migrationBuilder.InsertData(
                table: "FoodMenuCategory",
                columns: new[] { "Id", "CreatedDate", "HotelId", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(8993), 1, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(8998), "Pizza" },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(9000), 1, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(9000), "Hamburger" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Capacity", "CreatedDate", "CurrentStatus", "Description", "FloorNo", "HotelId", "InternalPhoneNumber", "IsActive", "IsDeleted", "IsFull", "ModifyDate", "Name", "Price", "PriceStatusId", "RoomFoodTypeId", "RoomNumber", "RoomTypeId" },
                values: new object[] { 1, 2, new DateTime(2026, 5, 17, 6, 37, 45, 123, DateTimeKind.Local).AddTicks(9840), "Available", "Standart oda", 1, 1, null, true, false, false, new DateTime(2026, 5, 17, 6, 37, 45, 123, DateTimeKind.Local).AddTicks(9846), "101", 1500m, 1, 1, "101", 1 });

            migrationBuilder.InsertData(
                table: "ServiceCategories",
                columns: new[] { "Id", "CreatedDate", "Description", "DisplayOrder", "HotelId", "IconUrl", "IsActive", "IsDeleted", "LegacyServiceType", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3046), "Oda ici misafir hizmetleri", 1, 1, null, true, false, 6, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3049), "Oda Hizmetleri" },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3062), "Ariza ve teknik destek talepleri", 2, 1, null, true, false, 2, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3062), "Teknik Servis" },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3066), "Resepsiyon, bellboy ve konaklama hizmetleri", 3, 1, null, true, false, 3, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3067), "On Buro" },
                    { 4, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3069), "Utu, yikama ve kuru temizleme hizmetleri", 4, 1, null, true, false, 5, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3070), "Camasirhane" },
                    { 5, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3072), "Spa, masaj, saglik ve guvenlik hizmetleri", 5, 1, null, true, false, 7, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3072), "Wellness ve Saglik" },
                    { 6, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3075), "Transfer ve vale hizmetleri", 6, 1, null, true, false, 9, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3075), "Ulasim" },
                    { 7, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3079), "Menu ve minibar hizmetleri", 7, 1, null, true, false, 1, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3080), "Yiyecek Icecek" },
                    { 8, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3082), "Otel etkinlikleri ve duyurular", 8, 1, null, true, false, 8, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(3082), "Bilgilendirme" }
                });

            migrationBuilder.InsertData(
                table: "Shift",
                columns: new[] { "Id", "CreatedDate", "Description", "EndTime", "HotelId", "IsActive", "IsDeleted", "IsNightShift", "ModifyDate", "Name", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(3067), "Sabah operasyon vardiyasi", new TimeSpan(0, 16, 0, 0, 0), 1, true, false, false, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(3072), "Sabah Vardiyasi", new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(3091), "Aksam operasyon vardiyasi", new TimeSpan(0, 0, 0, 0, 0), 1, true, false, false, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(3092), "Aksam Vardiyasi", new TimeSpan(0, 16, 0, 0, 0) },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(3095), "Gece operasyon vardiyasi", new TimeSpan(0, 8, 0, 0, 0), 1, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 125, DateTimeKind.Local).AddTicks(3096), "Gece Vardiyasi", new TimeSpan(0, 0, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "EmployeeType",
                columns: new[] { "Id", "CreatedDate", "DepartmentId", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4025), 1, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4028), "Ön Büro Müdürü" },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4031), 1, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4032), "Gece Müdürü" },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4033), 1, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4033), "Ön Büro Şefi" },
                    { 4, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4034), 1, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4035), "Resepsiyonist" },
                    { 5, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4036), 1, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4036), "Concierge Şefi" },
                    { 6, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4037), 1, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4038), "Taşıyıcı/Karşılayıcı Personel" },
                    { 7, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4048), 1, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4049), "Guest Service Agent" },
                    { 8, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4049), 1, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4050), "Guest Relation" },
                    { 9, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4051), 2, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4051), "HK Müdürü" },
                    { 10, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4052), 2, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4052), "Housekeeper" },
                    { 11, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4053), 2, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4053), "Kat Şefi (Floor Supervisor)" },
                    { 12, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4054), 2, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4054), "Oda Görevlisi" },
                    { 13, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4055), 2, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4056), "Meydancı" },
                    { 14, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4056), 3, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4057), "Yiyecek – İçecek Müdürü" },
                    { 15, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4058), 3, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4058), "Barlar Şefi" },
                    { 16, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4060), 3, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4060), "Bar Personeli" },
                    { 17, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4061), 3, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4062), "Mutfak Şefi" },
                    { 18, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4062), 3, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4063), "Mutfak Personeli" },
                    { 19, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4064), 3, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4064), "Restoran Şefi" },
                    { 20, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4066), 3, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4066), "Servis Personeli" },
                    { 21, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4067), 4, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4068), "Teknik Müdür" },
                    { 22, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4069), 4, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4069), "Elektrik Tekniker" },
                    { 23, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4147), 4, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4147), "Mekanik Tekniker" },
                    { 24, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4148), 4, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4149), "Tesisatçı" },
                    { 25, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4150), 5, true, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(4150), "Masör" }
                });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CreatedDate", "Description", "DiscountPrice", "FoodMenuCategoryId", "IsActive", "IsAvailable", "IsDeleted", "IsOnPromotion", "ModifyDate", "Name", "PREPARATIONTIME", "Price", "PriceStatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(5793), "New York Pizzası", null, 1, true, false, false, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(5796), "New York", new TimeOnly(0, 0, 0), 150m, 1 },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(5801), "Kral Checkin", null, 2, true, false, false, false, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(5801), "Kral Checkin", new TimeOnly(0, 0, 0), 200m, 1 }
                });

            migrationBuilder.InsertData(
                table: "GuestStays",
                columns: new[] { "Id", "AccommodationConceptType", "ActualCheckInAt", "ActualCheckOutAt", "Channel", "CheckInDate", "CheckOutDate", "CreatedDate", "CurrencyCode", "DeviceToken", "GuestLanguageCode", "HotelId", "IsActive", "IsDeleted", "IsMobileAccessEnabled", "ModifyDate", "PrimaryCustomerId", "ReservationNo", "RoomId", "Status", "VerificationCode" },
                values: new object[] { 1, 1, null, null, null, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(7843), new DateTime(2026, 5, 19, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(7847), new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(8138), "TRY", null, "tr-TR", 1, true, false, false, new DateTime(2026, 5, 17, 6, 37, 45, 121, DateTimeKind.Local).AddTicks(8139), null, null, 1, "Active", "1d2ce6b0-3a52-4bb1-befe-5ab9ea4435d8" });

            migrationBuilder.InsertData(
                table: "ServiceDefinitions",
                columns: new[] { "Id", "CreatedDate", "CurrencyCode", "DepartmentId", "Description", "DisplayOrder", "EstimatedDurationMinutes", "HotelId", "ImageUrl", "IsActive", "IsChargeable", "IsDeleted", "IsVisibleToGuest", "ModifyDate", "Name", "OpeningMessage", "Price", "RequiresAppointment", "ServiceCategoryId", "ServiceType", "SupportsFreeText" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5322), "TRY", 4, "Klima ile ariza durumlari", 1, 60, 1, "1.jpeg", true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5327), "Klima", null, 0m, false, 2, 2, true },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5353), "TRY", 4, "TV ile ariza durumlari", 2, 45, 1, "1.jpeg", true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5354), "TV", null, 0m, false, 2, 2, true },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5357), "TRY", 4, "Minibar ile ariza durumlari", 3, 45, 1, "1.jpeg", true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5358), "Minibar", null, 0m, false, 2, 2, true },
                    { 4, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5361), "TRY", 4, "Kapi ile ariza durumlari", 4, 40, 1, "1.jpeg", true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5362), "Kapi", null, 0m, false, 2, 2, true },
                    { 5, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5490), "TRY", 4, "Elektrik ile ariza durumlari", 5, 30, 1, "1.jpeg", true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5491), "Elektrik", null, 0m, false, 2, 2, true },
                    { 6, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5495), "TRY", 4, "Aydinlatma ile ariza durumlari", 6, 30, 1, "1.jpeg", true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5495), "Aydinlatma", null, 0m, false, 2, 2, true },
                    { 7, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5499), "TRY", 4, "Dus ve tuvalet ile ariza durumlari", 7, 45, 1, "1.jpeg", true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5499), "Dus ve Tuvalet", null, 0m, false, 2, 2, true },
                    { 101, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5503), "TRY", 2, null, 1, 15, 1, "1.jpeg", true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5503), "Havlu degisimi veya eksigi", null, 0m, false, 1, 6, true },
                    { 102, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5506), "TRY", 2, null, 2, 45, 1, "1.jpeg", true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5507), "Oda genel temizlik", null, 0m, false, 1, 6, true },
                    { 103, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5510), "TRY", 2, null, 3, 20, 1, "", true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5510), "Carsaf veya yatak yuzu degisimi", null, 0m, false, 1, 6, true },
                    { 201, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5513), "TRY", 1, "Misafirin bagaj tasima talebi icin kullanilir.", 1, 10, 1, "1.jpeg", true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5514), "Bagaj Tasima", null, 0m, false, 3, 3, false },
                    { 301, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5517), "TRY", 2, "Utu hizmeti", 1, null, 1, "1.jpeg", true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5517), "Utu", null, 0m, false, 4, 5, false },
                    { 302, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5523), "TRY", 2, "T-Shirt", 2, null, 1, "1.jpeg", true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5523), "T-Shirt", null, 150m, false, 4, 5, false },
                    { 303, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5526), "TRY", 2, "Kaban-Mont", 3, null, 1, "1.jpeg", true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5527), "Kaban-Mont", null, 250m, false, 4, 5, false },
                    { 304, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5530), "TRY", 2, "Kuru temizleme", 4, null, 1, "1.jpeg", true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5530), "Kuru Temizleme", null, 0m, false, 4, 5, false },
                    { 305, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5534), "TRY", 2, "T-Shirt", 5, null, 1, "1.jpeg", true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5535), "T-Shirt Kuru Temizleme", null, 150m, false, 4, 5, false },
                    { 306, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5538), "TRY", 2, "Kaban-Mont", 6, null, 1, "1.jpeg", true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5539), "Kaban-Mont Kuru Temizleme", null, 200m, false, 4, 5, false },
                    { 307, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5542), "TRY", 2, "Kot-kumas pantolonlar", 7, null, 1, "1.jpeg", true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5542), "Pantolon", null, 200m, false, 4, 5, false },
                    { 401, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5545), "TRY", 5, "Uzak Dogu masaji", 1, 60, 1, null, true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5546), "Uzak Dogu", null, 200m, true, 5, 7, false },
                    { 402, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5549), "TRY", 5, "Tayland masaji", 2, 60, 1, null, true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5549), "Tayland Masaji", null, 200m, true, 5, 7, false },
                    { 501, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5552), "TRY", 1, "Misafir transfer veya ulasim talebi", 1, null, 1, null, true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5553), "Transfer Talebi", null, 0m, true, 6, 9, false },
                    { 502, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5556), "TRY", 1, "Arac teslim alma veya hazirlama talebi", 2, null, 1, null, true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5556), "Vale Hizmeti", null, 0m, false, 6, 12, false },
                    { 601, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5559), "TRY", 2, "Minibar urun talebi", 1, null, 1, null, true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5559), "Minibar Talebi", null, 0m, false, 7, 10, false },
                    { 602, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5562), "TRY", 1, "Belirlenen saatte uyandirma talebi", 4, null, 1, null, true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5563), "Uyandirma Servisi", null, 0m, true, 1, 11, false },
                    { 603, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5566), "TRY", 1, "Gec cikis veya konaklama uzatma talebi", 3, null, 1, null, true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5566), "Konaklama Uzatma", null, 0m, true, 3, 13, false },
                    { 604, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5569), "TRY", 2, "Ek yastik, bebek yatagi veya benzeri oda malzemeleri", 4, 20, 1, null, true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5570), "Oda Malzemesi Talebi", null, 0m, false, 1, 14, true },
                    { 605, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5572), "TRY", 5, "Saglik personeli veya doktor destegi", 3, null, 1, null, true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5573), "Medikal Yardim", null, 0m, true, 5, 15, true },
                    { 606, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5576), "TRY", 5, "Saglik ve guvenlik bildirimi", 4, null, 1, null, true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5576), "Saglik ve Guvenlik", null, 0m, false, 5, 8, true },
                    { 607, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5579), "TRY", null, "Otel etkinlik ve duyuru bilgilendirmeleri", 1, null, 1, "1.jpeg", true, false, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5580), "Otel Bilgilendirme ve Duyuru", null, 0m, false, 8, 8, false },
                    { 608, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5582), "TRY", 3, "Yiyecek icecek menu siparisi", 1, 30, 1, null, true, true, false, true, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(5583), "Menu Siparisi", null, 0m, false, 7, 1, false }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "AverageRating", "CreatedDate", "EmployeeCode", "EmployeeTypeId", "HireType", "HotelId", "ImageUrl", "IsActive", "IsAvailableForTask", "IsDeleted", "LanguageCodes", "LastAssignedAt", "ModifyDate", "Name", "ShiftId", "Status", "Surname", "UserId" },
                values: new object[,]
                {
                    { 1, 0m, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(390), null, 20, null, 1, "1.jpeg", true, true, false, null, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(397), "Ahmet", null, true, "Alan", 2 },
                    { 2, 0m, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(408), null, 20, null, 1, "1.jpeg", true, true, false, null, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(409), "Emre", null, true, "Alan", 3 },
                    { 3, 0m, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(423), null, 6, null, 1, "1.jpeg", true, true, false, null, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(423), "Yunus", null, true, "Yavaş", 4 },
                    { 4, 0m, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(428), null, 22, null, 1, "1.jpeg", true, true, false, null, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(428), "Fatih", null, true, "Hızlı", 5 },
                    { 5, 0m, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(514), null, 25, null, 1, "1.jpeg", true, true, false, null, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(526), "Mehmet", null, true, "Şiveli", 6 }
                });

            migrationBuilder.InsertData(
                table: "FoodContentsOfFood",
                columns: new[] { "ContentsOfFoodId", "FoodId", "IsActive" },
                values: new object[,]
                {
                    { 1, 1, false },
                    { 2, 1, false },
                    { 3, 1, false },
                    { 3, 2, false }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CurrencyCode", "DiscountAmount", "GuestStayId", "IsActive", "IsDeleted", "IsPostedToRoom", "ModifyDate", "NetAmount", "OrderNumber", "PaidAmount", "PaymentOption", "PaymentStatus", "PostedToRoomAt", "PriceStatusId", "ServiceChargeAmount", "ServiceRequestId", "TaxAmount", "TotalPrice" },
                values: new object[] { 1, new DateTime(2026, 5, 17, 6, 37, 45, 122, DateTimeKind.Local).AddTicks(9662), "TRY", 0m, 1, true, false, false, new DateTime(2026, 5, 17, 6, 37, 45, 122, DateTimeKind.Local).AddTicks(9673), 0m, "", 0m, 2, 1, null, 0, 0m, null, 0m, 200m });

            migrationBuilder.InsertData(
                table: "ServiceDefinitionFields",
                columns: new[] { "Id", "CreatedDate", "DefaultValue", "DisplayOrder", "FieldKey", "FieldType", "IsActive", "IsDeleted", "IsRequired", "Label", "ModifyDate", "OptionsJson", "Placeholder", "ServiceDefinitionId", "ValidationRegex" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7723), null, 1, "issueDescription", 2, true, false, true, "Ariza aciklamasi", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7726), null, null, 1, null },
                    { 2, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7732), null, 2, "photo", 11, true, false, false, "Fotograf", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7732), null, null, 1, null },
                    { 3, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7740), null, 1, "issueDescription", 2, true, false, true, "Ariza aciklamasi", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7741), null, null, 2, null },
                    { 4, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7742), null, 2, "photo", 11, true, false, false, "Fotograf", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7744), null, null, 2, null },
                    { 5, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7746), null, 1, "issueDescription", 2, true, false, true, "Ariza aciklamasi", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7747), null, null, 3, null },
                    { 6, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7749), null, 2, "photo", 11, true, false, false, "Fotograf", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7750), null, null, 3, null },
                    { 7, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7756), null, 1, "issueDescription", 2, true, false, true, "Ariza aciklamasi", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7756), null, null, 4, null },
                    { 8, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7759), null, 2, "photo", 11, true, false, false, "Fotograf", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7760), null, null, 4, null },
                    { 9, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7762), null, 1, "issueDescription", 2, true, false, true, "Ariza aciklamasi", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7763), null, null, 5, null },
                    { 10, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7765), null, 2, "photo", 11, true, false, false, "Fotograf", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7766), null, null, 5, null },
                    { 11, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7769), null, 1, "issueDescription", 2, true, false, true, "Ariza aciklamasi", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7774), null, null, 6, null },
                    { 12, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7775), null, 2, "photo", 11, true, false, false, "Fotograf", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7776), null, null, 6, null },
                    { 13, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7778), null, 1, "issueDescription", 2, true, false, true, "Ariza aciklamasi", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7780), null, null, 7, null },
                    { 14, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7781), null, 2, "photo", 11, true, false, false, "Fotograf", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7782), null, null, 7, null },
                    { 15, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7785), null, 1, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7785), null, null, 101, null },
                    { 16, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7787), null, 1, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7788), null, null, 102, null },
                    { 17, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7790), null, 1, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7791), null, null, 103, null },
                    { 18, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7794), null, 1, "luggageCount", 3, true, false, false, "Bagaj adedi", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7795), null, null, 201, null },
                    { 19, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7797), null, 2, "pickupLocation", 1, true, false, false, "Alinacak konum", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7798), null, null, 201, null },
                    { 20, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7799), null, 3, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7800), null, null, 201, null },
                    { 21, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7803), null, 1, "quantity", 3, true, false, false, "Adet", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7804), null, null, 301, null },
                    { 22, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7806), null, 2, "pickupTime", 8, true, false, false, "Teslim alinma saati", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7806), null, null, 301, null },
                    { 23, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7808), null, 3, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7808), null, null, 301, null },
                    { 24, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7811), null, 1, "quantity", 3, true, false, false, "Adet", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7812), null, null, 302, null },
                    { 25, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7813), null, 2, "pickupTime", 8, true, false, false, "Teslim alinma saati", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7814), null, null, 302, null },
                    { 26, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7815), null, 3, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7816), null, null, 302, null },
                    { 27, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7818), null, 1, "quantity", 3, true, false, false, "Adet", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7819), null, null, 303, null },
                    { 28, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7820), null, 2, "pickupTime", 8, true, false, false, "Teslim alinma saati", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7821), null, null, 303, null },
                    { 29, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7888), null, 3, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7889), null, null, 303, null },
                    { 30, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7892), null, 1, "quantity", 3, true, false, false, "Adet", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7892), null, null, 304, null },
                    { 31, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7894), null, 2, "pickupTime", 8, true, false, false, "Teslim alinma saati", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7894), null, null, 304, null },
                    { 32, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7896), null, 3, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7897), null, null, 304, null },
                    { 33, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7899), null, 1, "quantity", 3, true, false, false, "Adet", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7899), null, null, 305, null },
                    { 34, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7901), null, 2, "pickupTime", 8, true, false, false, "Teslim alinma saati", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7901), null, null, 305, null },
                    { 35, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7903), null, 3, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7903), null, null, 305, null },
                    { 36, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7907), null, 1, "quantity", 3, true, false, false, "Adet", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7908), null, null, 306, null },
                    { 37, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7909), null, 2, "pickupTime", 8, true, false, false, "Teslim alinma saati", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7910), null, null, 306, null },
                    { 38, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7911), null, 3, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7912), null, null, 306, null },
                    { 39, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7914), null, 1, "quantity", 3, true, false, false, "Adet", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7914), null, null, 307, null },
                    { 40, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7916), null, 2, "pickupTime", 8, true, false, false, "Teslim alinma saati", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7916), null, null, 307, null },
                    { 41, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7918), null, 3, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7918), null, null, 307, null },
                    { 42, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7962), null, 1, "appointmentTime", 8, true, false, true, "Randevu zamani", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7962), null, null, 401, null },
                    { 43, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7964), null, 2, "therapistPreference", 1, true, false, false, "Terapist tercihi", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7964), null, null, 401, null },
                    { 44, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7966), null, 3, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7966), null, null, 401, null },
                    { 45, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7969), null, 1, "appointmentTime", 8, true, false, true, "Randevu zamani", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7970), null, null, 402, null },
                    { 46, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7971), null, 2, "therapistPreference", 1, true, false, false, "Terapist tercihi", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7972), null, null, 402, null },
                    { 47, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7973), null, 3, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7973), null, null, 402, null },
                    { 48, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7976), null, 1, "pickupLocation", 1, true, false, true, "Nereden", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7976), null, null, 501, null },
                    { 49, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7978), null, 2, "destination", 1, true, false, true, "Nereye", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7978), null, null, 501, null },
                    { 50, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7980), null, 3, "passengerCount", 3, true, false, false, "Kisi sayisi", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7980), null, null, 501, null },
                    { 51, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7982), null, 4, "requestedAt", 8, true, false, true, "Talep edilen zaman", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(7982), null, null, 501, null },
                    { 52, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8009), null, 5, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8009), null, null, 501, null },
                    { 53, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8012), null, 1, "plateNumber", 1, true, false, true, "Plaka", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8012), null, null, 502, null },
                    { 54, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8014), null, 2, "vehicleLocation", 1, true, false, false, "Arac konumu", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8014), null, null, 502, null },
                    { 55, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8016), null, 3, "requestedAt", 8, true, false, false, "Talep edilen zaman", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8017), null, null, 502, null },
                    { 56, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8019), null, 1, "items", 2, true, false, true, "Urunler", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8019), null, null, 601, null },
                    { 57, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8021), null, 2, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8021), null, null, 601, null },
                    { 58, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8024), null, 1, "wakeUpTime", 8, true, false, true, "Uyandirma saati", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8024), null, null, 602, null },
                    { 59, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8025), null, 2, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8026), null, null, 602, null },
                    { 60, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8028), null, 1, "requestedCheckoutTime", 8, true, false, true, "Talep edilen cikis saati", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8029), null, null, 603, null },
                    { 61, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8030), null, 2, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8030), null, null, 603, null },
                    { 62, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8033), null, 1, "amenityType", 9, true, false, true, "Malzeme tipi", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8033), "[\"Ek yastik\",\"Bebek yatagi\",\"Battaniye\",\"Utu masasi\",\"Diger\"]", null, 604, null },
                    { 63, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8035), null, 2, "quantity", 3, true, false, false, "Adet", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8035), null, null, 604, null },
                    { 64, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8037), null, 3, "note", 2, true, false, false, "Not", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8037), null, null, 604, null },
                    { 65, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8039), null, 1, "symptoms", 2, true, false, true, "Belirti/aciklama", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8040), null, null, 605, null },
                    { 66, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8041), null, 2, "requiresDoctor", 5, true, false, false, "Doktor gerekli mi?", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8042), null, null, 605, null },
                    { 67, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8043), null, 3, "appointmentTime", 8, true, false, false, "Randevu zamani", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8044), null, null, 605, null },
                    { 68, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8097), null, 1, "incidentType", 9, true, false, true, "Bildirim tipi", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8097), "[\"Saglik\",\"Guvenlik\",\"Ilk yardim\",\"Diger\"]", null, 606, null },
                    { 69, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8099), null, 2, "description", 2, true, false, true, "Aciklama", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8100), null, null, 606, null },
                    { 70, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8101), null, 3, "photo", 11, true, false, false, "Fotograf", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8102), null, null, 606, null },
                    { 71, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8103), null, 1, "topic", 1, true, false, false, "Konu", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8104), null, null, 607, null },
                    { 72, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8105), null, 2, "question", 2, true, false, false, "Soru", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8106), null, null, 607, null },
                    { 73, new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8108), null, 1, "note", 2, true, false, false, "Siparis notu", new DateTime(2026, 5, 17, 6, 37, 45, 124, DateTimeKind.Local).AddTicks(8108), null, null, 608, null }
                });

            migrationBuilder.InsertData(
                table: "EmployeeDetail",
                columns: new[] { "Id", "Address", "CreatedDate", "DateOfBirth", "EmergencyContactName", "EmergencyContactPhone", "EmployeeId", "ExitDateOfWork", "FloorNo", "Gender", "IsActive", "IsDeleted", "LastOnlineTime", "ModifyDate", "NationalId", "OnlineOrOfflineNow", "PhoneNumber", "ProfileLanguage", "StartDateOfWork" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2358), new DateTime(1995, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, null, null, true, true, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2359), null, false, "+905363988981", null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2348) },
                    { 2, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2367), new DateTime(1995, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2, null, null, true, true, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2368), null, false, "+905363988982", null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2366) },
                    { 3, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2371), new DateTime(1995, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, null, null, true, true, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2371), null, false, "+905363988983", null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2370) },
                    { 4, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2374), new DateTime(1995, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 4, null, null, true, true, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2375), null, false, "+905363988984", null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2373) },
                    { 5, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2377), new DateTime(1995, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 5, null, null, true, true, false, null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2378), null, false, "+905363988985", null, new DateTime(2026, 5, 17, 6, 37, 45, 119, DateTimeKind.Local).AddTicks(2376) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_HotelId",
                table: "Announcements",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_DepartmentId",
                table: "AttendanceRecords",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_EmployeeId",
                table: "AttendanceRecords",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_HotelId",
                table: "AttendanceRecords",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_ShiftId",
                table: "AttendanceRecords",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_Charges_GuestStayId",
                table: "Charges",
                column: "GuestStayId");

            migrationBuilder.CreateIndex(
                name: "IX_Charges_OrderId",
                table: "Charges",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Charges_ServiceRequestId",
                table: "Charges",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentAndRatings_FoodId",
                table: "CommentAndRatings",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentAndRatings_OrderId",
                table: "CommentAndRatings",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentAndRatings_OrderItemId",
                table: "CommentAndRatings",
                column: "OrderItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConversationFlowSessions_ConversationId",
                table: "ConversationFlowSessions",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_ConversationFlowSessions_ServiceCategoryId",
                table: "ConversationFlowSessions",
                column: "ServiceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ConversationFlowSessions_ServiceDefinitionId",
                table: "ConversationFlowSessions",
                column: "ServiceDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ConversationMessages_ConversationId",
                table: "ConversationMessages",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_ConversationMessages_SenderCustomerId",
                table: "ConversationMessages",
                column: "SenderCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ConversationMessages_SenderUserId",
                table: "ConversationMessages",
                column: "SenderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_CustomerId",
                table: "Conversations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_GuestStayId",
                table: "Conversations",
                column: "GuestStayId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_HotelId",
                table: "Conversations",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_GuestStayId",
                table: "Customers",
                column: "GuestStayId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_HotelId",
                table: "Department",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeTypeId",
                table: "Employee",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_HotelId",
                table: "Employee",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ShiftId",
                table: "Employee",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserId",
                table: "Employee",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetail_EmployeeId",
                table: "EmployeeDetail",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDocuments_EmployeeId",
                table: "EmployeeDocuments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDocuments_HotelId",
                table: "EmployeeDocuments",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDocuments_VerifiedByEmployeeId",
                table: "EmployeeDocuments",
                column: "VerifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTasks_AssignedByEmployeeId",
                table: "EmployeeTasks",
                column: "AssignedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTasks_AssignedEmployeeId",
                table: "EmployeeTasks",
                column: "AssignedEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTasks_DepartmentId",
                table: "EmployeeTasks",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTasks_HotelId",
                table: "EmployeeTasks",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTasks_RelatedServiceRequestId",
                table: "EmployeeTasks",
                column: "RelatedServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeType_DepartmentId",
                table: "EmployeeType",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Food_FoodMenuCategoryId",
                table: "Food",
                column: "FoodMenuCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAllergen_AllergenId",
                table: "FoodAllergen",
                column: "AllergenId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodContentsOfFood_ContentsOfFoodId",
                table: "FoodContentsOfFood",
                column: "ContentsOfFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodDietaryRestrictions_DietaryRestrictionId",
                table: "FoodDietaryRestrictions",
                column: "DietaryRestrictionId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodMenuCategory_HotelId",
                table: "FoodMenuCategory",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestSessions_CustomerId",
                table: "GuestSessions",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestSessions_GuestStayId",
                table: "GuestSessions",
                column: "GuestStayId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestStays_RoomId",
                table: "GuestStays",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_Companyid",
                table: "Hotel",
                column: "Companyid");

            migrationBuilder.CreateIndex(
                name: "IX_HotelServicePolicies_HotelId",
                table: "HotelServicePolicies",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelServicePolicies_ServiceDefinitionId",
                table: "HotelServicePolicies",
                column: "ServiceDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_FoodId",
                table: "Image",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ImageCategoryId",
                table: "Image",
                column: "ImageCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_OrderItemId",
                table: "Image",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageCategory_HotelId",
                table: "ImageCategory",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalAnnouncements_CreatedByEmployeeId",
                table: "InternalAnnouncements",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalAnnouncements_DepartmentId",
                table: "InternalAnnouncements",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalAnnouncements_HotelId",
                table: "InternalAnnouncements",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_DepartmentId",
                table: "LeaveRequests",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_EmployeeId",
                table: "LeaveRequests",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_HotelId",
                table: "LeaveRequests",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_HrEmployeeId",
                table: "LeaveRequests",
                column: "HrEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_ManagerEmployeeId",
                table: "LeaveRequests",
                column: "ManagerEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionalInfo_FoodId",
                table: "NutritionalInfo",
                column: "FoodId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_GuestStayId",
                table: "Orders",
                column: "GuestStayId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ServiceRequestId",
                table: "Orders",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransactions_ChargeId",
                table: "PaymentTransactions",
                column: "ChargeId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceReviews_DepartmentId",
                table: "PerformanceReviews",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceReviews_EmployeeId",
                table: "PerformanceReviews",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceReviews_HotelId",
                table: "PerformanceReviews",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceReviews_ReviewerEmployeeId",
                table: "PerformanceReviews",
                column: "ReviewerEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_HotelId",
                table: "Room",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomFoodTypeId",
                table: "Room",
                column: "RoomFoodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomTypeId",
                table: "Room",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCategories_HotelId",
                table: "ServiceCategories",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDefinitionFields_ServiceDefinitionId_FieldKey",
                table: "ServiceDefinitionFields",
                columns: new[] { "ServiceDefinitionId", "FieldKey" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDefinitions_DepartmentId",
                table: "ServiceDefinitions",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDefinitions_HotelId",
                table: "ServiceDefinitions",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDefinitions_ServiceCategoryId",
                table: "ServiceDefinitions",
                column: "ServiceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequestFieldValues_ServiceDefinitionFieldId",
                table: "ServiceRequestFieldValues",
                column: "ServiceDefinitionFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequestFieldValues_ServiceRequestId",
                table: "ServiceRequestFieldValues",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequestHistories_ChangedByUserId",
                table: "ServiceRequestHistories",
                column: "ChangedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequestHistories_ServiceRequestId",
                table: "ServiceRequestHistories",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequestItems_ServiceDefinitionId",
                table: "ServiceRequestItems",
                column: "ServiceDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequestItems_ServiceRequestId",
                table: "ServiceRequestItems",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequestMessages_SenderUserId",
                table: "ServiceRequestMessages",
                column: "SenderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequestMessages_ServiceRequestId",
                table: "ServiceRequestMessages",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequestRatings_CustomerId",
                table: "ServiceRequestRatings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequestRatings_ServiceRequestId",
                table: "ServiceRequestRatings",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_AssignedEmployeeId",
                table: "ServiceRequests",
                column: "AssignedEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_ConversationId",
                table: "ServiceRequests",
                column: "ConversationId",
                unique: true,
                filter: "[ConversationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_CustomerId",
                table: "ServiceRequests",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_DepartmentId",
                table: "ServiceRequests",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_GuestStayId",
                table: "ServiceRequests",
                column: "GuestStayId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_HotelId",
                table: "ServiceRequests",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_RoomId",
                table: "ServiceRequests",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_ServiceDefinitionId",
                table: "ServiceRequests",
                column: "ServiceDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Shift_HotelId",
                table: "Shift",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_StockItems_DepartmentId",
                table: "StockItems",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_StockItems_HotelId",
                table: "StockItems",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_DepartmentId",
                table: "StockMovements",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_EmployeeId",
                table: "StockMovements",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_HotelId",
                table: "StockMovements",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_StockItemId",
                table: "StockMovements",
                column: "StockItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StockRequestItems_StockItemId",
                table: "StockRequestItems",
                column: "StockItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StockRequestItems_StockRequestId",
                table: "StockRequestItems",
                column: "StockRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_StockRequests_AssignedManagerEmployeeId",
                table: "StockRequests",
                column: "AssignedManagerEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_StockRequests_DepartmentId",
                table: "StockRequests",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_StockRequests_HotelId",
                table: "StockRequests",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_StockRequests_RelatedServiceRequestId",
                table: "StockRequests",
                column: "RelatedServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_StockRequests_RequestedByEmployeeId",
                table: "StockRequests",
                column: "RequestedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemParametreValues_SystemParametreId",
                table: "SystemParametreValues",
                column: "SystemParametreId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmenityRequestServices");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "AttendanceRecords");

            migrationBuilder.DropTable(
                name: "BellBoy");

            migrationBuilder.DropTable(
                name: "CommentAndRatings");

            migrationBuilder.DropTable(
                name: "Connection");

            migrationBuilder.DropTable(
                name: "ConversationFlowSessions");

            migrationBuilder.DropTable(
                name: "ConversationMessages");

            migrationBuilder.DropTable(
                name: "DryCleaner");

            migrationBuilder.DropTable(
                name: "EmployeeDetail");

            migrationBuilder.DropTable(
                name: "EmployeeDocuments");

            migrationBuilder.DropTable(
                name: "EmployeeTasks");

            migrationBuilder.DropTable(
                name: "FeedBackAndSurveys");

            migrationBuilder.DropTable(
                name: "FoodAllergen");

            migrationBuilder.DropTable(
                name: "FoodContentsOfFood");

            migrationBuilder.DropTable(
                name: "FoodDietaryRestrictions");

            migrationBuilder.DropTable(
                name: "GuestSessions");

            migrationBuilder.DropTable(
                name: "HealthAndSafety");

            migrationBuilder.DropTable(
                name: "HotelInformationAndAnnouncements");

            migrationBuilder.DropTable(
                name: "HotelServicePolicies");

            migrationBuilder.DropTable(
                name: "HouseKeeping");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "InternalAnnouncements");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "MedicalAssistanceServices");

            migrationBuilder.DropTable(
                name: "MinibarServices");

            migrationBuilder.DropTable(
                name: "NutritionalInfo");

            migrationBuilder.DropTable(
                name: "PaymentTransactions");

            migrationBuilder.DropTable(
                name: "PerformanceReviews");

            migrationBuilder.DropTable(
                name: "ServiceRequestFieldValues");

            migrationBuilder.DropTable(
                name: "ServiceRequestHistories");

            migrationBuilder.DropTable(
                name: "ServiceRequestItems");

            migrationBuilder.DropTable(
                name: "ServiceRequestMessages");

            migrationBuilder.DropTable(
                name: "ServiceRequestRatings");

            migrationBuilder.DropTable(
                name: "ServiceRoleAssignment");

            migrationBuilder.DropTable(
                name: "SpaMassage");

            migrationBuilder.DropTable(
                name: "StayExtensionServices");

            migrationBuilder.DropTable(
                name: "StockMovements");

            migrationBuilder.DropTable(
                name: "StockRequestItems");

            migrationBuilder.DropTable(
                name: "SystemParametreValues");

            migrationBuilder.DropTable(
                name: "TechnicalNeed");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "TravelOrTransportation");

            migrationBuilder.DropTable(
                name: "ValetParkingServices");

            migrationBuilder.DropTable(
                name: "ValidationMessages");

            migrationBuilder.DropTable(
                name: "WakeUpCallServices");

            migrationBuilder.DropTable(
                name: "Allergen");

            migrationBuilder.DropTable(
                name: "ContentsOfFood");

            migrationBuilder.DropTable(
                name: "DietaryRestriction");

            migrationBuilder.DropTable(
                name: "ImageCategory");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Charges");

            migrationBuilder.DropTable(
                name: "ServiceDefinitionFields");

            migrationBuilder.DropTable(
                name: "StockItems");

            migrationBuilder.DropTable(
                name: "StockRequests");

            migrationBuilder.DropTable(
                name: "SystemParameter");

            migrationBuilder.DropTable(
                name: "FoodMenuCategory");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ServiceRequests");

            migrationBuilder.DropTable(
                name: "Conversations");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "ServiceDefinitions");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "EmployeeType");

            migrationBuilder.DropTable(
                name: "Shift");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ServiceCategories");

            migrationBuilder.DropTable(
                name: "GuestStays");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "FoodType");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "RoomType");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
