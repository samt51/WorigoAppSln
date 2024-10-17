using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class removeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "FoodContentsOfFood");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IsActive",
                table: "FoodContentsOfFood",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(5002), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 374, DateTimeKind.Local).AddTicks(9987), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(11), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(6013), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(1262), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(1267), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(1267), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(1269), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(1270), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2323), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2327), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2328), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2329), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2330), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2331), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2332), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2333), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2334), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2335), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2336), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2337), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2337), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2338), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2340), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2341), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2341), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2342), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2343), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2344), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2345), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2346), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2346), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2347), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(3187), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(3823), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(3828), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(3829), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(3830), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(1677), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(9220), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(9221), new DateTime(2024, 10, 16, 2, 59, 16, 375, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(5299), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(5306), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(5307), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(5308), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(5308), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(5309), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(5310), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6216), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6218), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6220), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6222), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6223), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6224), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6226), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6227), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6228), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(129), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(135), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(869), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(875), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(876), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(877), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(878), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(878), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(7553), new DateTime(2024, 10, 16, 2, 59, 16, 376, DateTimeKind.Local).AddTicks(7555) });
        }
    }
}
