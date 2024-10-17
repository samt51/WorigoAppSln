using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addnewcolumnrolebased : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "FoodContentsOfFood",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PriceStatusId",
                table: "Food",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(3037), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(4724), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(3953), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.InsertData(
                table: "ContentsOfFood",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(6117), true, false, new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(6121), "Siyah Zeytin" },
                    { 2, new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(6122), true, false, new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(6123), "Mantar" },
                    { 3, new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(6123), true, false, new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(6124), "Turşu" }
                });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(7285), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(7291), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(7292), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(7293), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(7294), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8433), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8439), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8440), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8441), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8443), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8444), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8445), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8446), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8446), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8447), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8448), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8449), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8451), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8452), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8453), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8453), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8454), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8455), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8456), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8457), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8458), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8459), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8460), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8460), new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.InsertData(
                table: "FoodMenuCategory",
                columns: new[] { "Id", "CreatedDate", "HotelId", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(1184), 1, true, false, new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(1186), "Pizza" },
                    { 2, new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(1188), 1, true, false, new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(1188), "Hamburger" }
                });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(2205), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(2208), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(2210), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(2211), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(2212), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(9560), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(7153), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(7207), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(7208), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(3405), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(3411), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(3412), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(3413), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(3414), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(3415), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(3416), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4245), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4248), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4249), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4288), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4289), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4291), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4292), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4293), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4294), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4295), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4296), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(7988), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(7992), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(8784), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(8788), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(8791), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(8792), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(8793), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(8794), new DateTime(2024, 10, 17, 12, 6, 51, 301, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(5609), new DateTime(2024, 10, 17, 12, 6, 51, 302, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CreatedDate", "Description", "FoodMenuCategoryId", "IsActive", "IsDeleted", "ModifyDate", "Name", "Price", "PriceStatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(9437), "New York Pizzası", 1, true, false, new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(9438), "New York", 150m, 1 },
                    { 2, new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(9443), "Kral Checkin", 2, true, false, new DateTime(2024, 10, 17, 12, 6, 51, 300, DateTimeKind.Local).AddTicks(9443), "Kral Checkin", 200m, 1 }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodContentsOfFood",
                keyColumns: new[] { "ContentsOfFoodId", "FoodId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "FoodContentsOfFood",
                keyColumns: new[] { "ContentsOfFoodId", "FoodId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "FoodContentsOfFood",
                keyColumns: new[] { "ContentsOfFoodId", "FoodId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "FoodContentsOfFood",
                keyColumns: new[] { "ContentsOfFoodId", "FoodId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodMenuCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodMenuCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "FoodContentsOfFood");

            migrationBuilder.DropColumn(
                name: "PriceStatusId",
                table: "Food");

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 196, DateTimeKind.Local).AddTicks(8220), new DateTime(2024, 10, 17, 11, 29, 13, 196, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(2434), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(2462), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 196, DateTimeKind.Local).AddTicks(9701), new DateTime(2024, 10, 17, 11, 29, 13, 196, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(4973), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(4987), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(4988), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(4989), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(4991), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6530), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6539), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6541), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6542), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6544), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6545), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6547), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6548), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6549), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6551), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6552), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6553), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6554), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6555), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6557), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6558), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6559), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6560), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6561), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6562), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6564), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6565), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6566), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6567), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6568), new DateTime(2024, 10, 17, 11, 29, 13, 194, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 196, DateTimeKind.Local).AddTicks(5621), new DateTime(2024, 10, 17, 11, 29, 13, 196, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 196, DateTimeKind.Local).AddTicks(5649), new DateTime(2024, 10, 17, 11, 29, 13, 196, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 196, DateTimeKind.Local).AddTicks(5650), new DateTime(2024, 10, 17, 11, 29, 13, 196, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 196, DateTimeKind.Local).AddTicks(5652), new DateTime(2024, 10, 17, 11, 29, 13, 196, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 196, DateTimeKind.Local).AddTicks(5654), new DateTime(2024, 10, 17, 11, 29, 13, 196, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(8461), new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(4705), new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(4715), new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(4716), new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(5531), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(5541), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(5542), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(5544), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(5545), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(5546), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(5547), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7192), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7198), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7200), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7202), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7204), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7205), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7207), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7208), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7212), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7213), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(6117), new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(6125), new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(7325), new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(7326), new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(7328), new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(7329), new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(7331), new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(7332), new DateTime(2024, 10, 17, 11, 29, 13, 197, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(9410), new DateTime(2024, 10, 17, 11, 29, 13, 198, DateTimeKind.Local).AddTicks(9414) });
        }
    }
}
