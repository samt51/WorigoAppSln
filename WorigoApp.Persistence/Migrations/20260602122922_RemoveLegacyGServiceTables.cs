using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLegacyGServiceTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "AmenityRequestServices");
            migrationBuilder.DropTable(name: "BellBoy");
            migrationBuilder.DropTable(name: "Connection");
            migrationBuilder.DropTable(name: "DryCleaner");
            migrationBuilder.DropTable(name: "FeedBackAndSurveys");
            migrationBuilder.DropTable(name: "HealthAndSafety");
            migrationBuilder.DropTable(name: "HotelInformationAndAnnouncements");
            migrationBuilder.DropTable(name: "HouseKeeping");
            migrationBuilder.DropTable(name: "MedicalAssistanceServices");
            migrationBuilder.DropTable(name: "MinibarServices");
            migrationBuilder.DropTable(name: "SpaMassage");
            migrationBuilder.DropTable(name: "StayExtensionServices");
            migrationBuilder.DropTable(name: "TechnicalNeed");
            migrationBuilder.DropTable(name: "TravelOrTransportation");
            migrationBuilder.DropTable(name: "ValetParkingServices");
            migrationBuilder.DropTable(name: "WakeUpCallServices");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
