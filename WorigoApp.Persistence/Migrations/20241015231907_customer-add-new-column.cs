using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class customeraddnewcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomBasedTransactionId",
                table: "Customers",
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
                name: "IX_Customers_RoomBasedTransactionId",
                table: "Customers",
                column: "RoomBasedTransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_RoomBasedTransaction_RoomBasedTransactionId",
                table: "Customers",
                column: "RoomBasedTransactionId",
                principalTable: "RoomBasedTransaction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_RoomBasedTransaction_RoomBasedTransactionId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_RoomBasedTransactionId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "RoomBasedTransactionId",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(9603), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(5528), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(5545), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(309), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(6727), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(6731), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(6732), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(6732), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(6733), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7899), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7903), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7904), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7905), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7906), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7906), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7907), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7909), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7910), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7910), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7911), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7912), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7913), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7914), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7915), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7915), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7916), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7917), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7918), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7918), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7919), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7920), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7922), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(8806), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(8809), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(8810), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(8811), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(8812), new DateTime(2024, 10, 16, 2, 16, 43, 545, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(5647), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(3433), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(3438), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(3439), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9931), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9938), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9939), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9940), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(685), new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(687), new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(688), new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(689), new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(691), new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(692), new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(693), new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(694), new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(695), new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(696), new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4108), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4111), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4923), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4929), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4930), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4931), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4932), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4933), new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(2019), new DateTime(2024, 10, 16, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(2021) });
        }
    }
}
