using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class localizationLanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesEnumId = table.Column<int>(type: "int", nullable: false),
                    ServiceItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderStatusEnum = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentAndRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentAndRatings_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentAndRatings_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(8395), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(4777), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(4794), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(8944), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(5971), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(5982), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(5983), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(5984), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(5985), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6697), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6699), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6700), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6701), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6702), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6703), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6704), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6705), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6706), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6706), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6707), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6708), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6709), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6709), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6710), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6711), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6712), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6712), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6713), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6714), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6714), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6715), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6716), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6716), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.InsertData(
                table: "EmployeeType",
                columns: new[] { "Id", "CreatedDate", "DepartmentId", "HotelId", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[] { 25, new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6717), 5, null, true, false, new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(6717), "Masör" });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(7705), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(7708), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(7709), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(7710), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(7711), new DateTime(2024, 5, 15, 9, 58, 6, 938, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1928), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(645), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(648), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(649), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5217), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5221), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5222), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5223), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5224), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5225), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5746), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5749), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5750), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5751), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5752), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5753), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5754), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5755), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5756), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5757), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5758), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "Price" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1102), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1103), 200m });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "Price" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1106), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1106), 200m });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1502), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1504), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1542), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1542), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1543), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1544), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1545), new DateTime(2024, 5, 15, 9, 58, 6, 939, DateTimeKind.Local).AddTicks(1545) });

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
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentAndRatings");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7876), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(5664), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(5677), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(8286), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(6494), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(6498), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(6498), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(6499), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(6500), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7071), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7072), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7073), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7074), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7076), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7076), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7077), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7079), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7079), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7080), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7082), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7082), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7083), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7083), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7085), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7085), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7086), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7520), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7521), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7522), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7523), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7524), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(685), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(9581), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(9583), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3240), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3252), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3253), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3254), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3254), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3291), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3873), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3875), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3876), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3877), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3878), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3879), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3879), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3880), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3881), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3881), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3882), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "Price" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(9988), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(9988), 0m });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "Price" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(9990), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(9991), 0m });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(309), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(312), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(312), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(341), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(341), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(342), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(343), new DateTime(2024, 5, 11, 17, 8, 41, 977, DateTimeKind.Local).AddTicks(343) });
        }
    }
}
