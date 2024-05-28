using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addserilog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7941), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(5792), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(5803), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8361), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6834), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6837), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6838), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6838), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6839), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6840), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6840), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6841), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6842), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6842), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6843), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7476), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7477), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7478), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7479), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(408), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8836), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8836), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3281), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3286), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3287), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3287), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3288), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3289), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3289), "Customer" });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3806), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3808), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3809), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3810), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3811), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3812), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3813), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3813), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3814), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3815), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3816), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(9220), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(9221), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(9998), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(1), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(2), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(4), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(4) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5016), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3014), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3029), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5449), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3983), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3986), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3987), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3988), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3990), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3990), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3991), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3992), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3992), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3993), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3994), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(4572), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(4574), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(4574), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(4575), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(4576), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7384), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5827), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5831), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(8303), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(8309), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(8310), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(8310), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(8359), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(8360), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(8361), "Reception" });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9094), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9096), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9097), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9097), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9098), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9099), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9100), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9101), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9102), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9102), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9103), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(6243), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(6246), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7018), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7022), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7023), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7023), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7024), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7025), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7026), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7026) });
        }
    }
}
