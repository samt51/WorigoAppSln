using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newServiceAdd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpaMassageValue_SpaMassage_SpaMassageId1",
                table: "SpaMassageValue");

            migrationBuilder.RenameColumn(
                name: "SpaMassageId1",
                table: "SpaMassageValue",
                newName: "SpaMassageId");

            migrationBuilder.RenameIndex(
                name: "IX_SpaMassageValue_SpaMassageId1",
                table: "SpaMassageValue",
                newName: "IX_SpaMassageValue_SpaMassageId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TechnicalNeed",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "TechnicalNeed",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TechnicalNeed",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "SpaMassageValue",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SpaMassage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SpaMassage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "HouseKeeping",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "HouseKeeping",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "HotelInformationAndAnnouncements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "HotelInformationAndAnnouncements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "HotelInformationAndAnnouncements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DryCleaner",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "DryCleaner",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DryCleaner",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FlootNo",
                table: "Connection",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Connection",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BellBoy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5016), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5017), "Bagaj Taşıma" });

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
                columns: new[] { "CreatedDate", "FlootNo", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5449), null, new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5450), "1q2w3e4r5t" });

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
                columns: new[] { "CreatedDate", "ImageUrl", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5827), "", new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5828), "Havlu değişimi veya eksiği" });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5830), "", new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5830), "Oda Genel temizlik" });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5831), "", new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(5831), "Çarşaf veya yatak yüzü değişimi" });

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
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(8360), new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(8361) });

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
                columns: new[] { "CreatedDate", "Description", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(6243), "Uzak Doğu Masajı", new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(6244), "Uzak Doğu" });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(6246), "Tailand Masajı", new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(6246), "Tailand Masajı" });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7018), "Klima ile arıza durumları", "1.jpeg", new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7019), "Klima" });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7022), "TV ile arıza durumları", "1.jpeg", new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7022), "TV" });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7023), "Minibar ile arıza durumları", "1.jpeg", new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7023), "Minibar" });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7023), "Kapı ile arıza durumları", "1.jpeg", new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7024), "Kapı" });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7024), "Elektirk ile arıza durumları", "1.jpeg", new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7025), "Elektrik" });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7025), "Aydınlatma ile arıza durumları", "1.jpeg", new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7026), "Aydınlatma" });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7026), "Aydınlatma ile arıza durumları", "1.jpeg", new DateTime(2024, 5, 2, 8, 59, 26, 354, DateTimeKind.Local).AddTicks(7026), "Duş Ve Tuvalet" });

            migrationBuilder.AddForeignKey(
                name: "FK_SpaMassageValue_SpaMassage_SpaMassageId",
                table: "SpaMassageValue",
                column: "SpaMassageId",
                principalTable: "SpaMassage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpaMassageValue_SpaMassage_SpaMassageId",
                table: "SpaMassageValue");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TechnicalNeed");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "TechnicalNeed");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TechnicalNeed");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "SpaMassageValue");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SpaMassage");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SpaMassage");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "HouseKeeping");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "HouseKeeping");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "HotelInformationAndAnnouncements");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "HotelInformationAndAnnouncements");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "HotelInformationAndAnnouncements");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "DryCleaner");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "DryCleaner");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "DryCleaner");

            migrationBuilder.DropColumn(
                name: "FlootNo",
                table: "Connection");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Connection");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BellBoy");

            migrationBuilder.RenameColumn(
                name: "SpaMassageId",
                table: "SpaMassageValue",
                newName: "SpaMassageId1");

            migrationBuilder.RenameIndex(
                name: "IX_SpaMassageValue_SpaMassageId",
                table: "SpaMassageValue",
                newName: "IX_SpaMassageValue_SpaMassageId1");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SpaMassageValue_SpaMassage_SpaMassageId1",
                table: "SpaMassageValue",
                column: "SpaMassageId1",
                principalTable: "SpaMassage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
