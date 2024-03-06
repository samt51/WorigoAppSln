using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitilazionMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfStar = table.Column<int>(type: "int", nullable: false),
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
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    RoomFoodTypeId = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
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
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodMenuCategoryId = table.Column<int>(type: "int", nullable: false),
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
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_ImageCategory_ImageCategoryId",
                        column: x => x.ImageCategoryId,
                        principalTable: "ImageCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceOfFeature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOfFeature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceOfFeature_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ContentsOfFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentsOfFood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContentsOfFood_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceOfValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceOfFeatureId = table.Column<int>(type: "int", nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOfValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceOfValue_ServiceOfFeature_ServiceOfFeatureId",
                        column: x => x.ServiceOfFeatureId,
                        principalTable: "ServiceOfFeature",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceOfValue_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FloorNo = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    StartDateOfWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExitDateOfWork = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastOnlineTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OnlineOrOfflineNow = table.Column<bool>(type: "bit", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(6084), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(6099), "Worigo" },
                    { 2, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(6102), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(6102), "Ramada" }
                });

            migrationBuilder.InsertData(
                table: "FoodType",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "RoomFoodTypeEnum" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8033), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8035), 1 },
                    { 2, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8036), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8036), 2 },
                    { 3, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8037), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8037), 3 },
                    { 4, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8038), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8038), 4 },
                    { 5, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8039), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8039), 5 }
                });

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "RoomTypeEnum" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9432), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9433), 1 },
                    { 2, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9434), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9435), 2 },
                    { 3, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9435), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9436), 3 },
                    { 4, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9436), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9437), 4 },
                    { 5, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9437), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9437), 5 },
                    { 6, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9438), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9438), 6 },
                    { 7, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9439), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9439), 7 },
                    { 8, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9440), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9440), 8 },
                    { 9, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9441), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9441), 9 },
                    { 10, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9442), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9442), 10 },
                    { 11, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9443), true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9443), 11 }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Adress", "Companyid", "CreatedDate", "Email", "IsActive", "IsDeleted", "Location", "ModifyDate", "Name", "NumberOfStar", "PhoneNumber" },
                values: new object[] { 1, "Bağcılar", 2, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8768), "tekstilkent@ramada.com", true, false, "Giyimkent", new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8769), "Tekstilkent", 4, "02126733520" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "CreatedDate", "HotelId", "ImageUrl", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7184), 1, "1.jpeg", true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7186), "Ön Büro Resepsiyon Departmanı" },
                    { 2, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7188), 1, "1.jpeg", true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7188), "Housekeeping Departmanı" },
                    { 3, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7189), 1, "1.jpeg", true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7189), "Yiyecek İçecek ve Mutfak Departmanı" },
                    { 4, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7190), 1, "1.jpeg", true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7190), "Teknik Servis Departmanı" },
                    { 5, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7191), 1, "1.jpeg", true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7191), "İnsan Kaynakları Departmanı" },
                    { 6, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7191), 1, "1.jpeg", true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7192), "Muhasebe Departmanı" },
                    { 7, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7192), 1, "1.jpeg", true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7193), "Satınalma Departmanı" },
                    { 8, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7193), 1, "1.jpeg", true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7193), "Satış ve Pazarlama Departmanı" },
                    { 9, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7194), 1, "1.jpeg", true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7194), "Bilgi İşlem Departmanı " },
                    { 10, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7195), 1, "1.jpeg", true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7195), "Güvenlik Departmanı" },
                    { 11, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7196), 1, "1.jpeg", true, false, new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7196), "Sağlık Kulübü & Spa Departmanı" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContentsOfFood_FoodId",
                table: "ContentsOfFood",
                column: "FoodId");

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
                name: "IX_EmployeeDetail_EmployeeId",
                table: "EmployeeDetail",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeType_DepartmentId",
                table: "EmployeeType",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Food_FoodMenuCategoryId",
                table: "Food",
                column: "FoodMenuCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodMenuCategory_HotelId",
                table: "FoodMenuCategory",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_Companyid",
                table: "Hotel",
                column: "Companyid");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ImageCategoryId",
                table: "Image",
                column: "ImageCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageCategory_HotelId",
                table: "ImageCategory",
                column: "HotelId");

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
                name: "IX_Service_HotelId",
                table: "Service",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOfFeature_ServiceId",
                table: "ServiceOfFeature",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOfValue_ServiceId",
                table: "ServiceOfValue",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOfValue_ServiceOfFeatureId",
                table: "ServiceOfValue",
                column: "ServiceOfFeatureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentsOfFood");

            migrationBuilder.DropTable(
                name: "EmployeeDetail");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "ServiceOfValue");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "ImageCategory");

            migrationBuilder.DropTable(
                name: "FoodType");

            migrationBuilder.DropTable(
                name: "RoomType");

            migrationBuilder.DropTable(
                name: "ServiceOfFeature");

            migrationBuilder.DropTable(
                name: "FoodMenuCategory");

            migrationBuilder.DropTable(
                name: "EmployeeType");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
