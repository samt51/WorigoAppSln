using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addnewservi2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(9988), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(9990), new DateTime(2024, 5, 11, 17, 8, 41, 976, DateTimeKind.Local).AddTicks(9991) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(2744), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(2756), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(8080), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(4562), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(4572), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(4573), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(4574), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(4575), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5679), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5683), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5684), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5685), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5686), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5686), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5687), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5688), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5688), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5689), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5690), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5690), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5691), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5691), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5692), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5693), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5693), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5694), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5695), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5695), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5696), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5697), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5697), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5698), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(7187), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(7189), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(7189), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(7190), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(971), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(9720), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(9724), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(9725), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3423), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3426), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3427), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3428), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3428), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3429), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3856), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3857), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3858), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3859), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3860), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3861), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3862), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3862), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3863), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3864), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3865), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(243), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(245), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(617), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(619), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(620), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(621), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(622), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(622), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(623), new DateTime(2024, 5, 11, 17, 4, 40, 843, DateTimeKind.Local).AddTicks(623) });
        }
    }
}
