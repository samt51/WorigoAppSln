using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CompleteDynamicServiceChatFlow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HomeDisplayOrder",
                table: "ServiceCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconKey",
                table: "ServiceCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPopular",
                table: "ServiceCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowOnHome",
                table: "ServiceCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ServiceDefinitionFieldOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceDefinitionFieldId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDefinitionFieldOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceDefinitionFieldOptions_ServiceDefinitionFields_ServiceDefinitionFieldId",
                        column: x => x.ServiceDefinitionFieldId,
                        principalTable: "ServiceDefinitionFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 118, DateTimeKind.Local).AddTicks(5431), new DateTime(2026, 6, 2, 17, 21, 34, 118, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 118, DateTimeKind.Local).AddTicks(5467), new DateTime(2026, 6, 2, 17, 21, 34, 118, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(2172), new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(2207), new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(2215), new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(7252), new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(7278), new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(7287), new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(7295), new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(7304), new DateTime(2026, 6, 2, 17, 21, 34, 119, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(1959), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(1997), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(2012), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(2027), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(2040), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6171), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6173), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6194), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6195), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6202), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6203), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6213), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6214), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6221), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6222), new DateTime(2026, 6, 2, 17, 21, 34, 120, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(865), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(882), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(888), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(894), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(901), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(907), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(911), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(916), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(921), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(926), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(930), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(934), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(939), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(944), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(949), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(954), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(958), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(966), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(971), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(975), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(980), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(984), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(989), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(992), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(1016), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(7826), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(7849), new DateTime(2026, 6, 2, 17, 21, 34, 121, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "FoodMenuCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 122, DateTimeKind.Local).AddTicks(4984), new DateTime(2026, 6, 2, 17, 21, 34, 122, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "FoodMenuCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 122, DateTimeKind.Local).AddTicks(5002), new DateTime(2026, 6, 2, 17, 21, 34, 122, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 122, DateTimeKind.Local).AddTicks(8472), new DateTime(2026, 6, 2, 17, 21, 34, 122, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 122, DateTimeKind.Local).AddTicks(8485), new DateTime(2026, 6, 2, 17, 21, 34, 122, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 122, DateTimeKind.Local).AddTicks(8491), new DateTime(2026, 6, 2, 17, 21, 34, 122, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 122, DateTimeKind.Local).AddTicks(8494), new DateTime(2026, 6, 2, 17, 21, 34, 122, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 122, DateTimeKind.Local).AddTicks(8498), new DateTime(2026, 6, 2, 17, 21, 34, 122, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "GuestStays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "ModifyDate", "VerificationCode" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 123, DateTimeKind.Local).AddTicks(2748), new DateTime(2026, 6, 4, 17, 21, 34, 123, DateTimeKind.Local).AddTicks(2759), new DateTime(2026, 6, 2, 17, 21, 34, 123, DateTimeKind.Local).AddTicks(3246), new DateTime(2026, 6, 2, 17, 21, 34, 123, DateTimeKind.Local).AddTicks(3248), "a4f7771c-4378-4a2d-abdf-ea3fe5da74e8" });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 123, DateTimeKind.Local).AddTicks(7045), new DateTime(2026, 6, 2, 17, 21, 34, 123, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.InsertData(
                table: "HotelServicePolicies",
                columns: new[] { "Id", "AccommodationConceptType", "AllowOnSitePayment", "AllowOnlinePayment", "AllowRoomCharge", "CreatedDate", "CurrencyCode", "Description", "HotelId", "IsActive", "IsChargeable", "IsDeleted", "IsIncludedInPackage", "IsVisible", "ModifyDate", "PriceOverride", "ServiceDefinitionId", "ServiceItemId", "ServiceType" },
                values: new object[,]
                {
                    { 1, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1129), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1135), null, null, null, 6 },
                    { 2, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1193), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1195), null, null, null, 14 },
                    { 3, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1201), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1202), null, null, null, 2 },
                    { 4, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1205), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1207), null, null, null, 3 },
                    { 5, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1211), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1212), null, null, null, 11 },
                    { 6, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1224), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1226), null, null, null, 8 },
                    { 7, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1231), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1232), null, null, null, 1 },
                    { 8, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1237), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1239), null, null, null, 10 },
                    { 9, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1244), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1245), null, null, null, 5 },
                    { 10, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1253), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1254), null, null, null, 7 },
                    { 11, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1258), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1260), null, null, null, 9 },
                    { 12, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1264), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1265), null, null, null, 12 },
                    { 13, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1270), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1272), null, null, null, 13 },
                    { 14, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1276), "TRY", null, 1, true, false, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1278), null, null, null, 15 },
                    { 15, 2, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1288), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1290), null, null, null, 6 },
                    { 16, 2, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1295), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1297), null, null, null, 14 },
                    { 17, 2, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1303), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1304), null, null, null, 2 },
                    { 18, 2, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1313), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1314), null, null, null, 3 },
                    { 19, 2, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1318), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1320), null, null, null, 11 },
                    { 20, 2, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1323), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1324), null, null, null, 8 },
                    { 21, 2, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1328), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1329), null, null, null, 1 },
                    { 22, 2, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1334), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1335), null, null, null, 10 },
                    { 23, 2, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1340), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1341), null, null, null, 5 },
                    { 24, 2, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1347), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1348), null, null, null, 7 },
                    { 25, 2, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1352), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1354), null, null, null, 9 },
                    { 26, 2, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1358), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1360), null, null, null, 12 },
                    { 27, 2, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1364), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1365), null, null, null, 13 },
                    { 28, 2, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1370), "TRY", null, 1, true, false, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1371), null, null, null, 15 },
                    { 29, 3, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1379), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1380), null, null, null, 6 },
                    { 30, 3, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1385), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1386), null, null, null, 14 },
                    { 31, 3, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1391), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1393), null, null, null, 2 },
                    { 32, 3, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1398), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1400), null, null, null, 3 },
                    { 33, 3, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1405), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1407), null, null, null, 11 },
                    { 34, 3, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1415), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1417), null, null, null, 8 },
                    { 35, 3, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1422), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1423), null, null, null, 1 },
                    { 36, 3, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1427), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1429), null, null, null, 10 },
                    { 37, 3, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1433), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1434), null, null, null, 5 },
                    { 38, 3, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1438), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1439), null, null, null, 7 },
                    { 39, 3, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1443), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1445), null, null, null, 9 },
                    { 40, 3, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1449), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1450), null, null, null, 12 },
                    { 41, 3, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1454), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1456), null, null, null, 13 },
                    { 42, 3, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1459), "TRY", null, 1, true, false, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1461), null, null, null, 15 },
                    { 43, 4, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1625), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1626), null, null, null, 6 },
                    { 44, 4, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1632), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1633), null, null, null, 14 },
                    { 45, 4, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1639), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1641), null, null, null, 2 },
                    { 46, 4, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1646), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1647), null, null, null, 3 },
                    { 47, 4, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1652), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1653), null, null, null, 11 },
                    { 48, 4, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1657), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1658), null, null, null, 8 },
                    { 49, 4, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1662), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1663), null, null, null, 1 },
                    { 50, 4, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1668), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1669), null, null, null, 10 },
                    { 51, 4, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1673), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1675), null, null, null, 5 },
                    { 52, 4, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1679), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1680), null, null, null, 7 },
                    { 53, 4, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1684), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1686), null, null, null, 9 },
                    { 54, 4, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1690), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1692), null, null, null, 12 },
                    { 55, 4, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1696), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1698), null, null, null, 13 },
                    { 56, 4, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1703), "TRY", null, 1, true, false, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1704), null, null, null, 15 },
                    { 57, 5, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1713), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1715), null, null, null, 6 },
                    { 58, 5, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1718), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1719), null, null, null, 14 },
                    { 59, 5, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1722), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1723), null, null, null, 2 },
                    { 60, 5, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1727), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1728), null, null, null, 3 },
                    { 61, 5, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1732), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1733), null, null, null, 11 },
                    { 62, 5, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1737), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1739), null, null, null, 8 },
                    { 63, 5, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1743), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1745), null, null, null, 1 },
                    { 64, 5, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1749), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1751), null, null, null, 10 },
                    { 65, 5, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1755), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1756), null, null, null, 5 },
                    { 66, 5, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1764), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1767), null, null, null, 7 },
                    { 67, 5, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1771), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1772), null, null, null, 9 },
                    { 68, 5, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1776), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1778), null, null, null, 12 },
                    { 69, 5, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1782), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1784), null, null, null, 13 },
                    { 70, 5, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1788), "TRY", null, 1, true, false, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1789), null, null, null, 15 },
                    { 71, 6, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1798), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1800), null, null, null, 6 },
                    { 72, 6, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1804), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1807), null, null, null, 14 },
                    { 73, 6, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1811), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1813), null, null, null, 2 },
                    { 74, 6, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1817), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1819), null, null, null, 3 },
                    { 75, 6, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1823), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1824), null, null, null, 11 },
                    { 76, 6, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1829), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1830), null, null, null, 8 },
                    { 77, 6, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1835), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1836), null, null, null, 1 },
                    { 78, 6, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1841), "TRY", null, 1, true, false, false, true, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1842), null, null, null, 10 },
                    { 79, 6, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1847), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1848), null, null, null, 5 },
                    { 80, 6, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1851), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1852), null, null, null, 7 },
                    { 81, 6, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1857), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1858), null, null, null, 9 },
                    { 82, 6, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1863), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1864), null, null, null, 12 },
                    { 83, 6, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1869), "TRY", null, 1, true, true, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1870), null, null, null, 13 },
                    { 84, 6, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1874), "TRY", null, 1, true, false, false, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 124, DateTimeKind.Local).AddTicks(1876), null, null, null, 15 }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 125, DateTimeKind.Local).AddTicks(8769), new DateTime(2026, 6, 2, 17, 21, 34, 125, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(1071), new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(1091), new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(1094), new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(1096), new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(1099), new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(1102), new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(4277), new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(7197), new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(7207), new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(7211), new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(7214), new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "HomeDisplayOrder", "IconKey", "IsPopular", "ModifyDate", "ShowOnHome" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9874), 1, "housekeeping", true, new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9879), true });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "HomeDisplayOrder", "IconKey", "IsPopular", "ModifyDate", "ShowOnHome" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9900), 3, "technical", true, new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9901), true });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "HomeDisplayOrder", "IconKey", "IsPopular", "ModifyDate", "ShowOnHome" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9910), 4, "reception", true, new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9911), true });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "HomeDisplayOrder", "IconKey", "IsPopular", "ModifyDate", "ShowOnHome" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9918), null, "laundry", false, new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9919), false });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "HomeDisplayOrder", "IconKey", "IsPopular", "ModifyDate", "ShowOnHome" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9925), null, "spa", false, new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9926), false });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "HomeDisplayOrder", "IconKey", "IsPopular", "ModifyDate", "ShowOnHome" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9931), null, "transport", false, new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9932), false });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "HomeDisplayOrder", "IconKey", "IsPopular", "ModifyDate", "ShowOnHome" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9937), 2, "food", true, new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9938), true });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "HomeDisplayOrder", "IconKey", "IsPopular", "ModifyDate", "ShowOnHome" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9945), null, "info", false, new DateTime(2026, 6, 2, 17, 21, 34, 127, DateTimeKind.Local).AddTicks(9946), false });

            migrationBuilder.InsertData(
                table: "ServiceDefinitionFieldOptions",
                columns: new[] { "Id", "CreatedDate", "DisplayOrder", "IsActive", "IsDeleted", "Label", "ModifyDate", "ServiceDefinitionFieldId", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(764), 1, true, false, "Ek yastik", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(769), 62, "extra_pillow" },
                    { 2, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(778), 2, true, false, "Bebek yatagi", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(779), 62, "baby_bed" },
                    { 3, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(781), 3, true, false, "Battaniye", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(782), 62, "blanket" },
                    { 4, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(784), 4, true, false, "Utu masasi", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(785), 62, "ironing_board" },
                    { 5, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(787), 5, true, false, "Diger", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(789), 62, "other" },
                    { 6, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(791), 1, true, false, "Saglik", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(792), 68, "health" },
                    { 7, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(794), 2, true, false, "Guvenlik", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(795), 68, "security" },
                    { 8, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(797), 3, true, false, "Ilk yardim", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(798), 68, "first_aid" },
                    { 9, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(800), 4, true, false, "Diger", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(802), 68, "other" }
                });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6829), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6844), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6877), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6882), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6890), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6894), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6903), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6908), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6913), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6916), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6924), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6928), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6934), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6938), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7105), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7111), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7116), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7125), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7128), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7132), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7139), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7143), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7147), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7153), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7157), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7160), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7166), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7170), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7174), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7179), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7182), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7186), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7192), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7195), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7198), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7206), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7209), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7213), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7218), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7221), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7225), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7235), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7239), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7243), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7249), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7252), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7255), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7262), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7266), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7357), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7362), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7366), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7375), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7379), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7383), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7389), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7393), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7399), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7403), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7409), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7413), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7418), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7422), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7426), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7433), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7437), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7440), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7449), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7454), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7458), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7464), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7468), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7474), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3660), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3694), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3702), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3711), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3718), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3724), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3730), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3736), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3742), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3747), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3753), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3760), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3768), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3774), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3779), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3785), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3790), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3796), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3802), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3808), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3816), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3821), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3827), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3832), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3919), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3926), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3932), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3938), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3943), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3950), new DateTime(2026, 6, 2, 17, 21, 34, 128, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3786), new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3801), new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3807), new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3813), new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3819), new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.InsertData(
                table: "ServiceRoleAssignment",
                columns: new[] { "Id", "CreatedDate", "DepartmentId", "EmployeeTypeRoleId", "HotelId", "IsActive", "IsDeleted", "IsPrimaryAssignment", "ModifyDate", "Priority", "ServiceId", "ServicesEnumId", "SlaMinutes" },
                values: new object[,]
                {
                    { 1006, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3825), 2, 12, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3826), 1, 6, 6, 20 },
                    { 1007, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3831), 2, 12, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3832), 1, 14, 14, 20 },
                    { 1008, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3834), 1, 4, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3835), 1, 11, 11, 5 },
                    { 1009, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3837), 4, 21, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3838), 1, 2, 2, 30 },
                    { 1010, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3840), 4, 21, 1, true, false, false, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3842), 2, 4, 4, 30 },
                    { 1011, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3844), 2, 10, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3845), 1, 5, 5, 60 },
                    { 1012, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3847), 5, 25, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3849), 1, 7, 7, 60 },
                    { 1013, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3851), 1, 8, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3852), 1, 8, 8, 10 },
                    { 1014, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3854), 1, 5, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3855), 1, 9, 9, 30 },
                    { 1015, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3857), 1, 6, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3858), 1, 12, 12, 20 },
                    { 1016, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3860), 3, 20, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3861), 1, 10, 10, 30 },
                    { 1017, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3863), 1, 4, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3864), 1, 13, 13, 15 },
                    { 1018, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3866), 1, 8, 1, true, false, true, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(3867), 1, 15, 15, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 130, DateTimeKind.Local).AddTicks(3950), new DateTime(2026, 6, 2, 17, 21, 34, 130, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 130, DateTimeKind.Local).AddTicks(3975), new DateTime(2026, 6, 2, 17, 21, 34, 130, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 130, DateTimeKind.Local).AddTicks(3982), new DateTime(2026, 6, 2, 17, 21, 34, 130, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(85), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(97), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(100), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(104), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(107), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(112), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(115), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(118), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(121), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(124), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(128), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(131), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(134), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(137), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(140), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(143), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(146), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(149), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(152), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(156), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(158), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(284), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(288), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(291), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(294), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(297), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(301), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(304), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(308), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(311), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(314), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(317), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(320), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(325), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(328), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(331), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(334), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(338), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(341), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(344), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(347), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(350), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(353), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(356), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(358), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(361), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(364), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(367), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(370), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(373), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(376), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(379), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(382), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(385), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(388), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(391), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(394), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(397), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(400), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(406), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(409), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(412), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(415), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(418), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(421), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(423), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(426), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(429), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(432), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(435), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(438), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(441), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(444), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(447), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(450), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(453), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(456), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(459), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(462), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(465), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(468), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(471), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(474), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(477), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(480), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(483), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(488), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(491), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(494), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(497), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(500), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(503), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(506), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(509), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(512), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(515), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(518), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(521), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(523), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(527), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(530), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(533), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(535), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(538), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(541), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(544), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(547), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(550), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(553), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(556), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(560), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(562), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(565), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(571), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(574), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(577), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(580), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(583), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(586), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(589), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(592), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(595), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(598), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(601), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(749), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(752), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(756), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(759), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(762), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(765), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(768), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(771), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(774), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(777), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(780), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(783), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(786), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(789), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(792), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(795), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(801), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(804), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(807), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(810), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(813), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(816), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(819), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(822), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(825), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(828), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(831), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(834), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(837), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(840), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(843), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(846), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(849), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(852), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(855), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(858), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(861), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(864), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(867), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(870), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(873), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(876), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(879), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(884), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(887), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(890), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(893), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(896), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(899), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(902), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(905), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(908), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(911), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(914), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(918), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(921), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(924), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(927), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(930), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(933), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(936), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(939), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(942), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(945), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(948), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(952), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(955), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(958), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(961), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(964), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(968), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(971), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(974), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(977), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(980), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(983), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(987), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(990), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(993), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(996), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(997) });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedDate", "FieldName", "IsActive", "IsDeleted", "LanguageCode", "ModifyDate", "RecordId", "TableName", "TranslationValue" },
                values: new object[,]
                {
                    { 10000, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4539), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4540), 1, "ServiceCategory", "Oda Hizmetleri" },
                    { 10001, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4568), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4569), 1, "ServiceCategory", "Housekeeping" },
                    { 10002, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4572), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4574), 1, "ServiceCategory", "Housekeeping" },
                    { 10003, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4577), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4578), 1, "ServiceCategory", "Service d'etage" },
                    { 10004, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4580), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4582), 1, "ServiceCategory", "Servicio de habitacion" },
                    { 10005, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4587), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4588), 1, "ServiceCategory", "خدمات الغرف" },
                    { 10006, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4590), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4592), 1, "ServiceCategory", "Housekeeping" },
                    { 10007, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4595), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4596), 2, "ServiceCategory", "Teknik Servis" },
                    { 10008, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4598), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4599), 2, "ServiceCategory", "Technical Service" },
                    { 10009, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4603), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4605), 2, "ServiceCategory", "Техническая служба" },
                    { 10010, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4607), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4608), 2, "ServiceCategory", "Service technique" },
                    { 10011, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4611), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4612), 2, "ServiceCategory", "Servicio tecnico" },
                    { 10012, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4615), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4616), 2, "ServiceCategory", "الخدمة الفنية" },
                    { 10013, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4618), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4619), 2, "ServiceCategory", "Technischer Service" },
                    { 10014, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4621), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4623), 3, "ServiceCategory", "On Buro" },
                    { 10015, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4625), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4626), 3, "ServiceCategory", "Reception" },
                    { 10016, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4628), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4629), 3, "ServiceCategory", "Ресепшен" },
                    { 10017, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4634), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4636), 3, "ServiceCategory", "Reception" },
                    { 10018, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4638), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4639), 3, "ServiceCategory", "Recepcion" },
                    { 10019, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4642), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4643), 3, "ServiceCategory", "الاستقبال" },
                    { 10020, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4645), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4646), 3, "ServiceCategory", "Rezeption" },
                    { 10021, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4648), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4649), 4, "ServiceCategory", "Camasirhane" },
                    { 10022, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4651), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4653), 4, "ServiceCategory", "Laundry" },
                    { 10023, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4655), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4656), 4, "ServiceCategory", "Прачечная" },
                    { 10024, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4658), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4660), 4, "ServiceCategory", "Blanchisserie" },
                    { 10025, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4662), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4663), 4, "ServiceCategory", "Lavanderia" },
                    { 10026, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4665), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4666), 4, "ServiceCategory", "المغسلة" },
                    { 10027, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4668), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4670), 4, "ServiceCategory", "Wascherei" },
                    { 10028, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4672), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4673), 5, "ServiceCategory", "Wellness ve Saglik" },
                    { 10029, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4675), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4676), 5, "ServiceCategory", "Wellness and Health" },
                    { 10030, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4678), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4679), 5, "ServiceCategory", "Велнес и здоровье" },
                    { 10031, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4681), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4683), 5, "ServiceCategory", "Bien-etre et sante" },
                    { 10032, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4685), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4686), 5, "ServiceCategory", "Bienestar y salud" },
                    { 10033, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4691), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4693), 5, "ServiceCategory", "الصحة والعافية" },
                    { 10034, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4695), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4696), 5, "ServiceCategory", "Wellness und Gesundheit" },
                    { 10035, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4698), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4699), 6, "ServiceCategory", "Ulasim" },
                    { 10036, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4701), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4702), 6, "ServiceCategory", "Transportation" },
                    { 10037, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4705), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4706), 6, "ServiceCategory", "Транспорт" },
                    { 10038, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4708), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4709), 6, "ServiceCategory", "Transport" },
                    { 10039, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4711), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4712), 6, "ServiceCategory", "Transporte" },
                    { 10040, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4714), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4715), 6, "ServiceCategory", "النقل" },
                    { 10041, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4717), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4718), 6, "ServiceCategory", "Transport" },
                    { 10042, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4720), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4721), 7, "ServiceCategory", "Yiyecek Icecek" },
                    { 10043, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4724), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4725), 7, "ServiceCategory", "Food and Beverage" },
                    { 10044, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4727), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4728), 7, "ServiceCategory", "Еда и напитки" },
                    { 10045, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4729), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4730), 7, "ServiceCategory", "Restauration" },
                    { 10046, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4732), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4733), 7, "ServiceCategory", "Alimentos y bebidas" },
                    { 10047, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4735), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4736), 7, "ServiceCategory", "الأطعمة والمشروبات" },
                    { 10048, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4738), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4739), 7, "ServiceCategory", "Speisen und Getranke" },
                    { 10049, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4741), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4742), 8, "ServiceCategory", "Bilgilendirme" },
                    { 10050, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4744), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4745), 8, "ServiceCategory", "Information" },
                    { 10051, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4747), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4748), 8, "ServiceCategory", "Информация" },
                    { 10052, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4750), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4751), 8, "ServiceCategory", "Information" },
                    { 10053, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4754), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4755), 8, "ServiceCategory", "Informacion" },
                    { 10054, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4756), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4758), 8, "ServiceCategory", "معلومات" },
                    { 10055, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4760), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4761), 8, "ServiceCategory", "Information" },
                    { 10056, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4764), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4765), 101, "ServiceDefinition", "Havlu degisimi veya eksigi" },
                    { 10057, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4766), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4768), 101, "ServiceDefinition", "Towel replacement or missing towel" },
                    { 10058, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4770), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4771), 101, "ServiceDefinition", "Замена или нехватка полотенец" },
                    { 10059, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4773), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4774), 101, "ServiceDefinition", "Remplacement ou manque de serviette" },
                    { 10060, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4776), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4777), 101, "ServiceDefinition", "Cambio o falta de toallas" },
                    { 10061, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4779), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4780), 101, "ServiceDefinition", "تغيير المناشف أو نقصها" },
                    { 10062, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4782), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4783), 101, "ServiceDefinition", "Handtuchwechsel oder fehlendes Handtuch" },
                    { 10063, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4787), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4788), 102, "ServiceDefinition", "Oda genel temizlik" },
                    { 10064, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4790), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4791), 102, "ServiceDefinition", "General room cleaning" },
                    { 10065, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4796), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4797), 102, "ServiceDefinition", "Общая уборка номера" },
                    { 10066, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4799), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4801), 102, "ServiceDefinition", "Nettoyage general de la chambre" },
                    { 10067, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4802), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4803), 102, "ServiceDefinition", "Limpieza general de habitacion" },
                    { 10068, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4805), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4806), 102, "ServiceDefinition", "تنظيف عام للغرفة" },
                    { 10069, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4808), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4809), 102, "ServiceDefinition", "Allgemeine Zimmerreinigung" },
                    { 10070, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4812), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4813), 103, "ServiceDefinition", "Carsaf veya yatak yuzu degisimi" },
                    { 10071, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4815), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4816), 103, "ServiceDefinition", "Sheet or bed linen change" },
                    { 10072, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4910), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4911), 103, "ServiceDefinition", "Смена постельного белья" },
                    { 10073, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4914), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4915), 103, "ServiceDefinition", "Changement des draps" },
                    { 10074, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4917), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4919), 103, "ServiceDefinition", "Cambio de sabanas" },
                    { 10075, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4921), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4922), 103, "ServiceDefinition", "تغيير الشراشف" },
                    { 10076, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4924), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4925), 103, "ServiceDefinition", "Bettwaesche wechseln" },
                    { 10077, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4928), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4930), 201, "ServiceDefinition", "Bagaj Tasima" },
                    { 10078, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4932), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4933), 201, "ServiceDefinition", "Luggage assistance" },
                    { 10079, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4936), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4937), 201, "ServiceDefinition", "Помощь с багажом" },
                    { 10080, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4939), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4940), 201, "ServiceDefinition", "Assistance bagages" },
                    { 10081, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4942), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4944), 201, "ServiceDefinition", "Asistencia con equipaje" },
                    { 10082, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4945), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4947), 201, "ServiceDefinition", "مساعدة الأمتعة" },
                    { 10083, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4948), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4950), 201, "ServiceDefinition", "Gepaeckservice" },
                    { 10084, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4952), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4953), 301, "ServiceDefinition", "Utu" },
                    { 10085, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4955), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4956), 301, "ServiceDefinition", "Ironing" },
                    { 10086, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4959), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4960), 301, "ServiceDefinition", "Глажка" },
                    { 10087, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4962), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4963), 301, "ServiceDefinition", "Repassage" },
                    { 10088, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4965), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4966), 301, "ServiceDefinition", "Planchado" },
                    { 10089, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4968), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4969), 301, "ServiceDefinition", "كي الملابس" },
                    { 10090, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4972), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4973), 301, "ServiceDefinition", "Buegeln" },
                    { 10091, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4975), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4976), 302, "ServiceDefinition", "T-Shirt" },
                    { 10092, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4978), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4980), 302, "ServiceDefinition", "T-Shirt" },
                    { 10093, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4981), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4983), 302, "ServiceDefinition", "Футболка" },
                    { 10094, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4985), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4986), 302, "ServiceDefinition", "T-shirt" },
                    { 10095, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4988), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4990), 302, "ServiceDefinition", "Camiseta" },
                    { 10096, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4992), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4993), 302, "ServiceDefinition", "قميص" },
                    { 10097, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4995), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4997), 302, "ServiceDefinition", "T-Shirt" },
                    { 10098, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(4999), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5001), 303, "ServiceDefinition", "Kaban-Mont" },
                    { 10099, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5002), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5004), 303, "ServiceDefinition", "Coat/Jacket" },
                    { 10100, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5006), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5007), 303, "ServiceDefinition", "Пальто/Куртка" },
                    { 10101, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5009), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5010), 303, "ServiceDefinition", "Manteau/Veste" },
                    { 10102, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5012), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5014), 303, "ServiceDefinition", "Abrigo/Chaqueta" },
                    { 10103, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5016), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5017), 303, "ServiceDefinition", "معطف/سترة" },
                    { 10104, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5019), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5020), 303, "ServiceDefinition", "Mantel/Jacke" },
                    { 10105, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5023), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5024), 304, "ServiceDefinition", "Kuru Temizleme" },
                    { 10106, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5026), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5027), 304, "ServiceDefinition", "Dry cleaning" },
                    { 10107, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5029), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5031), 304, "ServiceDefinition", "Химчистка" },
                    { 10108, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5033), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5034), 304, "ServiceDefinition", "Nettoyage a sec" },
                    { 10109, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5036), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5037), 304, "ServiceDefinition", "Limpieza en seco" },
                    { 10110, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5039), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5040), 304, "ServiceDefinition", "تنظيف جاف" },
                    { 10111, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5042), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5043), 304, "ServiceDefinition", "Chemische Reinigung" },
                    { 10112, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5046), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5047), 305, "ServiceDefinition", "T-Shirt Kuru Temizleme" },
                    { 10113, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5049), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5050), 305, "ServiceDefinition", "T-Shirt dry cleaning" },
                    { 10114, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5052), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5054), 305, "ServiceDefinition", "Химчистка футболки" },
                    { 10115, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5055), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5057), 305, "ServiceDefinition", "Nettoyage a sec T-shirt" },
                    { 10116, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5059), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5061), 305, "ServiceDefinition", "Limpieza en seco de camiseta" },
                    { 10117, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5063), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5064), 305, "ServiceDefinition", "تنظيف جاف للقميص" },
                    { 10118, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5066), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5067), 305, "ServiceDefinition", "T-Shirt chemische Reinigung" },
                    { 10119, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5069), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5070), 306, "ServiceDefinition", "Kaban-Mont Kuru Temizleme" },
                    { 10120, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5072), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5073), 306, "ServiceDefinition", "Coat/Jacket dry cleaning" },
                    { 10121, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5075), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5077), 306, "ServiceDefinition", "Химчистка пальто/куртки" },
                    { 10122, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5079), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5080), 306, "ServiceDefinition", "Nettoyage a sec manteau/veste" },
                    { 10123, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5082), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5083), 306, "ServiceDefinition", "Limpieza en seco de abrigo/chaqueta" },
                    { 10124, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5085), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5086), 306, "ServiceDefinition", "تنظيف جاف للمعطف/السترة" },
                    { 10125, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5088), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5089), 306, "ServiceDefinition", "Mantel/Jacke chemische Reinigung" },
                    { 10126, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5091), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5092), 307, "ServiceDefinition", "Pantolon" },
                    { 10127, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5094), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5096), 307, "ServiceDefinition", "Trousers" },
                    { 10128, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5098), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5099), 307, "ServiceDefinition", "Брюки" },
                    { 10129, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5103), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5105), 307, "ServiceDefinition", "Pantalon" },
                    { 10130, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5107), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5108), 307, "ServiceDefinition", "Pantalones" },
                    { 10131, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5110), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5111), 307, "ServiceDefinition", "بنطال" },
                    { 10132, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5113), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5115), 307, "ServiceDefinition", "Hose" },
                    { 10133, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5117), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5118), 401, "ServiceDefinition", "Uzak Dogu" },
                    { 10134, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5120), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5121), 401, "ServiceDefinition", "Far Eastern massage" },
                    { 10135, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5123), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5124), 401, "ServiceDefinition", "Восточный массаж" },
                    { 10136, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5127), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5128), 401, "ServiceDefinition", "Massage oriental" },
                    { 10137, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5130), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5132), 401, "ServiceDefinition", "Masaje oriental" },
                    { 10138, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5134), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5135), 401, "ServiceDefinition", "مساج شرقي" },
                    { 10139, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5137), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5139), 401, "ServiceDefinition", "Fernost-Massage" },
                    { 10140, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5141), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5142), 402, "ServiceDefinition", "Tayland Masaji" },
                    { 10141, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5144), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5145), 402, "ServiceDefinition", "Thai massage" },
                    { 10142, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5147), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5148), 402, "ServiceDefinition", "Тайский массаж" },
                    { 10143, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5150), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5152), 402, "ServiceDefinition", "Massage thailandais" },
                    { 10144, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5154), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5155), 402, "ServiceDefinition", "Masaje tailandes" },
                    { 10145, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5157), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5158), 402, "ServiceDefinition", "مساج تايلاندي" },
                    { 10146, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5160), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5161), 402, "ServiceDefinition", "Thai-Massage" },
                    { 10147, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5163), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5164), 501, "ServiceDefinition", "Transfer Talebi" },
                    { 10148, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5166), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5168), 501, "ServiceDefinition", "Transfer request" },
                    { 10149, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5252), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5253), 501, "ServiceDefinition", "Запрос трансфера" },
                    { 10150, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5256), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5257), 501, "ServiceDefinition", "Demande de transfert" },
                    { 10151, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5259), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5261), 501, "ServiceDefinition", "Solicitud de traslado" },
                    { 10152, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5263), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5264), 501, "ServiceDefinition", "طلب نقل" },
                    { 10153, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5266), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5268), 501, "ServiceDefinition", "Transferanfrage" },
                    { 10154, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5270), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5272), 502, "ServiceDefinition", "Vale Hizmeti" },
                    { 10155, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5273), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5275), 502, "ServiceDefinition", "Valet service" },
                    { 10156, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5277), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5278), 502, "ServiceDefinition", "Услуга парковщика" },
                    { 10157, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5280), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5281), 502, "ServiceDefinition", "Service voiturier" },
                    { 10158, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5283), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5285), 502, "ServiceDefinition", "Servicio de valet" },
                    { 10159, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5287), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5288), 502, "ServiceDefinition", "خدمة صف السيارات" },
                    { 10160, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5290), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5291), 502, "ServiceDefinition", "Parkservice" },
                    { 10161, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5296), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5297), 601, "ServiceDefinition", "Minibar Talebi" },
                    { 10162, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5299), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5300), 601, "ServiceDefinition", "Minibar request" },
                    { 10163, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5302), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5304), 601, "ServiceDefinition", "Запрос мини-бара" },
                    { 10164, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5305), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5307), 601, "ServiceDefinition", "Demande de minibar" },
                    { 10165, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5309), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5310), 601, "ServiceDefinition", "Solicitud de minibar" },
                    { 10166, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5312), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5313), 601, "ServiceDefinition", "طلب ميني بار" },
                    { 10167, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5315), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5317), 601, "ServiceDefinition", "Minibar-Anfrage" },
                    { 10168, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5319), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5320), 602, "ServiceDefinition", "Uyandirma Servisi" },
                    { 10169, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5322), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5323), 602, "ServiceDefinition", "Wake-up call" },
                    { 10170, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5325), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5326), 602, "ServiceDefinition", "Услуга будильника" },
                    { 10171, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5328), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5329), 602, "ServiceDefinition", "Service de reveil" },
                    { 10172, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5331), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5332), 602, "ServiceDefinition", "Servicio despertador" },
                    { 10173, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5335), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5336), 602, "ServiceDefinition", "خدمة الإيقاظ" },
                    { 10174, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5338), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5339), 602, "ServiceDefinition", "Weckruf" },
                    { 10175, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5341), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5342), 603, "ServiceDefinition", "Konaklama Uzatma" },
                    { 10176, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5344), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5345), 603, "ServiceDefinition", "Stay extension" },
                    { 10177, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5348), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5349), 603, "ServiceDefinition", "Продление проживания" },
                    { 10178, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5351), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5352), 603, "ServiceDefinition", "Prolongation du sejour" },
                    { 10179, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5354), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5356), 603, "ServiceDefinition", "Extension de estancia" },
                    { 10180, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5357), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5359), 603, "ServiceDefinition", "تمديد الإقامة" },
                    { 10181, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5361), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5362), 603, "ServiceDefinition", "Aufenthalt verlaengern" },
                    { 10182, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5365), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5366), 604, "ServiceDefinition", "Oda Malzemesi Talebi" },
                    { 10183, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5368), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5369), 604, "ServiceDefinition", "Room amenity request" },
                    { 10184, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5371), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5372), 604, "ServiceDefinition", "Запрос принадлежностей для номера" },
                    { 10185, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5375), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5376), 604, "ServiceDefinition", "Demande d'equipement de chambre" },
                    { 10186, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5378), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5379), 604, "ServiceDefinition", "Solicitud de amenidades" },
                    { 10187, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5382), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5383), 604, "ServiceDefinition", "طلب مستلزمات الغرفة" },
                    { 10188, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5385), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5386), 604, "ServiceDefinition", "Zimmerausstattung anfordern" },
                    { 10189, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5388), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5389), 605, "ServiceDefinition", "Medikal Yardim" },
                    { 10190, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5391), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5393), 605, "ServiceDefinition", "Medical assistance" },
                    { 10191, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5395), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5396), 605, "ServiceDefinition", "Медицинская помощь" },
                    { 10192, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5398), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5399), 605, "ServiceDefinition", "Assistance medicale" },
                    { 10193, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5401), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5403), 605, "ServiceDefinition", "Asistencia medica" },
                    { 10194, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5404), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5406), 605, "ServiceDefinition", "مساعدة طبية" },
                    { 10195, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5407), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5409), 605, "ServiceDefinition", "Medizinische Hilfe" },
                    { 10196, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5411), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5412), 606, "ServiceDefinition", "Saglik ve Guvenlik" },
                    { 10197, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5414), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5416), 606, "ServiceDefinition", "Health and safety" },
                    { 10198, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5418), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5420), 606, "ServiceDefinition", "Здоровье и безопасность" },
                    { 10199, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5422), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5423), 606, "ServiceDefinition", "Sante et securite" },
                    { 10200, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5425), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5426), 606, "ServiceDefinition", "Salud y seguridad" },
                    { 10201, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5428), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5429), 606, "ServiceDefinition", "الصحة والسلامة" },
                    { 10202, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5431), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5433), 606, "ServiceDefinition", "Gesundheit und Sicherheit" },
                    { 10203, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5435), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5436), 607, "ServiceDefinition", "Otel Bilgilendirme ve Duyuru" },
                    { 10204, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5438), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5439), 607, "ServiceDefinition", "Hotel information and announcements" },
                    { 10205, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5442), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5443), 607, "ServiceDefinition", "Информация и объявления отеля" },
                    { 10206, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5445), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5446), 607, "ServiceDefinition", "Informations et annonces de l'hotel" },
                    { 10207, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5448), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5449), 607, "ServiceDefinition", "Informacion y anuncios del hotel" },
                    { 10208, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5451), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5452), 607, "ServiceDefinition", "معلومات وإعلانات الفندق" },
                    { 10209, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5454), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5456), 607, "ServiceDefinition", "Hotelinformationen und Ankuendigungen" },
                    { 10210, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5458), "Name", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5459), 608, "ServiceDefinition", "Menu Siparisi" },
                    { 10211, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5461), "Name", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5463), 608, "ServiceDefinition", "Menu order" },
                    { 10212, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5465), "Name", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5466), 608, "ServiceDefinition", "Заказ меню" },
                    { 10213, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5468), "Name", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5469), 608, "ServiceDefinition", "Commande de menu" },
                    { 10214, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5471), "Name", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5473), 608, "ServiceDefinition", "Pedido de menu" },
                    { 10215, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5476), "Name", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5477), 608, "ServiceDefinition", "طلب قائمة الطعام" },
                    { 10216, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5479), "Name", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5480), 608, "ServiceDefinition", "Menuebestellung" },
                    { 10217, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5912), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5913), 1, "ServiceDefinitionField", "Ariza aciklamasi" },
                    { 10218, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5916), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5917), 1, "ServiceDefinitionField", "Issue description" },
                    { 10219, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5920), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5921), 1, "ServiceDefinitionField", "Описание проблемы" },
                    { 10220, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5923), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5924), 1, "ServiceDefinitionField", "Description du probleme" },
                    { 10221, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5926), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5928), 1, "ServiceDefinitionField", "Descripcion del problema" },
                    { 10222, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5930), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5931), 1, "ServiceDefinitionField", "وصف المشكلة" },
                    { 10223, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5933), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5935), 1, "ServiceDefinitionField", "Problembeschreibung" },
                    { 10224, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5941), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5942), 2, "ServiceDefinitionField", "Fotograf" },
                    { 10225, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5944), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5945), 2, "ServiceDefinitionField", "Photo" },
                    { 10226, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5947), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5949), 2, "ServiceDefinitionField", "Фото" },
                    { 10227, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5951), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5952), 2, "ServiceDefinitionField", "Photo" },
                    { 10228, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5954), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5955), 2, "ServiceDefinitionField", "Foto" },
                    { 10229, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5957), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5958), 2, "ServiceDefinitionField", "صورة" },
                    { 10230, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5960), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5962), 2, "ServiceDefinitionField", "Foto" },
                    { 10231, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5966), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5967), 3, "ServiceDefinitionField", "Ariza aciklamasi" },
                    { 10232, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5969), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5970), 3, "ServiceDefinitionField", "Issue description" },
                    { 10233, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5972), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5974), 3, "ServiceDefinitionField", "Описание проблемы" },
                    { 10234, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5976), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5977), 3, "ServiceDefinitionField", "Description du probleme" },
                    { 10235, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5979), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5980), 3, "ServiceDefinitionField", "Descripcion del problema" },
                    { 10236, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5982), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5983), 3, "ServiceDefinitionField", "وصف المشكلة" },
                    { 10237, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5985), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5986), 3, "ServiceDefinitionField", "Problembeschreibung" },
                    { 10238, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5990), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5991), 4, "ServiceDefinitionField", "Fotograf" },
                    { 10239, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5993), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5994), 4, "ServiceDefinitionField", "Photo" },
                    { 10240, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5996), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5997), 4, "ServiceDefinitionField", "Фото" },
                    { 10241, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(5999), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6000), 4, "ServiceDefinitionField", "Photo" },
                    { 10242, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6002), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6004), 4, "ServiceDefinitionField", "Foto" },
                    { 10243, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6006), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6007), 4, "ServiceDefinitionField", "صورة" },
                    { 10244, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6009), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6010), 4, "ServiceDefinitionField", "Foto" },
                    { 10245, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6014), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6015), 5, "ServiceDefinitionField", "Ariza aciklamasi" },
                    { 10246, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6017), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6019), 5, "ServiceDefinitionField", "Issue description" },
                    { 10247, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6021), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6022), 5, "ServiceDefinitionField", "Описание проблемы" },
                    { 10248, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6025), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6026), 5, "ServiceDefinitionField", "Description du probleme" },
                    { 10249, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6028), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6029), 5, "ServiceDefinitionField", "Descripcion del problema" },
                    { 10250, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6031), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6033), 5, "ServiceDefinitionField", "وصف المشكلة" },
                    { 10251, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6097), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6098), 5, "ServiceDefinitionField", "Problembeschreibung" },
                    { 10252, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6103), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6104), 6, "ServiceDefinitionField", "Fotograf" },
                    { 10253, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6106), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6108), 6, "ServiceDefinitionField", "Photo" },
                    { 10254, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6110), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6112), 6, "ServiceDefinitionField", "Фото" },
                    { 10255, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6114), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6115), 6, "ServiceDefinitionField", "Photo" },
                    { 10256, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6117), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6118), 6, "ServiceDefinitionField", "Foto" },
                    { 10257, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6125), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6126), 6, "ServiceDefinitionField", "صورة" },
                    { 10258, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6128), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6130), 6, "ServiceDefinitionField", "Foto" },
                    { 10259, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6133), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6135), 7, "ServiceDefinitionField", "Ariza aciklamasi" },
                    { 10260, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6137), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6138), 7, "ServiceDefinitionField", "Issue description" },
                    { 10261, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6140), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6142), 7, "ServiceDefinitionField", "Описание проблемы" },
                    { 10262, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6144), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6145), 7, "ServiceDefinitionField", "Description du probleme" },
                    { 10263, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6147), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6148), 7, "ServiceDefinitionField", "Descripcion del problema" },
                    { 10264, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6151), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6152), 7, "ServiceDefinitionField", "وصف المشكلة" },
                    { 10265, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6155), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6156), 7, "ServiceDefinitionField", "Problembeschreibung" },
                    { 10266, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6160), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6161), 8, "ServiceDefinitionField", "Fotograf" },
                    { 10267, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6163), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6164), 8, "ServiceDefinitionField", "Photo" },
                    { 10268, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6166), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6167), 8, "ServiceDefinitionField", "Фото" },
                    { 10269, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6170), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6171), 8, "ServiceDefinitionField", "Photo" },
                    { 10270, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6173), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6174), 8, "ServiceDefinitionField", "Foto" },
                    { 10271, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6177), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6178), 8, "ServiceDefinitionField", "صورة" },
                    { 10272, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6180), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6181), 8, "ServiceDefinitionField", "Foto" },
                    { 10273, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6185), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6186), 9, "ServiceDefinitionField", "Ariza aciklamasi" },
                    { 10274, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6188), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6189), 9, "ServiceDefinitionField", "Issue description" },
                    { 10275, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6192), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6193), 9, "ServiceDefinitionField", "Описание проблемы" },
                    { 10276, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6195), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6196), 9, "ServiceDefinitionField", "Description du probleme" },
                    { 10277, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6198), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6199), 9, "ServiceDefinitionField", "Descripcion del problema" },
                    { 10278, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6201), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6203), 9, "ServiceDefinitionField", "وصف المشكلة" },
                    { 10279, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6205), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6206), 9, "ServiceDefinitionField", "Problembeschreibung" },
                    { 10280, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6210), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6211), 10, "ServiceDefinitionField", "Fotograf" },
                    { 10281, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6213), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6214), 10, "ServiceDefinitionField", "Photo" },
                    { 10282, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6216), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6218), 10, "ServiceDefinitionField", "Фото" },
                    { 10283, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6219), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6221), 10, "ServiceDefinitionField", "Photo" },
                    { 10284, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6223), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6224), 10, "ServiceDefinitionField", "Foto" },
                    { 10285, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6226), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6227), 10, "ServiceDefinitionField", "صورة" },
                    { 10286, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6229), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6231), 10, "ServiceDefinitionField", "Foto" },
                    { 10287, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6235), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6236), 11, "ServiceDefinitionField", "Ariza aciklamasi" },
                    { 10288, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6239), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6240), 11, "ServiceDefinitionField", "Issue description" },
                    { 10289, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6242), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6243), 11, "ServiceDefinitionField", "Описание проблемы" },
                    { 10290, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6245), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6246), 11, "ServiceDefinitionField", "Description du probleme" },
                    { 10291, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6248), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6249), 11, "ServiceDefinitionField", "Descripcion del problema" },
                    { 10292, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6252), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6253), 11, "ServiceDefinitionField", "وصف المشكلة" },
                    { 10293, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6255), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6256), 11, "ServiceDefinitionField", "Problembeschreibung" },
                    { 10294, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6260), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6261), 12, "ServiceDefinitionField", "Fotograf" },
                    { 10295, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6263), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6264), 12, "ServiceDefinitionField", "Photo" },
                    { 10296, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6266), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6267), 12, "ServiceDefinitionField", "Фото" },
                    { 10297, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6269), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6271), 12, "ServiceDefinitionField", "Photo" },
                    { 10298, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6529), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6530), 12, "ServiceDefinitionField", "Foto" },
                    { 10299, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6533), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6534), 12, "ServiceDefinitionField", "صورة" },
                    { 10300, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6536), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6538), 12, "ServiceDefinitionField", "Foto" },
                    { 10301, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6542), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6544), 13, "ServiceDefinitionField", "Ariza aciklamasi" },
                    { 10302, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6546), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6547), 13, "ServiceDefinitionField", "Issue description" },
                    { 10303, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6549), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6550), 13, "ServiceDefinitionField", "Описание проблемы" },
                    { 10304, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6553), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6555), 13, "ServiceDefinitionField", "Description du probleme" },
                    { 10305, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6557), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6558), 13, "ServiceDefinitionField", "Descripcion del problema" },
                    { 10306, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6560), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6561), 13, "ServiceDefinitionField", "وصف المشكلة" },
                    { 10307, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6564), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6565), 13, "ServiceDefinitionField", "Problembeschreibung" },
                    { 10308, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6569), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6570), 14, "ServiceDefinitionField", "Fotograf" },
                    { 10309, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6572), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6573), 14, "ServiceDefinitionField", "Photo" },
                    { 10310, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6575), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6576), 14, "ServiceDefinitionField", "Фото" },
                    { 10311, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6578), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6579), 14, "ServiceDefinitionField", "Photo" },
                    { 10312, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6582), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6583), 14, "ServiceDefinitionField", "Foto" },
                    { 10313, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6585), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6586), 14, "ServiceDefinitionField", "صورة" },
                    { 10314, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6588), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6589), 14, "ServiceDefinitionField", "Foto" },
                    { 10315, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6943), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6945), 15, "ServiceDefinitionField", "Not" },
                    { 10316, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6947), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6948), 15, "ServiceDefinitionField", "Note" },
                    { 10317, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6951), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6952), 15, "ServiceDefinitionField", "Примечание" },
                    { 10318, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6954), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6955), 15, "ServiceDefinitionField", "Note" },
                    { 10319, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6957), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6958), 15, "ServiceDefinitionField", "Nota" },
                    { 10320, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6960), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6961), 15, "ServiceDefinitionField", "ملاحظة" },
                    { 10321, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6963), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6965), 15, "ServiceDefinitionField", "Notiz" },
                    { 10322, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6967), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6968), 16, "ServiceDefinitionField", "Not" },
                    { 10323, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6970), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6971), 16, "ServiceDefinitionField", "Note" },
                    { 10324, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6974), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6975), 16, "ServiceDefinitionField", "Примечание" },
                    { 10325, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6977), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6978), 16, "ServiceDefinitionField", "Note" },
                    { 10326, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6980), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6981), 16, "ServiceDefinitionField", "Nota" },
                    { 10327, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6983), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6984), 16, "ServiceDefinitionField", "ملاحظة" },
                    { 10328, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6987), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6988), 16, "ServiceDefinitionField", "Notiz" },
                    { 10329, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6990), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6991), 17, "ServiceDefinitionField", "Not" },
                    { 10330, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6993), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6994), 17, "ServiceDefinitionField", "Note" },
                    { 10331, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6996), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6997), 17, "ServiceDefinitionField", "Примечание" },
                    { 10332, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(6999), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7000), 17, "ServiceDefinitionField", "Note" },
                    { 10333, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7002), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7003), 17, "ServiceDefinitionField", "Nota" },
                    { 10334, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7004), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7005), 17, "ServiceDefinitionField", "ملاحظة" },
                    { 10335, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7008), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7009), 17, "ServiceDefinitionField", "Notiz" },
                    { 10336, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7011), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7012), 20, "ServiceDefinitionField", "Not" },
                    { 10337, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7014), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7015), 20, "ServiceDefinitionField", "Note" },
                    { 10338, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7017), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7018), 20, "ServiceDefinitionField", "Примечание" },
                    { 10339, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7020), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7021), 20, "ServiceDefinitionField", "Note" },
                    { 10340, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7023), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7024), 20, "ServiceDefinitionField", "Nota" },
                    { 10341, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7026), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7027), 20, "ServiceDefinitionField", "ملاحظة" },
                    { 10342, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7029), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7030), 20, "ServiceDefinitionField", "Notiz" },
                    { 10343, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7033), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7034), 23, "ServiceDefinitionField", "Not" },
                    { 10344, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7036), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7037), 23, "ServiceDefinitionField", "Note" },
                    { 10345, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7039), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7041), 23, "ServiceDefinitionField", "Примечание" },
                    { 10346, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7043), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7044), 23, "ServiceDefinitionField", "Note" },
                    { 10347, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7045), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7047), 23, "ServiceDefinitionField", "Nota" },
                    { 10348, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7048), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7049), 23, "ServiceDefinitionField", "ملاحظة" },
                    { 10349, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7052), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7053), 23, "ServiceDefinitionField", "Notiz" },
                    { 10350, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7055), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7056), 26, "ServiceDefinitionField", "Not" },
                    { 10351, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7058), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7059), 26, "ServiceDefinitionField", "Note" },
                    { 10352, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7062), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7063), 26, "ServiceDefinitionField", "Примечание" },
                    { 10353, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7065), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7066), 26, "ServiceDefinitionField", "Note" },
                    { 10354, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7068), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7069), 26, "ServiceDefinitionField", "Nota" },
                    { 10355, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7071), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7072), 26, "ServiceDefinitionField", "ملاحظة" },
                    { 10356, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7074), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7075), 26, "ServiceDefinitionField", "Notiz" },
                    { 10357, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7077), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7079), 29, "ServiceDefinitionField", "Not" },
                    { 10358, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7081), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7082), 29, "ServiceDefinitionField", "Note" },
                    { 10359, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7084), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7085), 29, "ServiceDefinitionField", "Примечание" },
                    { 10360, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7087), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7088), 29, "ServiceDefinitionField", "Note" },
                    { 10361, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7090), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7091), 29, "ServiceDefinitionField", "Nota" },
                    { 10362, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7093), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7094), 29, "ServiceDefinitionField", "ملاحظة" },
                    { 10363, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7096), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7097), 29, "ServiceDefinitionField", "Notiz" },
                    { 10364, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7100), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7101), 32, "ServiceDefinitionField", "Not" },
                    { 10365, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7103), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7104), 32, "ServiceDefinitionField", "Note" },
                    { 10366, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7106), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7107), 32, "ServiceDefinitionField", "Примечание" },
                    { 10367, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7110), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7111), 32, "ServiceDefinitionField", "Note" },
                    { 10368, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7113), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7114), 32, "ServiceDefinitionField", "Nota" },
                    { 10369, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7116), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7117), 32, "ServiceDefinitionField", "ملاحظة" },
                    { 10370, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7119), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7120), 32, "ServiceDefinitionField", "Notiz" },
                    { 10371, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7122), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7123), 35, "ServiceDefinitionField", "Not" },
                    { 10372, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7125), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7126), 35, "ServiceDefinitionField", "Note" },
                    { 10373, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7128), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7129), 35, "ServiceDefinitionField", "Примечание" },
                    { 10374, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7131), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7132), 35, "ServiceDefinitionField", "Note" },
                    { 10375, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7134), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7135), 35, "ServiceDefinitionField", "Nota" },
                    { 10376, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7137), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7138), 35, "ServiceDefinitionField", "ملاحظة" },
                    { 10377, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7140), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7141), 35, "ServiceDefinitionField", "Notiz" },
                    { 10378, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7143), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7144), 38, "ServiceDefinitionField", "Not" },
                    { 10379, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7146), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7147), 38, "ServiceDefinitionField", "Note" },
                    { 10380, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7149), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7150), 38, "ServiceDefinitionField", "Примечание" },
                    { 10381, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7152), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7153), 38, "ServiceDefinitionField", "Note" },
                    { 10382, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7155), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7156), 38, "ServiceDefinitionField", "Nota" },
                    { 10383, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7159), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7160), 38, "ServiceDefinitionField", "ملاحظة" },
                    { 10384, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7161), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7162), 38, "ServiceDefinitionField", "Notiz" },
                    { 10385, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7165), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7166), 41, "ServiceDefinitionField", "Not" },
                    { 10386, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7168), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7169), 41, "ServiceDefinitionField", "Note" },
                    { 10387, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7171), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7172), 41, "ServiceDefinitionField", "Примечание" },
                    { 10388, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7174), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7175), 41, "ServiceDefinitionField", "Note" },
                    { 10389, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7177), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7178), 41, "ServiceDefinitionField", "Nota" },
                    { 10390, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7180), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7181), 41, "ServiceDefinitionField", "ملاحظة" },
                    { 10391, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7183), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7184), 41, "ServiceDefinitionField", "Notiz" },
                    { 10392, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7186), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7188), 44, "ServiceDefinitionField", "Not" },
                    { 10393, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7189), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7190), 44, "ServiceDefinitionField", "Note" },
                    { 10394, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7192), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7194), 44, "ServiceDefinitionField", "Примечание" },
                    { 10395, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7196), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7197), 44, "ServiceDefinitionField", "Note" },
                    { 10396, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7198), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7200), 44, "ServiceDefinitionField", "Nota" },
                    { 10397, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7201), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7202), 44, "ServiceDefinitionField", "ملاحظة" },
                    { 10398, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7204), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7205), 44, "ServiceDefinitionField", "Notiz" },
                    { 10399, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7322), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7323), 47, "ServiceDefinitionField", "Not" },
                    { 10400, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7325), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7326), 47, "ServiceDefinitionField", "Note" },
                    { 10401, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7329), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7330), 47, "ServiceDefinitionField", "Примечание" },
                    { 10402, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7332), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7333), 47, "ServiceDefinitionField", "Note" },
                    { 10403, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7336), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7337), 47, "ServiceDefinitionField", "Nota" },
                    { 10404, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7339), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7341), 47, "ServiceDefinitionField", "ملاحظة" },
                    { 10405, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7342), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7344), 47, "ServiceDefinitionField", "Notiz" },
                    { 10406, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7347), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7348), 52, "ServiceDefinitionField", "Not" },
                    { 10407, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7350), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7351), 52, "ServiceDefinitionField", "Note" },
                    { 10408, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7353), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7354), 52, "ServiceDefinitionField", "Примечание" },
                    { 10409, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7356), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7357), 52, "ServiceDefinitionField", "Note" },
                    { 10410, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7360), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7361), 52, "ServiceDefinitionField", "Nota" },
                    { 10411, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7363), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7364), 52, "ServiceDefinitionField", "ملاحظة" },
                    { 10412, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7366), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7367), 52, "ServiceDefinitionField", "Notiz" },
                    { 10413, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7370), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7372), 57, "ServiceDefinitionField", "Not" },
                    { 10414, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7374), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7375), 57, "ServiceDefinitionField", "Note" },
                    { 10415, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7377), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7379), 57, "ServiceDefinitionField", "Примечание" },
                    { 10416, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7380), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7382), 57, "ServiceDefinitionField", "Note" },
                    { 10417, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7383), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7385), 57, "ServiceDefinitionField", "Nota" },
                    { 10418, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7387), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7388), 57, "ServiceDefinitionField", "ملاحظة" },
                    { 10419, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7390), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7392), 57, "ServiceDefinitionField", "Notiz" },
                    { 10420, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7394), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7395), 59, "ServiceDefinitionField", "Not" },
                    { 10421, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7397), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7398), 59, "ServiceDefinitionField", "Note" },
                    { 10422, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7400), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7401), 59, "ServiceDefinitionField", "Примечание" },
                    { 10423, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7403), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7404), 59, "ServiceDefinitionField", "Note" },
                    { 10424, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7406), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7407), 59, "ServiceDefinitionField", "Nota" },
                    { 10425, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7409), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7411), 59, "ServiceDefinitionField", "ملاحظة" },
                    { 10426, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7412), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7414), 59, "ServiceDefinitionField", "Notiz" },
                    { 10427, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7416), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7418), 61, "ServiceDefinitionField", "Not" },
                    { 10428, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7420), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7421), 61, "ServiceDefinitionField", "Note" },
                    { 10429, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7423), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7424), 61, "ServiceDefinitionField", "Примечание" },
                    { 10430, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7426), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7427), 61, "ServiceDefinitionField", "Note" },
                    { 10431, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7429), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7430), 61, "ServiceDefinitionField", "Nota" },
                    { 10432, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7432), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7433), 61, "ServiceDefinitionField", "ملاحظة" },
                    { 10433, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7436), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7437), 61, "ServiceDefinitionField", "Notiz" },
                    { 10434, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7439), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7440), 64, "ServiceDefinitionField", "Not" },
                    { 10435, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7442), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7444), 64, "ServiceDefinitionField", "Note" },
                    { 10436, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7446), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7447), 64, "ServiceDefinitionField", "Примечание" },
                    { 10437, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7449), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7450), 64, "ServiceDefinitionField", "Note" },
                    { 10438, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7453), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7455), 64, "ServiceDefinitionField", "Nota" },
                    { 10439, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7457), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7458), 64, "ServiceDefinitionField", "ملاحظة" },
                    { 10440, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7460), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7462), 64, "ServiceDefinitionField", "Notiz" },
                    { 10441, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7469), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7470), 18, "ServiceDefinitionField", "Bagaj adedi" },
                    { 10442, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7472), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7474), 18, "ServiceDefinitionField", "Number of bags" },
                    { 10443, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7476), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7478), 18, "ServiceDefinitionField", "Количество багажа" },
                    { 10444, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7480), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7481), 18, "ServiceDefinitionField", "Nombre de bagages" },
                    { 10445, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7483), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7484), 18, "ServiceDefinitionField", "Cantidad de equipaje" },
                    { 10446, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7487), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7488), 18, "ServiceDefinitionField", "عدد الحقائب" },
                    { 10447, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7491), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7492), 18, "ServiceDefinitionField", "Anzahl Gepaeckstuecke" },
                    { 10448, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7496), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7497), 19, "ServiceDefinitionField", "Alinacak konum" },
                    { 10449, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7499), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7501), 19, "ServiceDefinitionField", "Pickup location" },
                    { 10450, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7503), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7504), 19, "ServiceDefinitionField", "Место получения" },
                    { 10451, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7506), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7507), 19, "ServiceDefinitionField", "Lieu de prise en charge" },
                    { 10452, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7509), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7511), 19, "ServiceDefinitionField", "Lugar de recogida" },
                    { 10453, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7513), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7514), 19, "ServiceDefinitionField", "مكان الاستلام" },
                    { 10454, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7516), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7517), 19, "ServiceDefinitionField", "Abholort" },
                    { 10455, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7531), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7532), 21, "ServiceDefinitionField", "Adet" },
                    { 10456, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7534), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7536), 21, "ServiceDefinitionField", "Quantity" },
                    { 10457, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7538), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7539), 21, "ServiceDefinitionField", "Количество" },
                    { 10458, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7541), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7542), 21, "ServiceDefinitionField", "Quantite" },
                    { 10459, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7544), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7546), 21, "ServiceDefinitionField", "Cantidad" },
                    { 10460, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7548), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7549), 21, "ServiceDefinitionField", "العدد" },
                    { 10461, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7552), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7553), 21, "ServiceDefinitionField", "Anzahl" },
                    { 10462, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7556), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7557), 24, "ServiceDefinitionField", "Adet" },
                    { 10463, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7560), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7561), 24, "ServiceDefinitionField", "Quantity" },
                    { 10464, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7563), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7564), 24, "ServiceDefinitionField", "Количество" },
                    { 10465, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7566), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7567), 24, "ServiceDefinitionField", "Quantite" },
                    { 10466, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7569), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7570), 24, "ServiceDefinitionField", "Cantidad" },
                    { 10467, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7572), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7573), 24, "ServiceDefinitionField", "العدد" },
                    { 10468, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7575), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7576), 24, "ServiceDefinitionField", "Anzahl" },
                    { 10469, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7579), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7581), 27, "ServiceDefinitionField", "Adet" },
                    { 10470, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7583), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7584), 27, "ServiceDefinitionField", "Quantity" },
                    { 10471, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7586), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7587), 27, "ServiceDefinitionField", "Количество" },
                    { 10472, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7589), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7590), 27, "ServiceDefinitionField", "Quantite" },
                    { 10473, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7592), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7594), 27, "ServiceDefinitionField", "Cantidad" },
                    { 10474, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7596), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7597), 27, "ServiceDefinitionField", "العدد" },
                    { 10475, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7599), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7600), 27, "ServiceDefinitionField", "Anzahl" },
                    { 10476, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7602), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7604), 30, "ServiceDefinitionField", "Adet" },
                    { 10477, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7605), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7607), 30, "ServiceDefinitionField", "Quantity" },
                    { 10478, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7609), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7610), 30, "ServiceDefinitionField", "Количество" },
                    { 10479, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7612), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7613), 30, "ServiceDefinitionField", "Quantite" },
                    { 10480, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7615), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7616), 30, "ServiceDefinitionField", "Cantidad" },
                    { 10481, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7618), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7620), 30, "ServiceDefinitionField", "العدد" },
                    { 10482, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7622), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7623), 30, "ServiceDefinitionField", "Anzahl" },
                    { 10483, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7625), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7626), 33, "ServiceDefinitionField", "Adet" },
                    { 10484, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7629), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7630), 33, "ServiceDefinitionField", "Quantity" },
                    { 10485, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7631), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7633), 33, "ServiceDefinitionField", "Количество" },
                    { 10486, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7634), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7636), 33, "ServiceDefinitionField", "Quantite" },
                    { 10487, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7637), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7639), 33, "ServiceDefinitionField", "Cantidad" },
                    { 10488, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7641), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7642), 33, "ServiceDefinitionField", "العدد" },
                    { 10489, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7644), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7646), 33, "ServiceDefinitionField", "Anzahl" },
                    { 10490, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7648), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7649), 36, "ServiceDefinitionField", "Adet" },
                    { 10491, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7650), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7652), 36, "ServiceDefinitionField", "Quantity" },
                    { 10492, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7654), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7655), 36, "ServiceDefinitionField", "Количество" },
                    { 10493, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7657), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7659), 36, "ServiceDefinitionField", "Quantite" },
                    { 10494, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7661), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7662), 36, "ServiceDefinitionField", "Cantidad" },
                    { 10495, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7664), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7666), 36, "ServiceDefinitionField", "العدد" },
                    { 10496, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7668), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7669), 36, "ServiceDefinitionField", "Anzahl" },
                    { 10497, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7671), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7673), 39, "ServiceDefinitionField", "Adet" },
                    { 10498, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7749), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7750), 39, "ServiceDefinitionField", "Quantity" },
                    { 10499, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7753), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7754), 39, "ServiceDefinitionField", "Количество" },
                    { 10500, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7756), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7757), 39, "ServiceDefinitionField", "Quantite" },
                    { 10501, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7759), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7761), 39, "ServiceDefinitionField", "Cantidad" },
                    { 10502, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7763), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7764), 39, "ServiceDefinitionField", "العدد" },
                    { 10503, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7766), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7767), 39, "ServiceDefinitionField", "Anzahl" },
                    { 10504, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7770), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7772), 63, "ServiceDefinitionField", "Adet" },
                    { 10505, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7774), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7775), 63, "ServiceDefinitionField", "Quantity" },
                    { 10506, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7778), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7780), 63, "ServiceDefinitionField", "Количество" },
                    { 10507, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7782), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7783), 63, "ServiceDefinitionField", "Quantite" },
                    { 10508, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7786), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7787), 63, "ServiceDefinitionField", "Cantidad" },
                    { 10509, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7789), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7790), 63, "ServiceDefinitionField", "العدد" },
                    { 10510, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7792), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7793), 63, "ServiceDefinitionField", "Anzahl" },
                    { 10511, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7806), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7807), 22, "ServiceDefinitionField", "Teslim alinma saati" },
                    { 10512, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7809), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7811), 22, "ServiceDefinitionField", "Pickup time" },
                    { 10513, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7886), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7887), 22, "ServiceDefinitionField", "Время получения" },
                    { 10514, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7890), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7891), 22, "ServiceDefinitionField", "Heure de prise en charge" },
                    { 10515, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7893), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7894), 22, "ServiceDefinitionField", "Hora de recogida" },
                    { 10516, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7896), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7898), 22, "ServiceDefinitionField", "وقت الاستلام" },
                    { 10517, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7900), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7901), 22, "ServiceDefinitionField", "Abholzeit" },
                    { 10518, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7917), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7918), 25, "ServiceDefinitionField", "Teslim alinma saati" },
                    { 10519, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7920), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7922), 25, "ServiceDefinitionField", "Pickup time" },
                    { 10520, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7924), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7925), 25, "ServiceDefinitionField", "Время получения" },
                    { 10521, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7927), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7929), 25, "ServiceDefinitionField", "Heure de prise en charge" },
                    { 10522, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7931), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7932), 25, "ServiceDefinitionField", "Hora de recogida" },
                    { 10523, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7935), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7936), 25, "ServiceDefinitionField", "وقت الاستلام" },
                    { 10524, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7938), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7939), 25, "ServiceDefinitionField", "Abholzeit" },
                    { 10525, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7942), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7943), 28, "ServiceDefinitionField", "Teslim alinma saati" },
                    { 10526, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7945), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7947), 28, "ServiceDefinitionField", "Pickup time" },
                    { 10527, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7950), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7951), 28, "ServiceDefinitionField", "Время получения" },
                    { 10528, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7953), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7954), 28, "ServiceDefinitionField", "Heure de prise en charge" },
                    { 10529, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7956), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7957), 28, "ServiceDefinitionField", "Hora de recogida" },
                    { 10530, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7959), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7961), 28, "ServiceDefinitionField", "وقت الاستلام" },
                    { 10531, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7962), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7964), 28, "ServiceDefinitionField", "Abholzeit" },
                    { 10532, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7967), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7968), 31, "ServiceDefinitionField", "Teslim alinma saati" },
                    { 10533, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7970), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7971), 31, "ServiceDefinitionField", "Pickup time" },
                    { 10534, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7973), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7974), 31, "ServiceDefinitionField", "Время получения" },
                    { 10535, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7976), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7977), 31, "ServiceDefinitionField", "Heure de prise en charge" },
                    { 10536, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7979), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7981), 31, "ServiceDefinitionField", "Hora de recogida" },
                    { 10537, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7983), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7984), 31, "ServiceDefinitionField", "وقت الاستلام" },
                    { 10538, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7986), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7988), 31, "ServiceDefinitionField", "Abholzeit" },
                    { 10539, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7990), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7991), 34, "ServiceDefinitionField", "Teslim alinma saati" },
                    { 10540, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7993), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7995), 34, "ServiceDefinitionField", "Pickup time" },
                    { 10541, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7997), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(7998), 34, "ServiceDefinitionField", "Время получения" },
                    { 10542, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8000), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8002), 34, "ServiceDefinitionField", "Heure de prise en charge" },
                    { 10543, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8004), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8005), 34, "ServiceDefinitionField", "Hora de recogida" },
                    { 10544, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8007), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8009), 34, "ServiceDefinitionField", "وقت الاستلام" },
                    { 10545, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8010), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8011), 34, "ServiceDefinitionField", "Abholzeit" },
                    { 10546, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8014), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8015), 37, "ServiceDefinitionField", "Teslim alinma saati" },
                    { 10547, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8017), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8018), 37, "ServiceDefinitionField", "Pickup time" },
                    { 10548, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8020), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8021), 37, "ServiceDefinitionField", "Время получения" },
                    { 10549, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8023), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8024), 37, "ServiceDefinitionField", "Heure de prise en charge" },
                    { 10550, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8027), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8029), 37, "ServiceDefinitionField", "Hora de recogida" },
                    { 10551, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8031), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8032), 37, "ServiceDefinitionField", "وقت الاستلام" },
                    { 10552, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8034), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8035), 37, "ServiceDefinitionField", "Abholzeit" },
                    { 10553, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8037), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8038), 40, "ServiceDefinitionField", "Teslim alinma saati" },
                    { 10554, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8040), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8042), 40, "ServiceDefinitionField", "Pickup time" },
                    { 10555, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8043), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8045), 40, "ServiceDefinitionField", "Время получения" },
                    { 10556, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8046), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8048), 40, "ServiceDefinitionField", "Heure de prise en charge" },
                    { 10557, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8050), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8051), 40, "ServiceDefinitionField", "Hora de recogida" },
                    { 10558, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8053), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8054), 40, "ServiceDefinitionField", "وقت الاستلام" },
                    { 10559, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8056), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8058), 40, "ServiceDefinitionField", "Abholzeit" },
                    { 10560, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8070), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8071), 42, "ServiceDefinitionField", "Randevu zamani" },
                    { 10561, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8073), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8074), 42, "ServiceDefinitionField", "Appointment time" },
                    { 10562, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8076), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8078), 42, "ServiceDefinitionField", "Время записи" },
                    { 10563, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8080), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8081), 42, "ServiceDefinitionField", "Heure du rendez-vous" },
                    { 10564, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8083), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8085), 42, "ServiceDefinitionField", "Hora de cita" },
                    { 10565, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8087), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8088), 42, "ServiceDefinitionField", "وقت الموعد" },
                    { 10566, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8090), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8091), 42, "ServiceDefinitionField", "Terminzeit" },
                    { 10567, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8094), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8096), 45, "ServiceDefinitionField", "Randevu zamani" },
                    { 10568, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8098), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8099), 45, "ServiceDefinitionField", "Appointment time" },
                    { 10569, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8101), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8102), 45, "ServiceDefinitionField", "Время записи" },
                    { 10570, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8104), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8106), 45, "ServiceDefinitionField", "Heure du rendez-vous" },
                    { 10571, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8108), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8109), 45, "ServiceDefinitionField", "Hora de cita" },
                    { 10572, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8112), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8113), 45, "ServiceDefinitionField", "وقت الموعد" },
                    { 10573, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8115), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8116), 45, "ServiceDefinitionField", "Terminzeit" },
                    { 10574, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8119), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8120), 67, "ServiceDefinitionField", "Randevu zamani" },
                    { 10575, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8122), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8123), 67, "ServiceDefinitionField", "Appointment time" },
                    { 10576, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8126), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8127), 67, "ServiceDefinitionField", "Время записи" },
                    { 10577, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8129), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8130), 67, "ServiceDefinitionField", "Heure du rendez-vous" },
                    { 10578, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8132), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8133), 67, "ServiceDefinitionField", "Hora de cita" },
                    { 10579, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8136), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8137), 67, "ServiceDefinitionField", "وقت الموعد" },
                    { 10580, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8139), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8140), 67, "ServiceDefinitionField", "Terminzeit" },
                    { 10581, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8145), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8146), 43, "ServiceDefinitionField", "Terapist tercihi" },
                    { 10582, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8148), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8150), 43, "ServiceDefinitionField", "Therapist preference" },
                    { 10583, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8152), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8153), 43, "ServiceDefinitionField", "Предпочтение терапевта" },
                    { 10584, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8156), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8157), 43, "ServiceDefinitionField", "Preference de therapeute" },
                    { 10585, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8159), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8160), 43, "ServiceDefinitionField", "Preferencia de terapeuta" },
                    { 10586, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8163), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8164), 43, "ServiceDefinitionField", "تفضيل المعالج" },
                    { 10587, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8166), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8167), 43, "ServiceDefinitionField", "Therapeutenwunsch" },
                    { 10588, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8169), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8171), 46, "ServiceDefinitionField", "Terapist tercihi" },
                    { 10589, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8172), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8174), 46, "ServiceDefinitionField", "Therapist preference" },
                    { 10590, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8175), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8177), 46, "ServiceDefinitionField", "Предпочтение терапевта" },
                    { 10591, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8179), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8180), 46, "ServiceDefinitionField", "Preference de therapeute" },
                    { 10592, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8182), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8183), 46, "ServiceDefinitionField", "Preferencia de terapeuta" },
                    { 10593, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8185), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8186), 46, "ServiceDefinitionField", "تفضيل المعالج" },
                    { 10594, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8188), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8189), 46, "ServiceDefinitionField", "Therapeutenwunsch" },
                    { 10595, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8258), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8259), 48, "ServiceDefinitionField", "Nereden" },
                    { 10596, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8261), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8262), 48, "ServiceDefinitionField", "From" },
                    { 10597, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8264), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8265), 48, "ServiceDefinitionField", "Откуда" },
                    { 10598, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8267), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8268), 48, "ServiceDefinitionField", "De" },
                    { 10599, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8270), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8272), 48, "ServiceDefinitionField", "Desde" },
                    { 10600, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8274), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8275), 48, "ServiceDefinitionField", "من" },
                    { 10601, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8277), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8278), 48, "ServiceDefinitionField", "Von" },
                    { 10602, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8283), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8284), 49, "ServiceDefinitionField", "Nereye" },
                    { 10603, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8286), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8287), 49, "ServiceDefinitionField", "To" },
                    { 10604, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8290), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8291), 49, "ServiceDefinitionField", "Куда" },
                    { 10605, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8293), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8294), 49, "ServiceDefinitionField", "Vers" },
                    { 10606, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8296), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8297), 49, "ServiceDefinitionField", "Hacia" },
                    { 10607, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8299), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8300), 49, "ServiceDefinitionField", "إلى" },
                    { 10608, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8302), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8303), 49, "ServiceDefinitionField", "Nach" },
                    { 10609, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8307), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8308), 50, "ServiceDefinitionField", "Kisi sayisi" },
                    { 10610, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8310), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8311), 50, "ServiceDefinitionField", "Passenger count" },
                    { 10611, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8313), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8314), 50, "ServiceDefinitionField", "Количество пассажиров" },
                    { 10612, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8316), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8317), 50, "ServiceDefinitionField", "Nombre de personnes" },
                    { 10613, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8320), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8321), 50, "ServiceDefinitionField", "Numero de personas" },
                    { 10614, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8323), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8324), 50, "ServiceDefinitionField", "عدد الأشخاص" },
                    { 10615, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8325), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8327), 50, "ServiceDefinitionField", "Personenzahl" },
                    { 10616, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8332), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8333), 51, "ServiceDefinitionField", "Talep edilen zaman" },
                    { 10617, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8335), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8336), 51, "ServiceDefinitionField", "Requested time" },
                    { 10618, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8338), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8339), 51, "ServiceDefinitionField", "Запрошенное время" },
                    { 10619, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8341), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8342), 51, "ServiceDefinitionField", "Heure demandee" },
                    { 10620, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8344), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8345), 51, "ServiceDefinitionField", "Hora solicitada" },
                    { 10621, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8347), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8348), 51, "ServiceDefinitionField", "الوقت المطلوب" },
                    { 10622, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8350), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8351), 51, "ServiceDefinitionField", "Gewuenschte Zeit" },
                    { 10623, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8353), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8354), 55, "ServiceDefinitionField", "Talep edilen zaman" },
                    { 10624, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8357), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8358), 55, "ServiceDefinitionField", "Requested time" },
                    { 10625, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8360), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8361), 55, "ServiceDefinitionField", "Запрошенное время" },
                    { 10626, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8363), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8364), 55, "ServiceDefinitionField", "Heure demandee" },
                    { 10627, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8366), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8367), 55, "ServiceDefinitionField", "Hora solicitada" },
                    { 10628, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8369), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8370), 55, "ServiceDefinitionField", "الوقت المطلوب" },
                    { 10629, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8372), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8373), 55, "ServiceDefinitionField", "Gewuenschte Zeit" },
                    { 10630, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8377), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8378), 53, "ServiceDefinitionField", "Plaka" },
                    { 10631, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8379), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8380), 53, "ServiceDefinitionField", "Plate number" },
                    { 10632, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8382), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8383), 53, "ServiceDefinitionField", "Номер автомобиля" },
                    { 10633, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8385), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8386), 53, "ServiceDefinitionField", "Plaque d'immatriculation" },
                    { 10634, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8388), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8389), 53, "ServiceDefinitionField", "Matricula" },
                    { 10635, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8391), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8392), 53, "ServiceDefinitionField", "رقم اللوحة" },
                    { 10636, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8394), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8395), 53, "ServiceDefinitionField", "Kennzeichen" },
                    { 10637, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8400), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8401), 54, "ServiceDefinitionField", "Arac konumu" },
                    { 10638, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8403), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8405), 54, "ServiceDefinitionField", "Vehicle location" },
                    { 10639, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8407), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8408), 54, "ServiceDefinitionField", "Местоположение автомобиля" },
                    { 10640, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8410), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8411), 54, "ServiceDefinitionField", "Emplacement du vehicule" },
                    { 10641, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8412), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8414), 54, "ServiceDefinitionField", "Ubicacion del vehiculo" },
                    { 10642, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8415), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8416), 54, "ServiceDefinitionField", "موقع المركبة" },
                    { 10643, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8418), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8420), 54, "ServiceDefinitionField", "Fahrzeugstandort" },
                    { 10644, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8424), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8425), 56, "ServiceDefinitionField", "Urunler" },
                    { 10645, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8427), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8428), 56, "ServiceDefinitionField", "Items" },
                    { 10646, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8430), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8431), 56, "ServiceDefinitionField", "Товары" },
                    { 10647, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8433), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8434), 56, "ServiceDefinitionField", "Articles" },
                    { 10648, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8436), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8437), 56, "ServiceDefinitionField", "Articulos" },
                    { 10649, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8439), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8440), 56, "ServiceDefinitionField", "العناصر" },
                    { 10650, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8441), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8442), 56, "ServiceDefinitionField", "Artikel" },
                    { 10651, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8446), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8448), 58, "ServiceDefinitionField", "Uyandirma saati" },
                    { 10652, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8449), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8450), 58, "ServiceDefinitionField", "Wake-up time" },
                    { 10653, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8452), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8454), 58, "ServiceDefinitionField", "Время будильника" },
                    { 10654, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8456), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8457), 58, "ServiceDefinitionField", "Heure de reveil" },
                    { 10655, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8458), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8459), 58, "ServiceDefinitionField", "Hora de despertar" },
                    { 10656, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8461), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8463), 58, "ServiceDefinitionField", "وقت الإيقاظ" },
                    { 10657, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8465), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8466), 58, "ServiceDefinitionField", "Weckzeit" },
                    { 10658, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8469), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8470), 60, "ServiceDefinitionField", "Talep edilen cikis saati" },
                    { 10659, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8472), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8473), 60, "ServiceDefinitionField", "Requested checkout time" },
                    { 10660, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8476), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8477), 60, "ServiceDefinitionField", "Запрошенное время выезда" },
                    { 10661, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8479), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8480), 60, "ServiceDefinitionField", "Heure de depart demandee" },
                    { 10662, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8482), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8483), 60, "ServiceDefinitionField", "Hora de salida solicitada" },
                    { 10663, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8485), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8486), 60, "ServiceDefinitionField", "وقت المغادرة المطلوب" },
                    { 10664, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8488), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8489), 60, "ServiceDefinitionField", "Gewuenschte Check-out-Zeit" },
                    { 10665, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8493), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8494), 62, "ServiceDefinitionField", "Malzeme tipi" },
                    { 10666, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8496), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8497), 62, "ServiceDefinitionField", "Amenity type" },
                    { 10667, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8499), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8500), 62, "ServiceDefinitionField", "Тип принадлежности" },
                    { 10668, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8502), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8503), 62, "ServiceDefinitionField", "Type d'equipement" },
                    { 10669, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8505), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8506), 62, "ServiceDefinitionField", "Tipo de amenidad" },
                    { 10670, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8508), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8509), 62, "ServiceDefinitionField", "نوع المستلزمات" },
                    { 10671, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8511), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8512), 62, "ServiceDefinitionField", "Ausstattungstyp" },
                    { 10672, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8516), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8517), 65, "ServiceDefinitionField", "Belirti/aciklama" },
                    { 10673, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8519), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8520), 65, "ServiceDefinitionField", "Symptoms/description" },
                    { 10674, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8522), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8523), 65, "ServiceDefinitionField", "Симптомы/описание" },
                    { 10675, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8525), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8526), 65, "ServiceDefinitionField", "Symptomes/description" },
                    { 10676, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8528), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8529), 65, "ServiceDefinitionField", "Sintomas/descripcion" },
                    { 10677, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8531), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8532), 65, "ServiceDefinitionField", "الأعراض/الوصف" },
                    { 10678, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8534), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8535), 65, "ServiceDefinitionField", "Symptome/Beschreibung" },
                    { 10679, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8538), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8540), 66, "ServiceDefinitionField", "Doktor gerekli mi?" },
                    { 10680, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8542), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8543), 66, "ServiceDefinitionField", "Is a doctor required?" },
                    { 10681, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8544), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8546), 66, "ServiceDefinitionField", "Нужен врач?" },
                    { 10682, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8547), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8548), 66, "ServiceDefinitionField", "Un medecin est-il necessaire?" },
                    { 10683, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8550), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8551), 66, "ServiceDefinitionField", "Se requiere medico?" },
                    { 10684, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8554), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8555), 66, "ServiceDefinitionField", "هل الطبيب مطلوب؟" },
                    { 10685, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8557), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8558), 66, "ServiceDefinitionField", "Ist ein Arzt erforderlich?" },
                    { 10686, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8561), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8563), 68, "ServiceDefinitionField", "Bildirim tipi" },
                    { 10687, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8565), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8566), 68, "ServiceDefinitionField", "Incident type" },
                    { 10688, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8762), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8763), 68, "ServiceDefinitionField", "Тип сообщения" },
                    { 10689, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8766), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8767), 68, "ServiceDefinitionField", "Type d'incident" },
                    { 10690, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8769), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8770), 68, "ServiceDefinitionField", "Tipo de incidencia" },
                    { 10691, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8772), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8774), 68, "ServiceDefinitionField", "نوع البلاغ" },
                    { 10692, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8776), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8777), 68, "ServiceDefinitionField", "Meldungstyp" },
                    { 10693, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8783), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8784), 69, "ServiceDefinitionField", "Aciklama" },
                    { 10694, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8786), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8787), 69, "ServiceDefinitionField", "Description" },
                    { 10695, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8790), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8791), 69, "ServiceDefinitionField", "Описание" },
                    { 10696, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8793), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8794), 69, "ServiceDefinitionField", "Description" },
                    { 10697, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8796), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8797), 69, "ServiceDefinitionField", "Descripcion" },
                    { 10698, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8800), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8801), 69, "ServiceDefinitionField", "الوصف" },
                    { 10699, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8803), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8805), 69, "ServiceDefinitionField", "Beschreibung" },
                    { 10700, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8808), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8810), 70, "ServiceDefinitionField", "Fotograf" },
                    { 10701, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8812), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8813), 70, "ServiceDefinitionField", "Photo" },
                    { 10702, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8815), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8817), 70, "ServiceDefinitionField", "Фото" },
                    { 10703, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8818), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8820), 70, "ServiceDefinitionField", "Photo" },
                    { 10704, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8822), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8823), 70, "ServiceDefinitionField", "Foto" },
                    { 10705, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8825), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8826), 70, "ServiceDefinitionField", "صورة" },
                    { 10706, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8828), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8830), 70, "ServiceDefinitionField", "Foto" },
                    { 10707, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8834), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8835), 71, "ServiceDefinitionField", "Konu" },
                    { 10708, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8837), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8838), 71, "ServiceDefinitionField", "Topic" },
                    { 10709, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8841), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8842), 71, "ServiceDefinitionField", "Тема" },
                    { 10710, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8844), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8845), 71, "ServiceDefinitionField", "Sujet" },
                    { 10711, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8847), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8848), 71, "ServiceDefinitionField", "Tema" },
                    { 10712, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8850), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8851), 71, "ServiceDefinitionField", "الموضوع" },
                    { 10713, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8853), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8854), 71, "ServiceDefinitionField", "Thema" },
                    { 10714, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8858), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8859), 72, "ServiceDefinitionField", "Soru" },
                    { 10715, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8861), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8862), 72, "ServiceDefinitionField", "Question" },
                    { 10716, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8864), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8865), 72, "ServiceDefinitionField", "Вопрос" },
                    { 10717, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8867), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8868), 72, "ServiceDefinitionField", "Question" },
                    { 10718, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8871), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8872), 72, "ServiceDefinitionField", "Pregunta" },
                    { 10719, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8874), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8875), 72, "ServiceDefinitionField", "سؤال" },
                    { 10720, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8877), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8879), 72, "ServiceDefinitionField", "Frage" },
                    { 10721, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8883), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8884), 73, "ServiceDefinitionField", "Siparis notu" },
                    { 10722, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8886), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8887), 73, "ServiceDefinitionField", "Order note" },
                    { 10723, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8889), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8890), 73, "ServiceDefinitionField", "Примечание к заказу" },
                    { 10724, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8892), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8893), 73, "ServiceDefinitionField", "Note de commande" },
                    { 10725, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8896), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8897), 73, "ServiceDefinitionField", "Nota del pedido" },
                    { 10726, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8899), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8900), 73, "ServiceDefinitionField", "ملاحظة الطلب" },
                    { 10727, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8902), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8903), 73, "ServiceDefinitionField", "Bestellnotiz" },
                    { 10728, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8907), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8908), 1, "ServiceDefinitionFieldOption", "Ek yastik" },
                    { 10729, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8910), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8911), 1, "ServiceDefinitionFieldOption", "Extra pillow" },
                    { 10730, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8914), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8915), 1, "ServiceDefinitionFieldOption", "Дополнительная подушка" },
                    { 10731, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8917), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8918), 1, "ServiceDefinitionFieldOption", "Oreiller supplementaire" },
                    { 10732, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8920), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8921), 1, "ServiceDefinitionFieldOption", "Almohada extra" },
                    { 10733, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8923), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8924), 1, "ServiceDefinitionFieldOption", "وسادة إضافية" },
                    { 10734, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8926), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8927), 1, "ServiceDefinitionFieldOption", "Zusatzkissen" },
                    { 10735, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8930), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8931), 2, "ServiceDefinitionFieldOption", "Bebek yatagi" },
                    { 10736, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8933), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8934), 2, "ServiceDefinitionFieldOption", "Baby bed" },
                    { 10737, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8936), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8937), 2, "ServiceDefinitionFieldOption", "Детская кровать" },
                    { 10738, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8939), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8941), 2, "ServiceDefinitionFieldOption", "Lit bebe" },
                    { 10739, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8943), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8945), 2, "ServiceDefinitionFieldOption", "Cuna" },
                    { 10740, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8947), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8948), 2, "ServiceDefinitionFieldOption", "سرير طفل" },
                    { 10741, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8950), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8952), 2, "ServiceDefinitionFieldOption", "Babybett" },
                    { 10742, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8953), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8955), 3, "ServiceDefinitionFieldOption", "Battaniye" },
                    { 10743, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8957), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8958), 3, "ServiceDefinitionFieldOption", "Blanket" },
                    { 10744, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8960), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8962), 3, "ServiceDefinitionFieldOption", "Одеяло" },
                    { 10745, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8964), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8965), 3, "ServiceDefinitionFieldOption", "Couverture" },
                    { 10746, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8967), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8968), 3, "ServiceDefinitionFieldOption", "Manta" },
                    { 10747, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8970), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8972), 3, "ServiceDefinitionFieldOption", "بطانية" },
                    { 10748, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8973), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8974), 3, "ServiceDefinitionFieldOption", "Decke" },
                    { 10749, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8977), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8978), 4, "ServiceDefinitionFieldOption", "Utu masasi" },
                    { 10750, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8980), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8981), 4, "ServiceDefinitionFieldOption", "Ironing board" },
                    { 10751, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8984), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8985), 4, "ServiceDefinitionFieldOption", "Гладильная доска" },
                    { 10752, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8987), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8989), 4, "ServiceDefinitionFieldOption", "Planche a repasser" },
                    { 10753, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8991), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8992), 4, "ServiceDefinitionFieldOption", "Tabla de planchar" },
                    { 10754, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8994), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8995), 4, "ServiceDefinitionFieldOption", "طاولة كي" },
                    { 10755, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8997), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(8998), 4, "ServiceDefinitionFieldOption", "Buegelbrett" },
                    { 10756, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9000), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9002), 5, "ServiceDefinitionFieldOption", "Diger" },
                    { 10757, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9004), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9005), 5, "ServiceDefinitionFieldOption", "Other" },
                    { 10758, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9007), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9009), 5, "ServiceDefinitionFieldOption", "Другое" },
                    { 10759, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9010), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9012), 5, "ServiceDefinitionFieldOption", "Autre" },
                    { 10760, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9013), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9015), 5, "ServiceDefinitionFieldOption", "Otro" },
                    { 10761, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9017), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9018), 5, "ServiceDefinitionFieldOption", "أخرى" },
                    { 10762, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9020), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9021), 5, "ServiceDefinitionFieldOption", "Andere" },
                    { 10763, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9023), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9025), 6, "ServiceDefinitionFieldOption", "Saglik" },
                    { 10764, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9027), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9028), 6, "ServiceDefinitionFieldOption", "Health" },
                    { 10765, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9030), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9031), 6, "ServiceDefinitionFieldOption", "Здоровье" },
                    { 10766, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9033), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9034), 6, "ServiceDefinitionFieldOption", "Sante" },
                    { 10767, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9037), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9038), 6, "ServiceDefinitionFieldOption", "Salud" },
                    { 10768, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9041), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9042), 6, "ServiceDefinitionFieldOption", "صحة" },
                    { 10769, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9044), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9045), 6, "ServiceDefinitionFieldOption", "Gesundheit" },
                    { 10770, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9048), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9049), 7, "ServiceDefinitionFieldOption", "Guvenlik" },
                    { 10771, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9051), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9052), 7, "ServiceDefinitionFieldOption", "Security" },
                    { 10772, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9055), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9056), 7, "ServiceDefinitionFieldOption", "Безопасность" },
                    { 10773, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9057), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9059), 7, "ServiceDefinitionFieldOption", "Securite" },
                    { 10774, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9061), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9062), 7, "ServiceDefinitionFieldOption", "Seguridad" },
                    { 10775, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9064), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9065), 7, "ServiceDefinitionFieldOption", "الأمن" },
                    { 10776, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9067), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9068), 7, "ServiceDefinitionFieldOption", "Sicherheit" },
                    { 10777, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9071), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9072), 8, "ServiceDefinitionFieldOption", "Ilk yardim" },
                    { 10778, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9074), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9075), 8, "ServiceDefinitionFieldOption", "First aid" },
                    { 10779, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9077), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9078), 8, "ServiceDefinitionFieldOption", "Первая помощь" },
                    { 10780, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9080), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9082), 8, "ServiceDefinitionFieldOption", "Premiers secours" },
                    { 10781, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9083), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9085), 8, "ServiceDefinitionFieldOption", "Primeros auxilios" },
                    { 10782, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9086), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9088), 8, "ServiceDefinitionFieldOption", "إسعافات أولية" },
                    { 10783, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9089), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9091), 8, "ServiceDefinitionFieldOption", "Erste Hilfe" },
                    { 10784, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9093), "Label", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9094), 9, "ServiceDefinitionFieldOption", "Diger" },
                    { 10785, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9096), "Label", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9097), 9, "ServiceDefinitionFieldOption", "Other" },
                    { 10786, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9256), "Label", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9257), 9, "ServiceDefinitionFieldOption", "Другое" },
                    { 10787, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9259), "Label", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9261), 9, "ServiceDefinitionFieldOption", "Autre" },
                    { 10788, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9263), "Label", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9264), 9, "ServiceDefinitionFieldOption", "Otro" },
                    { 10789, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9266), "Label", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9267), 9, "ServiceDefinitionFieldOption", "أخرى" },
                    { 10790, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9270), "Label", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9271), 9, "ServiceDefinitionFieldOption", "Andere" },
                    { 10791, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9275), "DisplayName", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9276), 1, "ServiceRequestStatus", "Bekliyor" },
                    { 10792, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9278), "DisplayName", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9279), 1, "ServiceRequestStatus", "Pending" },
                    { 10793, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9282), "DisplayName", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9283), 1, "ServiceRequestStatus", "Ожидает" },
                    { 10794, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9285), "DisplayName", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9286), 1, "ServiceRequestStatus", "En attente" },
                    { 10795, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9288), "DisplayName", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9289), 1, "ServiceRequestStatus", "Pendiente" },
                    { 10796, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9291), "DisplayName", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9293), 1, "ServiceRequestStatus", "قيد الانتظار" },
                    { 10797, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9295), "DisplayName", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9296), 1, "ServiceRequestStatus", "Ausstehend" },
                    { 10798, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9299), "DisplayName", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9300), 2, "ServiceRequestStatus", "Hazirlaniyor" },
                    { 10799, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9302), "DisplayName", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9304), 2, "ServiceRequestStatus", "Preparing" },
                    { 10800, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9305), "DisplayName", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9307), 2, "ServiceRequestStatus", "Готовится" },
                    { 10801, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9308), "DisplayName", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9309), 2, "ServiceRequestStatus", "En preparation" },
                    { 10802, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9312), "DisplayName", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9313), 2, "ServiceRequestStatus", "Preparando" },
                    { 10803, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9315), "DisplayName", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9316), 2, "ServiceRequestStatus", "قيد التحضير" },
                    { 10804, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9318), "DisplayName", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9319), 2, "ServiceRequestStatus", "In Vorbereitung" },
                    { 10805, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9321), "DisplayName", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9323), 8, "ServiceRequestStatus", "Yolda" },
                    { 10806, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9325), "DisplayName", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9326), 8, "ServiceRequestStatus", "On the way" },
                    { 10807, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9328), "DisplayName", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9329), 8, "ServiceRequestStatus", "В пути" },
                    { 10808, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9331), "DisplayName", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9333), 8, "ServiceRequestStatus", "En route" },
                    { 10809, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9335), "DisplayName", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9336), 8, "ServiceRequestStatus", "En camino" },
                    { 10810, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9338), "DisplayName", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9340), 8, "ServiceRequestStatus", "في الطريق" },
                    { 10811, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9342), "DisplayName", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9343), 8, "ServiceRequestStatus", "Unterwegs" },
                    { 10812, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9345), "DisplayName", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9346), 5, "ServiceRequestStatus", "Tamamlandi" },
                    { 10813, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9349), "DisplayName", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9350), 5, "ServiceRequestStatus", "Completed" },
                    { 10814, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9352), "DisplayName", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9353), 5, "ServiceRequestStatus", "Завершено" },
                    { 10815, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9355), "DisplayName", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9356), 5, "ServiceRequestStatus", "Termine" },
                    { 10816, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9358), "DisplayName", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9360), 5, "ServiceRequestStatus", "Completado" },
                    { 10817, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9362), "DisplayName", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9363), 5, "ServiceRequestStatus", "مكتمل" },
                    { 10818, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9365), "DisplayName", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9366), 5, "ServiceRequestStatus", "Abgeschlossen" },
                    { 10819, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9371), "DisplayName", true, false, "tr-TR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9372), 6, "ServiceRequestStatus", "Iptal Edildi" },
                    { 10820, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9374), "DisplayName", true, false, "en-US", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9375), 6, "ServiceRequestStatus", "Cancelled" },
                    { 10821, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9377), "DisplayName", true, false, "ru-RU", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9379), 6, "ServiceRequestStatus", "Отменено" },
                    { 10822, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9381), "DisplayName", true, false, "fr-FR", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9382), 6, "ServiceRequestStatus", "Annule" },
                    { 10823, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9384), "DisplayName", true, false, "es-ES", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9385), 6, "ServiceRequestStatus", "Cancelado" },
                    { 10824, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9387), "DisplayName", true, false, "ar-SA", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9388), 6, "ServiceRequestStatus", "ملغي" },
                    { 10825, new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9391), "DisplayName", true, false, "de-DE", new DateTime(2026, 6, 2, 17, 21, 34, 129, DateTimeKind.Local).AddTicks(9392), 6, "ServiceRequestStatus", "Storniert" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(5253), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(5452), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(5838), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(5938), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(6013), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(6084), new DateTime(2026, 6, 2, 17, 21, 34, 131, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDefinitionFieldOptions_ServiceDefinitionFieldId_Value",
                table: "ServiceDefinitionFieldOptions",
                columns: new[] { "ServiceDefinitionFieldId", "Value" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceDefinitionFieldOptions");

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "HotelServicePolicies",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10000);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10001);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10002);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10003);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10004);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10005);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10006);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10007);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10008);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10009);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10010);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10011);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10012);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10013);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10014);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10015);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10016);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10017);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10018);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10019);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10020);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10021);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10022);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10023);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10024);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10025);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10026);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10027);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10028);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10029);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10030);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10031);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10032);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10033);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10034);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10035);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10036);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10037);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10038);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10039);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10040);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10041);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10042);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10043);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10044);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10045);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10046);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10047);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10048);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10049);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10050);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10051);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10052);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10053);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10054);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10055);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10056);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10057);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10058);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10059);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10060);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10061);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10062);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10063);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10064);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10065);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10066);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10067);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10068);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10069);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10070);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10071);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10072);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10073);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10074);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10075);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10076);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10077);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10078);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10079);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10080);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10081);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10082);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10083);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10084);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10085);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10086);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10087);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10088);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10089);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10090);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10091);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10092);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10093);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10094);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10095);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10096);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10097);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10098);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10099);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10100);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10101);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10102);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10103);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10104);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10105);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10106);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10107);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10108);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10109);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10110);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10111);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10112);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10113);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10114);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10115);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10116);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10117);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10118);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10119);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10120);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10121);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10122);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10123);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10124);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10125);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10126);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10127);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10128);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10129);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10130);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10131);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10132);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10133);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10134);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10135);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10136);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10137);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10138);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10139);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10140);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10141);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10142);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10143);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10144);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10145);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10146);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10147);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10148);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10149);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10150);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10151);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10152);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10153);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10154);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10155);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10156);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10157);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10158);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10159);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10160);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10161);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10162);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10163);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10164);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10165);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10166);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10167);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10168);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10169);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10170);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10171);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10172);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10173);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10174);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10175);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10176);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10177);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10178);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10179);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10180);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10181);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10182);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10183);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10184);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10185);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10186);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10187);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10188);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10189);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10190);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10191);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10192);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10193);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10194);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10195);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10196);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10197);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10198);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10199);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10200);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10201);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10202);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10203);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10204);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10205);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10206);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10207);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10208);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10209);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10210);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10211);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10212);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10213);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10214);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10215);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10216);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10217);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10218);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10219);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10220);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10221);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10222);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10223);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10224);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10225);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10226);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10227);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10228);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10229);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10230);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10231);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10232);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10233);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10234);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10235);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10236);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10237);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10238);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10239);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10240);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10241);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10242);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10243);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10244);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10245);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10246);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10247);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10248);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10249);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10250);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10251);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10252);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10253);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10254);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10255);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10256);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10257);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10258);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10259);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10260);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10261);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10262);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10263);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10264);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10265);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10266);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10267);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10268);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10269);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10270);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10271);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10272);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10273);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10274);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10275);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10276);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10277);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10278);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10279);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10280);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10281);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10282);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10283);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10284);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10285);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10286);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10287);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10288);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10289);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10290);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10291);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10292);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10293);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10294);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10295);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10296);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10297);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10298);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10299);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10300);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10301);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10302);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10303);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10304);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10305);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10306);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10307);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10308);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10309);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10310);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10311);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10312);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10313);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10314);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10315);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10316);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10317);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10318);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10319);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10320);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10321);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10322);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10323);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10324);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10325);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10326);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10327);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10328);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10329);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10330);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10331);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10332);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10333);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10334);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10335);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10336);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10337);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10338);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10339);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10340);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10341);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10342);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10343);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10344);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10345);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10346);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10347);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10348);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10349);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10350);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10351);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10352);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10353);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10354);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10355);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10356);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10357);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10358);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10359);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10360);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10361);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10362);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10363);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10364);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10365);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10366);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10367);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10368);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10369);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10370);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10371);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10372);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10373);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10374);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10375);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10376);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10377);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10378);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10379);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10380);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10381);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10382);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10383);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10384);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10385);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10386);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10387);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10388);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10389);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10390);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10391);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10392);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10393);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10394);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10395);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10396);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10397);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10398);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10399);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10400);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10401);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10402);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10403);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10404);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10405);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10406);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10407);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10408);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10409);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10410);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10411);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10412);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10413);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10414);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10415);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10416);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10417);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10418);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10419);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10420);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10421);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10422);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10423);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10424);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10425);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10426);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10427);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10428);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10429);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10430);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10431);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10432);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10433);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10434);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10435);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10436);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10437);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10438);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10439);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10440);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10441);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10442);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10443);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10444);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10445);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10446);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10447);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10448);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10449);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10450);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10451);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10452);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10453);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10454);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10455);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10456);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10457);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10458);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10459);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10460);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10461);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10462);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10463);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10464);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10465);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10466);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10467);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10468);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10469);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10470);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10471);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10472);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10473);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10474);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10475);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10476);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10477);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10478);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10479);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10480);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10481);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10482);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10483);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10484);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10485);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10486);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10487);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10488);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10489);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10490);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10491);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10492);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10493);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10494);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10495);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10496);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10497);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10498);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10499);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10500);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10501);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10502);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10503);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10504);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10505);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10506);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10507);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10508);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10509);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10510);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10511);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10512);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10513);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10514);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10515);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10516);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10517);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10518);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10519);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10520);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10521);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10522);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10523);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10524);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10525);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10526);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10527);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10528);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10529);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10530);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10531);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10532);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10533);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10534);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10535);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10536);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10537);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10538);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10539);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10540);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10541);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10542);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10543);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10544);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10545);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10546);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10547);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10548);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10549);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10550);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10551);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10552);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10553);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10554);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10555);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10556);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10557);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10558);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10559);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10560);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10561);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10562);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10563);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10564);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10565);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10566);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10567);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10568);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10569);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10570);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10571);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10572);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10573);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10574);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10575);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10576);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10577);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10578);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10579);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10580);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10581);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10582);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10583);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10584);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10585);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10586);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10587);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10588);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10589);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10590);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10591);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10592);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10593);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10594);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10595);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10596);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10597);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10598);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10599);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10600);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10601);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10602);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10603);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10604);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10605);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10606);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10607);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10608);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10609);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10610);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10611);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10612);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10613);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10614);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10615);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10616);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10617);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10618);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10619);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10620);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10621);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10622);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10623);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10624);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10625);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10626);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10627);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10628);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10629);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10630);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10631);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10632);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10633);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10634);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10635);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10636);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10637);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10638);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10639);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10640);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10641);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10642);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10643);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10644);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10645);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10646);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10647);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10648);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10649);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10650);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10651);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10652);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10653);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10654);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10655);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10656);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10657);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10658);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10659);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10660);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10661);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10662);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10663);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10664);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10665);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10666);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10667);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10668);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10669);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10670);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10671);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10672);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10673);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10674);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10675);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10676);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10677);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10678);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10679);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10680);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10681);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10682);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10683);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10684);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10685);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10686);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10687);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10688);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10689);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10690);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10691);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10692);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10693);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10694);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10695);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10696);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10697);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10698);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10699);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10700);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10701);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10702);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10703);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10704);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10705);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10706);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10707);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10708);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10709);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10710);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10711);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10712);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10713);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10714);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10715);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10716);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10717);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10718);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10719);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10720);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10721);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10722);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10723);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10724);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10725);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10726);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10727);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10728);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10729);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10730);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10731);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10732);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10733);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10734);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10735);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10736);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10737);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10738);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10739);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10740);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10741);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10742);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10743);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10744);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10745);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10746);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10747);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10748);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10749);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10750);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10751);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10752);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10753);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10754);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10755);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10756);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10757);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10758);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10759);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10760);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10761);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10762);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10763);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10764);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10765);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10766);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10767);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10768);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10769);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10770);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10771);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10772);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10773);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10774);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10775);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10776);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10777);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10778);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10779);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10780);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10781);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10782);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10783);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10784);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10785);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10786);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10787);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10788);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10789);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10790);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10791);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10792);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10793);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10794);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10795);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10796);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10797);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10798);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10799);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10800);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10801);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10802);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10803);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10804);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10805);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10806);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10807);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10808);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10809);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10810);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10811);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10812);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10813);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10814);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10815);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10816);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10817);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10818);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10819);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10820);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10821);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10822);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10823);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10824);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10825);

            migrationBuilder.DropColumn(
                name: "HomeDisplayOrder",
                table: "ServiceCategories");

            migrationBuilder.DropColumn(
                name: "IconKey",
                table: "ServiceCategories");

            migrationBuilder.DropColumn(
                name: "IsPopular",
                table: "ServiceCategories");

            migrationBuilder.DropColumn(
                name: "ShowOnHome",
                table: "ServiceCategories");

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(2572), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(2599), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(5284), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(5293), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(5295), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7116), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7128), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7132), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7136), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7140), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8673), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8743), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8759), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8764), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8769), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(287), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(287), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(298), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(299), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(302), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(302), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(305), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(305), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(308), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(309), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1910), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1917), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1919), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1921), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1923), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1924), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1926), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1927), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1929), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1931), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1932), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1934), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1935), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1937), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1938), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1940), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1941), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1943), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1944), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1946), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1947), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1949), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1951), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1952), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1954), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(3473), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(3481), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "FoodMenuCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(6380), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "FoodMenuCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(6394), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7782), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7787), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7788), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7790), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7791), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "GuestStays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "ModifyDate", "VerificationCode" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(9231), new DateTime(2026, 6, 4, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(9234), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(9416), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(9416), "3b5d0069-2d3e-47ab-b1f4-9a256b4810db" });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 773, DateTimeKind.Local).AddTicks(1179), new DateTime(2026, 6, 2, 15, 34, 22, 773, DateTimeKind.Local).AddTicks(1181) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(1112), new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8595), new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8607), new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8608), new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8610), new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8612), new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8613), new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(395), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1802), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1807), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1809), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1811), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5860), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5886), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5890), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5893), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5897), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5900), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5904), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5908), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7299), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7321), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7339), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7655), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7661), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7663), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7675), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7678), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7680), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7682), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7685), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7687), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7690), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7692), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7695), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7698), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7701), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7705), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7707), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7709), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7713), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7715), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7717), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7722), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7724), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7726), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7728), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7730), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7732), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7734), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7736), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7738), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7741), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7742), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7744), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7748), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7750), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7752), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7755), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7756), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7758), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7763), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7765), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7767), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7770), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7827), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7829), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7831), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7834), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7836), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7838), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7840), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7843), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7846), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7848), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7850), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7853), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7856), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7858), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7861), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7863), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7866), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7869), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7871), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7874), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7876), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7878), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7883), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7886), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7888), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7891), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7893), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7896), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3487), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3519), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3522), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3526), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3530), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3534), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3537), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3541), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3544), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3547), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3552), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3555), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3570), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3573), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3576), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3579), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3768), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3777), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3781), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3785), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3789), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3792), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3796), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3801), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3805), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3809), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3812), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3816), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3819), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3823), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3491), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3512), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3517), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3519), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3522), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(8237), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(8268), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(8273), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5113), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5130), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5133), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5134), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5136), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5139), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5140), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5142), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5144), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5300), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5302), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5303), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5306), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5307), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5309), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5311), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5313), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5314), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5316), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5317), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5319), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5320), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5322), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5324), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5326), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5327), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5329), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5331), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5334), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5336), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5338), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5339), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5341), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5343), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5345), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5346), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5348), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5350), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5352), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5354), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5355), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5357), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5359), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5360), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5362), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5364), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5366), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5368), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5369), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5371), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5373), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5375), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5376), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5378), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5380), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5383), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5385), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5387), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5389), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5391), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5392), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5394), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5396), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5398), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5399), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5401), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5402), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5404), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5406), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5407), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5409), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5411), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5413), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5415), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5416), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5419), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5421), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5421) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5423), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5424), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5426), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5428), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5429), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5432), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5434), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5435), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5439), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5441), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5442), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5444), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5446), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5447), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5449), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5450), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5452), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5453), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5455), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5456), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5458), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5460), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5461), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5463), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5465), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5466), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5468), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5469), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5471), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5473), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5474), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5476), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5479), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5480), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5609), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5611), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5613), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5614), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5616), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5618), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5620), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5622), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5623), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5625), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5627), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5629), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5631), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5632), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5634), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5635), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5637), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5639), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5641), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5642), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5644), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5646), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5648), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5650), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5651), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5654), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5656), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5657), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5659), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5661), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5663), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5664), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5666), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5668), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5670), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5671), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5673), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5674), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5676), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5677), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5679), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5681), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5683), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5684), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5686), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5687), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5689), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5691), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5692), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5694), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5696), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5699), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5700), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5702), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5704), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5706), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5707), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5709), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5710), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5712), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5713), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5715), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5717), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5719), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5720), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5722), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5723), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5725), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5727), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5729), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5731), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5732), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5734), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5736), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5738), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5739), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5741), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5743), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5744), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5747), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5749), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5750), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5752), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5754), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5755), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5758), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5759), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5761), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5763), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5765), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5766), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5767), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5769), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8652), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8714), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8756), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8801), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8888), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8929), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8930) });
        }
    }
}
