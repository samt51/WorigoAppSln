using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveHotelCheckInOutTimes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                IF COL_LENGTH('Hotel', 'CheckInTime') IS NOT NULL
                    ALTER TABLE [Hotel] DROP COLUMN [CheckInTime];

                IF COL_LENGTH('Hotel', 'CheckOutTime') IS NOT NULL
                    ALTER TABLE [Hotel] DROP COLUMN [CheckOutTime];
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                IF COL_LENGTH('Hotel', 'CheckInTime') IS NULL
                    ALTER TABLE [Hotel] ADD [CheckInTime] time NOT NULL CONSTRAINT [DF_Hotel_CheckInTime] DEFAULT '00:00:00';

                IF COL_LENGTH('Hotel', 'CheckOutTime') IS NULL
                    ALTER TABLE [Hotel] ADD [CheckOutTime] time NOT NULL CONSTRAINT [DF_Hotel_CheckOutTime] DEFAULT '00:00:00';
                """);
        }
    }
}
