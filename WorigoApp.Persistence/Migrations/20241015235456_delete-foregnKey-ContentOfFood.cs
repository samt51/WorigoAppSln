using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class deleteforegnKeyContentOfFood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentsOfFood_Food_FoodId",
                table: "ContentsOfFood");

            migrationBuilder.DropIndex(
                name: "IX_ContentsOfFood_FoodId",
                table: "ContentsOfFood");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "ContentsOfFood");

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(36), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(53), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(4699), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(1394), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(1400), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(1401), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(1402), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(1402), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2274), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2278), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2279), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2280), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2281), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2282), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2282), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2283), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2284), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2285), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2286), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2286), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2287), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2288), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2289), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2290), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2290), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2291), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2292), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2293), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2293), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2294), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2295), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2296), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2297), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(3036), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(3039), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(3040), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(3041), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(7803), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(7809), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(7810), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(4577), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(4585), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(4586), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(4587), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(4588), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(4589), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5375), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5378), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5379), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5380), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5380), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5382), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5383), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5383), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5384), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5385), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5386), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(8540), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(8547), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(9305), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(9309), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(9310), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(9311), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(9312), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(9313), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(9314), new DateTime(2024, 10, 16, 2, 54, 55, 675, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 10, 16, 2, 54, 55, 676, DateTimeKind.Local).AddTicks(6731) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodId",
                table: "ContentsOfFood",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(1559), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(7012), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(7031), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(2835), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(8152), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(8156), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(8157), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(8158), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(8159), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9162), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9167), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9168), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9169), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9171), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9172), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9173), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9174), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9175), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9176), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9177), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9181), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9181), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9182), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9183), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9184), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9185), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9186), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9187), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9188), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9189), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 10, 16, 2, 19, 6, 777, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(441), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(448), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(450), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(451), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(453), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8998), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(6444), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(6449), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(6450), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(2952), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(2957), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(2958), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(2958), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(2959), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(2960), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(2961), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3705), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3707), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3708), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3709), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3710), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3711), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3713), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3714), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3715), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3716), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3717), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(7215), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8275), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8280), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8280), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8281), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8282), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8283), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8284), new DateTime(2024, 10, 16, 2, 19, 6, 778, DateTimeKind.Local).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(4999), new DateTime(2024, 10, 16, 2, 19, 6, 779, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.CreateIndex(
                name: "IX_ContentsOfFood_FoodId",
                table: "ContentsOfFood",
                column: "FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContentsOfFood_Food_FoodId",
                table: "ContentsOfFood",
                column: "FoodId",
                principalTable: "Food",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
