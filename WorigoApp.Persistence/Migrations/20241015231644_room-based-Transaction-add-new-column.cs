using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class roombasedTransactionaddnewcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomBasedTransaction_Customers_CustomerId",
                table: "RoomBasedTransaction");

            migrationBuilder.DropIndex(
                name: "IX_RoomBasedTransaction_CustomerId",
                table: "RoomBasedTransaction");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "RoomBasedTransaction");

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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[] { 7, new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9940), true, false, new DateTime(2024, 10, 16, 2, 16, 43, 546, DateTimeKind.Local).AddTicks(9940), "Resepsiyonist" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
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

            migrationBuilder.CreateIndex(
                name: "IX_RoomBasedTransaction_CustomerId",
                table: "RoomBasedTransaction",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomBasedTransaction_Customers_CustomerId",
                table: "RoomBasedTransaction",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
