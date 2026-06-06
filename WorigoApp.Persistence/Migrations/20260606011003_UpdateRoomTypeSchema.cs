using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    public partial class UpdateRoomTypeSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop old column
            migrationBuilder.DropColumn(
                name: "RoomTypeEnum",
                table: "RoomType");

            // Add new columns
            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "RoomType",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RoomType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RoomType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "RoomType",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<decimal>(
                name: "BasePrice",
                table: "RoomType",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "RoomType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            // Update existing data for IDs 1, 2, 3 (which already exist in seed)
            migrationBuilder.Sql(@"
            UPDATE [RoomType] SET [HotelId] = 1, [Name] = 'Standard Room', [Description] = 'Cozy standard room', [Capacity] = 2, [BasePrice] = 1500, [DisplayOrder] = 1 WHERE [Id] = 1;
            UPDATE [RoomType] SET [HotelId] = 1, [Name] = 'Superior Room', [Description] = 'Spacious superior room', [Capacity] = 2, [BasePrice] = 2000, [DisplayOrder] = 2 WHERE [Id] = 2;
            UPDATE [RoomType] SET [HotelId] = 1, [Name] = 'Deluxe Room', [Description] = 'Luxurious deluxe room', [Capacity] = 3, [BasePrice] = 2500, [DisplayOrder] = 3 WHERE [Id] = 3;
            ");

            // Insert new default room types (IDs 4 to 10) if they do not exist
            migrationBuilder.Sql(@"
            SET IDENTITY_INSERT [RoomType] ON;
            IF NOT EXISTS (SELECT 1 FROM [RoomType] WHERE [Id] = 4)
                INSERT INTO [RoomType] ([Id], [HotelId], [Name], [Description], [Capacity], [BasePrice], [DisplayOrder], [CreatedDate], [ModifyDate], [IsDeleted], [IsActive])
                VALUES (4, 1, 'Family Room', 'Perfect for families', 4, 3000, 4, GETDATE(), GETDATE(), 0, 1);
            IF NOT EXISTS (SELECT 1 FROM [RoomType] WHERE [Id] = 5)
                INSERT INTO [RoomType] ([Id], [HotelId], [Name], [Description], [Capacity], [BasePrice], [DisplayOrder], [CreatedDate], [ModifyDate], [IsDeleted], [IsActive])
                VALUES (5, 1, 'Junior Suite', 'Elegant junior suite', 3, 3500, 5, GETDATE(), GETDATE(), 0, 1);
            IF NOT EXISTS (SELECT 1 FROM [RoomType] WHERE [Id] = 6)
                INSERT INTO [RoomType] ([Id], [HotelId], [Name], [Description], [Capacity], [BasePrice], [DisplayOrder], [CreatedDate], [ModifyDate], [IsDeleted], [IsActive])
                VALUES (6, 1, 'Suite', 'Luxury suite', 4, 4000, 6, GETDATE(), GETDATE(), 0, 1);
            IF NOT EXISTS (SELECT 1 FROM [RoomType] WHERE [Id] = 7)
                INSERT INTO [RoomType] ([Id], [HotelId], [Name], [Description], [Capacity], [BasePrice], [DisplayOrder], [CreatedDate], [ModifyDate], [IsDeleted], [IsActive])
                VALUES (7, 1, 'Presidential Suite', 'The ultimate presidential suite', 6, 8000, 7, GETDATE(), GETDATE(), 0, 1);
            IF NOT EXISTS (SELECT 1 FROM [RoomType] WHERE [Id] = 8)
                INSERT INTO [RoomType] ([Id], [HotelId], [Name], [Description], [Capacity], [BasePrice], [DisplayOrder], [CreatedDate], [ModifyDate], [IsDeleted], [IsActive])
                VALUES (8, 1, 'Villa', 'Private villa experience', 8, 15000, 8, GETDATE(), GETDATE(), 0, 1);
            IF NOT EXISTS (SELECT 1 FROM [RoomType] WHERE [Id] = 9)
                INSERT INTO [RoomType] ([Id], [HotelId], [Name], [Description], [Capacity], [BasePrice], [DisplayOrder], [CreatedDate], [ModifyDate], [IsDeleted], [IsActive])
                VALUES (9, 1, 'Bungalow', 'Relaxing bungalow', 4, 5000, 9, GETDATE(), GETDATE(), 0, 1);
            IF NOT EXISTS (SELECT 1 FROM [RoomType] WHERE [Id] = 10)
                INSERT INTO [RoomType] ([Id], [HotelId], [Name], [Description], [Capacity], [BasePrice], [DisplayOrder], [CreatedDate], [ModifyDate], [IsDeleted], [IsActive])
                VALUES (10, 1, 'Accessible Room', 'Wheelchair accessible room', 2, 1500, 10, GETDATE(), GETDATE(), 0, 1);
            SET IDENTITY_INSERT [RoomType] OFF;
            ");

            // Add Index and FK
            migrationBuilder.CreateIndex(
                name: "IX_RoomType_HotelId",
                table: "RoomType",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomType_Hotel_HotelId",
                table: "RoomType",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomType_Hotel_HotelId",
                table: "RoomType");

            migrationBuilder.DropIndex(
                name: "IX_RoomType_HotelId",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "BasePrice",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "RoomType");

            migrationBuilder.AddColumn<int>(
                name: "RoomTypeEnum",
                table: "RoomType",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
