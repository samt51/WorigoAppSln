using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newcolumnroombasedTransactionHotelId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "RoomBasedTransaction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(4488), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(1001), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(1021), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(5324), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(2222), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(2227), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(2228), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(2229), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(2230), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3009), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3013), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3014), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3015), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3016), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3017), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3017), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3018), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3019), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3020), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3021), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3021), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3022), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3023), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3024), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3024), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3025), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3026), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3027), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3027), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3028), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3029), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3030), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3031), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3031), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3755), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3757), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3759), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3759), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3761), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(489), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(8354), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(8361), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(8362), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(4226), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(4232), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(4233), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(4234), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(4235), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(4236), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5010), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5012), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5014), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5014), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5015), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5016), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5017), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5018), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5019), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5020), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5021), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9120), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9124), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9818), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9822), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9823), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9824), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9825), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9826), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9827), new DateTime(2024, 10, 15, 3, 3, 7, 37, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 15, 3, 3, 7, 38, DateTimeKind.Local).AddTicks(6242) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "RoomBasedTransaction");

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(9770), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(5673), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(5697), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(726), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7150), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7155), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7156), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7157), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7158), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8036), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8040), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8041), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8042), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8043), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8044), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8045), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8046), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8046), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8047), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8048), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8049), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8050), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8051), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8052), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8052), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8053), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8054), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8055), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8056), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8057), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8058), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8059), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8060), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8060), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8917), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8920), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8921), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8922), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8923), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(6525), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(4040), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(4049), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(4050), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(713), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(720), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(720), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(721), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(722), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(723), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1571), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1573), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1574), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1576), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1577), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1577), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1578), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1579), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1580), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1581), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1582), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5041), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5046), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5781), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5785), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5786), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5787), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5788), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5788), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5789), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(6449), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(6455) });
        }
    }
}
