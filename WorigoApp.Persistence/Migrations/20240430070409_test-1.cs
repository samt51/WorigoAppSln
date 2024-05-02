using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

       
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

       

    
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1291), true, false, new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1294), "SystemAdmin" },
                    { 2, new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1296), true, false, new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1296), "HotelAdmin" },
                    { 3, new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1296), true, false, new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1297), "Management" },
                    { 4, new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1297), true, false, new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1297), "DepartmentManager" },
                    { 5, new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1298), true, false, new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1298), "Employee" },
                    { 6, new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1299), true, false, new DateTime(2024, 4, 30, 10, 4, 8, 881, DateTimeKind.Local).AddTicks(1299), "Reception" }
                });

       

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
    

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");

           
        }
    }
}
