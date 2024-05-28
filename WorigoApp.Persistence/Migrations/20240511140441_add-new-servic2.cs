using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addnewservic2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpaMassageValue");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 11);

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
                columns: new[] { "CreatedDate", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(4575), new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(4575), "Sağlık Kulübü & Spa Departmanı" });

            migrationBuilder.InsertData(
                table: "EmployeeType",
                columns: new[] { "Id", "CreatedDate", "DepartmentId", "HotelId", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5679), 1, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5681), "Ön Büro Müdürü" },
                    { 2, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5683), 1, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5683), "Gece Müdürü" },
                    { 3, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5684), 1, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5684), "Ön Büro Şefi" },
                    { 4, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5685), 1, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5685), "Resepsiyonist" },
                    { 5, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5686), 1, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5686), "Concierge Şefi" },
                    { 6, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5686), 1, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5686), "Taşıyıcı/Karşılayıcı Personel" },
                    { 7, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5687), 1, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5687), "Guest Service Agent" },
                    { 8, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5688), 1, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5688), "Guest Relation" },
                    { 9, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5688), 2, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5689), "HK Müdürü" },
                    { 10, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5689), 2, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5689), "Housekeeper" },
                    { 11, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5690), 2, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5690), "Kat Şefi (Floor Supervisor)" },
                    { 12, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5690), 2, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5690), "Oda Görevlisi" },
                    { 13, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5691), 2, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5691), "Meydancı" },
                    { 14, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5691), 3, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5692), "Yiyecek – İçecek Müdürü" },
                    { 15, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5692), 3, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5692), "Barlar Şefi" },
                    { 16, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5693), 3, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5693), "Bar Personeli" },
                    { 17, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5693), 3, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5694), "Mutfak Şefi" },
                    { 18, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5694), 3, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5694), "Mutfak Personeli" },
                    { 19, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5695), 3, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5695), "Restoran Şefi" },
                    { 20, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5695), 3, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5696), "Servis Personeli" },
                    { 21, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5696), 4, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5696), "Teknik Müdür" },
                    { 22, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5697), 4, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5697), "Elektrik Tekniker" },
                    { 23, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5697), 4, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5697), "Mekanik Tekniker" },
                    { 24, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5698), 4, null, true, false, new DateTime(2024, 5, 11, 17, 4, 40, 842, DateTimeKind.Local).AddTicks(5698), "Tesisatçı" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.CreateTable(
                name: "SpaMassageValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpaMassageId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpaMassageValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpaMassageValue_SpaMassage_SpaMassageId",
                        column: x => x.SpaMassageId,
                        principalTable: "SpaMassage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(3498), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 141, DateTimeKind.Local).AddTicks(9573), new DateTime(2024, 5, 11, 16, 38, 49, 141, DateTimeKind.Local).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 141, DateTimeKind.Local).AddTicks(9587), new DateTime(2024, 5, 11, 16, 38, 49, 141, DateTimeKind.Local).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(651), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(654), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(655), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(656), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(657), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(657), "İnsan Kaynakları Departmanı" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "CreatedDate", "HotelId", "ImageUrl", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 6, new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(658), 1, "1.jpeg", true, false, new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(658), "Muhasebe Departmanı" },
                    { 7, new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(658), 1, "1.jpeg", true, false, new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(659), "Satınalma Departmanı" },
                    { 8, new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(659), 1, "1.jpeg", true, false, new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(659), "Satış ve Pazarlama Departmanı" },
                    { 9, new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(660), 1, "1.jpeg", true, false, new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(660), "Bilgi İşlem Departmanı " },
                    { 10, new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(660), 1, "1.jpeg", true, false, new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(661), "Güvenlik Departmanı" },
                    { 11, new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(661), 1, "1.jpeg", true, false, new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(661), "Sağlık Kulübü & Spa Departmanı" }
                });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(1714), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(1719), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(1721), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(1722), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(1723), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(5889), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(5935), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(5940), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(5941), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9092), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9096), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9097), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9098), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9099), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9765), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9768), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9769), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9770), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9771), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9772), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9773), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9774), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9775), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9776), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9780), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(6929), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(6932), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(4704), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(4713), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(4715), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(4716), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(4717), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(4718), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(4719), new DateTime(2024, 5, 11, 16, 38, 49, 144, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.CreateIndex(
                name: "IX_SpaMassageValue_SpaMassageId",
                table: "SpaMassageValue",
                column: "SpaMassageId");
        }
    }
}
