using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddReceptionOperationsWorkspace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdultCount",
                table: "GuestStays",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "ChildCount",
                table: "GuestStays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "DepositAmount",
                table: "GuestStays",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "GuestConsentAt",
                table: "GuestStays",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialRequests",
                table: "GuestStays",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityDocumentNumber",
                table: "Customers",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityDocumentType",
                table: "Customers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ReceptionAuditLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionAuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceptionShiftNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsResolved = table.Column<bool>(type: "bit", nullable: false),
                    ResolvedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResolvedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionShiftNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceptionShiftNotes_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceptionShiftNotes_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceptionShiftNotes_Users_ResolvedByUserId",
                        column: x => x.ResolvedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReceptionAuditLogs_HotelId_CreatedDate",
                table: "ReceptionAuditLogs",
                columns: new[] { "HotelId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReceptionShiftNotes_CreatedByUserId",
                table: "ReceptionShiftNotes",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceptionShiftNotes_HotelId_IsResolved_CreatedDate",
                table: "ReceptionShiftNotes",
                columns: new[] { "HotelId", "IsResolved", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReceptionShiftNotes_ResolvedByUserId",
                table: "ReceptionShiftNotes",
                column: "ResolvedByUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceptionAuditLogs");

            migrationBuilder.DropTable(
                name: "ReceptionShiftNotes");

            migrationBuilder.DropColumn(
                name: "AdultCount",
                table: "GuestStays");

            migrationBuilder.DropColumn(
                name: "ChildCount",
                table: "GuestStays");

            migrationBuilder.DropColumn(
                name: "DepositAmount",
                table: "GuestStays");

            migrationBuilder.DropColumn(
                name: "GuestConsentAt",
                table: "GuestStays");

            migrationBuilder.DropColumn(
                name: "SpecialRequests",
                table: "GuestStays");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IdentityDocumentNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IdentityDocumentType",
                table: "Customers");

        }
    }
}
