using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class foodtypeandRoomType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomTypeEnum",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "RoomFoodTypeEnum",
                table: "FoodType");

            migrationBuilder.AddColumn<string>(
                name: "RoomTypeValue",
                table: "RoomType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RoomFoodTypeValue",
                table: "FoodType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(119), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(138), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1278), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1282), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1283), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1284), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1285), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1285), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1286), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1287), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1288), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1289), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1290), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomFoodTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(2144), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(2146), "Breakfast" });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomFoodTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(2147), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(2148), "HalfPension" });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomFoodTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(2149), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(2149), "FullPension" });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomFoodTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(2150), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(2150), "AllInclusive" });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomFoodTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(2151), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(2151), "UltraAllInclusive" });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(2987), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3930), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3933), "Standart" });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3934), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3934), "SingleRoom" });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3935), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3935), "DoubleRoom" });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3936), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3936), "TreeRoom" });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3937), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3937), "FourRoom" });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3938), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3938), "DubleksRoom" });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3939), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3939), "FamilyRoom" });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3940), "JuniorSuiter" });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3941), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3942), "KralDaire" });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3942), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3943), "SuitRoom" });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeValue" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3943), new DateTime(2024, 3, 10, 4, 1, 11, 438, DateTimeKind.Local).AddTicks(3944), "DisabledRoom" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomTypeValue",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "RoomFoodTypeValue",
                table: "FoodType");

            migrationBuilder.AddColumn<int>(
                name: "RoomTypeEnum",
                table: "RoomType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomFoodTypeEnum",
                table: "FoodType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(6084), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(6102), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7184), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7188), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7189), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7190), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7191), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7191), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7192), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7194), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7195), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7196), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomFoodTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8033), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8035), 1 });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomFoodTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8036), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8036), 2 });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomFoodTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8037), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8037), 3 });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomFoodTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8038), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8038), 4 });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomFoodTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8039), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8039), 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8768), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9432), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9433), 1 });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9434), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9435), 2 });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9435), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9436), 3 });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9436), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9437), 4 });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9437), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9437), 5 });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9438), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9438), 6 });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9439), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9439), 7 });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9440), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9440), 8 });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9441), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9441), 9 });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9442), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9442), 10 });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate", "RoomTypeEnum" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9443), new DateTime(2024, 3, 6, 2, 27, 44, 521, DateTimeKind.Local).AddTicks(9443), 11 });
        }
    }
}
