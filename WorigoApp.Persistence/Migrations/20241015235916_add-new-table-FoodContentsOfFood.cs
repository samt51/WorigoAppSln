using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addnewtableFoodContentsOfFood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodContentsOfFood",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    ContentsOfFoodId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodContentsOfFood", x => new { x.FoodId, x.ContentsOfFoodId });
                    table.ForeignKey(
                        name: "FK_FoodContentsOfFood_ContentsOfFood_ContentsOfFoodId",
                        column: x => x.ContentsOfFoodId,
                        principalTable: "ContentsOfFood",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodContentsOfFood_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FoodContentsOfFood_ContentsOfFoodId",
                table: "FoodContentsOfFood",
                column: "ContentsOfFoodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodContentsOfFood");

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
    }
}
