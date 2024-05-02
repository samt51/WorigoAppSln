using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newServiceAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "SpaMassageValue",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "DryCleaner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DryCleaner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelInformationAndAnnouncements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelInformationAndAnnouncements", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(8195), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(5316), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(5330), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(8696), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6766), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6773), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6774), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6774), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6775), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6776), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6777), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6778), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6779), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6779), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6780), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(7608), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(7609), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(7610), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(7611), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(7612), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(793), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(9256), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(9258), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(9259), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1134), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1135), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1136), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1137), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1138), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1138), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1655), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1657), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1658), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1659), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1660), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1660), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1661), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1662), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1663), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1664), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1664), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(9720), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(9722), new DateTime(2024, 5, 2, 8, 52, 41, 423, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(416), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(418), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(419), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(442), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(444), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(444), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(445), new DateTime(2024, 5, 2, 8, 52, 41, 424, DateTimeKind.Local).AddTicks(445) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DryCleaner");

            migrationBuilder.DropTable(
                name: "HotelInformationAndAnnouncements");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "SpaMassageValue");

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 876, DateTimeKind.Local).AddTicks(849), new DateTime(2024, 4, 30, 10, 4, 8, 876, DateTimeKind.Local).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(411), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(423), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 877, DateTimeKind.Local).AddTicks(1020), new DateTime(2024, 4, 30, 10, 4, 8, 877, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3154), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3161), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3162), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3163), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3164), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3165), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3166), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3167), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3168), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3168), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3169), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(4374), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(4377), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(4378), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(4380), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(4381), new DateTime(2024, 4, 30, 10, 4, 8, 875, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(7127), new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 877, DateTimeKind.Local).AddTicks(5668), new DateTime(2024, 4, 30, 10, 4, 8, 877, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 877, DateTimeKind.Local).AddTicks(5672), new DateTime(2024, 4, 30, 10, 4, 8, 877, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 877, DateTimeKind.Local).AddTicks(5673), new DateTime(2024, 4, 30, 10, 4, 8, 877, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1291), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1296), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1296), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1297), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1298), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1299), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2211), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2214), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2215), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2216), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2216), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2218), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2218), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2219), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2220), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2221), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2222), new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(1150), new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(1155), new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(6216), new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(6222), new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(6223), new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(6223), new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(6224), new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 4, 30, 10, 4, 8, 879, DateTimeKind.Local).AddTicks(6225) });
        }
    }
}
