using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using WorigoApp.Persistence.Context;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20260606000000_AddCurrenciesAndGuestStayPricing")]
    public partial class AddCurrenciesAndGuestStayPricing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "GuestStays",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CultureCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DecimalDigits = table.Column<int>(type: "int", nullable: false),
                    IsBaseCurrency = table.Column<bool>(type: "bit", nullable: false),
                    IsSupported = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Currency_Code",
                table: "Currency",
                column: "Code",
                unique: true);

            migrationBuilder.Sql(@"
INSERT INTO [Currency]
    ([Code], [Name], [Symbol], [Country], [CultureCode], [DecimalDigits], [IsBaseCurrency], [IsSupported], [SortOrder], [CreatedDate], [ModifyDate], [IsDeleted], [IsActive])
VALUES
    (N'TRY', N'Turkish Lira', NCHAR(8378), N'Turkiye', N'tr-TR', 2, 1, 1, 1, GETDATE(), GETDATE(), 0, 1),
    (N'USD', N'US Dollar', N'$', N'United States', N'en-US', 2, 0, 1, 2, GETDATE(), GETDATE(), 0, 1),
    (N'EUR', N'Euro', NCHAR(8364), N'European Union', N'de-DE', 2, 0, 1, 3, GETDATE(), GETDATE(), 0, 1),
    (N'GBP', N'Pound Sterling', NCHAR(163), N'United Kingdom', N'en-GB', 2, 0, 1, 4, GETDATE(), GETDATE(), 0, 1),
    (N'SAR', N'Saudi Riyal', N'SAR', N'Saudi Arabia', N'ar-SA', 2, 0, 1, 5, GETDATE(), GETDATE(), 0, 1);
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Currency");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "GuestStays");
        }
    }
}
