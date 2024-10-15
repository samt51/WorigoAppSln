using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newtableRoomBasedTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFull",
                table: "Room",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RoomBasedTransactionId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomBasedTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VerificationCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBasedTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomBasedTransaction_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomBasedTransaction_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(9770), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(5673), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(5697), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(726), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7150), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7155), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7156), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7157), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7158), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8036), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8040), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8041), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8042), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8043), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8044), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8045), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8046), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8046), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8047), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8048), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8049), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8050), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8051), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8052), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8052), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8053), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8054), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8055), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8056), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8057), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8058), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8059), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8060), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8060), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8917), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8920), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8921), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8922), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8923), new DateTime(2024, 10, 15, 2, 16, 17, 469, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(6525), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(4040), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(4049), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(4050), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(713), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(720), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(720), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(721), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(722), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(723), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1571), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1573), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1574), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1576), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1577), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1577), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1578), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1579), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1580), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1581), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1582), new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5041), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5046), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5781), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5785), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5786), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5787), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5788), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5788), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5789), new DateTime(2024, 10, 15, 2, 16, 17, 470, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "IsActive", "IsDeleted", "ModifyDate", "Password", "RoleId" },
                values: new object[] { 1, new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(6449), "samt51.m@icloud.com", true, false, new DateTime(2024, 10, 15, 2, 16, 17, 471, DateTimeKind.Local).AddTicks(6455), "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RoomBasedTransactionId",
                table: "Orders",
                column: "RoomBasedTransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBasedTransaction_CustomerId",
                table: "RoomBasedTransaction",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomBasedTransaction_RoomId",
                table: "RoomBasedTransaction",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_RoomBasedTransaction_RoomBasedTransactionId",
                table: "Orders",
                column: "RoomBasedTransactionId",
                principalTable: "RoomBasedTransaction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_RoomBasedTransaction_RoomBasedTransactionId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "RoomBasedTransaction");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_RoomBasedTransactionId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "IsFull",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "RoomBasedTransactionId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "BellBoy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(5041), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(1412), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(1431), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Connection",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(5927), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2528), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2532), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2533), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2534), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2535), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3451), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3455), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3456), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3457), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3458), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3459), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3460), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3460), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3462), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3463), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3463), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3464), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3466), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3467), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3468), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3469), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3469), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3470), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3471), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3472), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3473), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3474), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3474), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3475), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4304), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4306), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4307), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4308), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4309), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(1560), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(9187), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(9194), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "HouseKeeping",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(9195), new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5325), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5333), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5334), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5335), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5336), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5337), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6270), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6274), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6275), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6276), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6278), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6279), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6280), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6281), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6282), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6283), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6284), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(18), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "SpaMassage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(22), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(734), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(737), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(738), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(739), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(740), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(741), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "TechnicalNeed",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(742), new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(742) });
        }
    }
}
