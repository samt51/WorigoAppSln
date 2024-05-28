using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addnewservice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "SpaMassage",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "SpaMassage",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "EmployeeType",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "DryCleaner",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "DryCleaner",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "BellBoy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "FeedBackAndSurveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    FeedBack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBackAndSurveys", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(3498), "1.jpeg", new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(3504) });

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
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(657), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(658), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(658), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(659), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(660), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(660), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(661), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(661) });

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
                columns: new[] { "CreatedDate", "ModifyDate", "ParentId", "Price" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(6929), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(6930), null, 0m });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "ParentId", "Price" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(6932), new DateTime(2024, 5, 11, 16, 38, 49, 142, DateTimeKind.Local).AddTicks(6933), null, 0m });

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
                name: "IX_EmployeeType_HotelId",
                table: "EmployeeType",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeType_Hotel_HotelId",
                table: "EmployeeType",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeType_Hotel_HotelId",
                table: "EmployeeType");

            migrationBuilder.DropTable(
                name: "FeedBackAndSurveys");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeType_HotelId",
                table: "EmployeeType");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "SpaMassage");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "SpaMassage");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "EmployeeType");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "DryCleaner");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "DryCleaner");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "BellBoy");

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7941), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(5792), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(5803), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8361), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6834), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6837), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6838), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6838), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6839), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6840), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6840), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6841), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6842), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6842), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6843), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7476), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7477), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7478), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7479), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(408), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8836), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8836), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3281), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3286), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3287), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3287), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3288), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3289), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3806), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3808), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3809), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3810), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3811), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3812), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3813), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3813), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3814), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3815), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3816), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(9220), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(9221), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(9998), new DateTime(2024, 5, 6, 14, 21, 44, 967, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(1), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(2), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(3), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(4), new DateTime(2024, 5, 6, 14, 21, 44, 968, DateTimeKind.Local).AddTicks(4) });
        }
    }
}
