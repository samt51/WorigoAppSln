using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MoveTechnicalNeedTranslationsToServiceDefinitions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(2572), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(2599), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(5284), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(5293), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(5295), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7116), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7128), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7132), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7136), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7140), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8673), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8743), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8759), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8764), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8769), new DateTime(2026, 6, 2, 15, 34, 22, 771, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(287), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(287), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(298), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(299), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(302), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(302), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(305), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(305), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(308), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(309), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1910), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1917), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1919), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1921), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1923), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1924), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1926), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1927), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1929), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1931), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1932), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1934), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1935), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1937), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1938), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1940), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1941), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1943), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1944), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1946), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1947), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1949), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1951), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1952), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1954), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(3473), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(3481), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "FoodMenuCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(6380), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "FoodMenuCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(6394), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7782), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7787), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7788), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7790), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7791), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "GuestStays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "ModifyDate", "VerificationCode" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(9231), new DateTime(2026, 6, 4, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(9234), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(9416), new DateTime(2026, 6, 2, 15, 34, 22, 772, DateTimeKind.Local).AddTicks(9416), "3b5d0069-2d3e-47ab-b1f4-9a256b4810db" });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 773, DateTimeKind.Local).AddTicks(1179), new DateTime(2026, 6, 2, 15, 34, 22, 773, DateTimeKind.Local).AddTicks(1181) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(1112), new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8595), new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8607), new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8608), new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8610), new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8612), new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8613), new DateTime(2026, 6, 2, 15, 34, 22, 774, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(395), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1802), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1807), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1809), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1811), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5860), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5886), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5890), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5893), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5897), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5900), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5904), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5908), new DateTime(2026, 6, 2, 15, 34, 22, 775, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7299), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7321), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7339), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7655), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7661), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7663), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7675), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7678), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7680), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7682), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7685), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7687), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7690), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7692), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7695), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7698), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7701), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7705), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7707), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7709), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7713), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7715), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7717), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7722), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7724), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7726), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7728), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7730), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7732), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7734), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7736), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7738), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7741), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7742), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7744), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7748), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7750), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7752), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7755), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7756), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7758), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7763), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7765), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7767), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7770), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7827), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7829), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7831), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7834), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7836), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7838), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7840), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7843), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7846), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7848), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7850), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7853), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7856), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7858), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7861), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7863), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7866), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7869), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7871), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7874), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7876), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7878), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7883), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7886), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7888), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7891), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7893), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7896), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3487), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3519), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3522), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3526), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3530), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3534), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3537), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3541), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3544), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3547), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3552), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3555), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3570), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3573), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3576), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3579), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3768), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3777), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3781), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3785), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3789), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3792), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3796), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3801), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3805), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3809), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3812), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3816), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3819), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3823), new DateTime(2026, 6, 2, 15, 34, 22, 776, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3491), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3512), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3517), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3519), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3522), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(8237), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(8268), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(8273), new DateTime(2026, 6, 2, 15, 34, 22, 777, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5113), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5130), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5133), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5134), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5136), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5139), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5140), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5142), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5144), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5300), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5302), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5303), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5306), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5307), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5309), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5311), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5313), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5314), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5316), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5317), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5319), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5320), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5322), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5324), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5326), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5326), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5327), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5328), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5329), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5330), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5331), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5331), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5334), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5335), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5336), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5337), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5338), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5338), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5339), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5340), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5341), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5342), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5343), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5343), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5345), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5345), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5346), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5347), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5348), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5349), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5350), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5351), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5352), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5353), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5354), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5354), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5355), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5355), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5357), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5357), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5359), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5359), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5360), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5361), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5362), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5363), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5364), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5365), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5366), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5367), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5368), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5368), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5369), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5370), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5371), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5372), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5373), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5374), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5375), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5375), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5376), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5377), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5378), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5379), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5380), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5380), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5383), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5383), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5385), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5386), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5387), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5388), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5389), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5390), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5391), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5391), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5392), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5393), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5394), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5395), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5396), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5397), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5398), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5398), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5399), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5400), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5401), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5401), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5402), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5403), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5404), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5405), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5406), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5406), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5407), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5408), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5409), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5410), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5411), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5411), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5413), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5413), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5415), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5415), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5416), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5417), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5419), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5419), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5421), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5421), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5423), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5423), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5424), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5425), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5426), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5427), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5428), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5428), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5429), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5430), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5432), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5432), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5434), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5434), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5435), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5436), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5439), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5440), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5441), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5441), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5442), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5443), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5444), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5444), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5446), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5446), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5447), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5447), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5449), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5449), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5450), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5451), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5452), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5452), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5453), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5454), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5455), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5455), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5456), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5457), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5458), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5459), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5460), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5460), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5461), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5462), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5463), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5464), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5465), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5465), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5466), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5467), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5468), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5468), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5469), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5470), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5471), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5472), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5473), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5473), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5474), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5475), "ServiceDefinition" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5476), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5479), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5480), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5609), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5611), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5613), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5614), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5616), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5618), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5620), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5622), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5623), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5625), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5627), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5629), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5631), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5632), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5634), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5635), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5637), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5639), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5641), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5642), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5644), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5646), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5648), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5650), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5651), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5654), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5656), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5657), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5659), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5661), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5663), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5664), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5666), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5668), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5670), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5671), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5673), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5674), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5676), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5677), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5679), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5681), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5683), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5684), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5686), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5687), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5689), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5691), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5692), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5694), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5696), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5699), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5700), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5702), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5704), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5706), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5707), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5709), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5710), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5712), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5713), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5715), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5717), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5719), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5720), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5722), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5723), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5725), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5727), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5729), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5731), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5732), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5734), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5736), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5738), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5739), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5741), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5743), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5744), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5747), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5749), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5750), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5752), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5754), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5755), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5758), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5759), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5761), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5763), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5765), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5766), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5767), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5769), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8652), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8714), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8756), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8801), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8888), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8929), new DateTime(2026, 6, 2, 15, 34, 22, 778, DateTimeKind.Local).AddTicks(8930) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(7385), new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(7402), new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(8766), new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(8772), new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "ContentsOfFood",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(8773), new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(9944), new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(9948), new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(9950), new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(9952), new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(9954), new DateTime(2026, 6, 2, 15, 32, 15, 475, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(830), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(838), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(896), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(899), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(902), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1785), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1786), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1791), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1792), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1793), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1794), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1795), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1795), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "EmployeeDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "StartDateOfWork" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1797), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1797), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2595), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2639), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2640), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2641), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2642), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2643), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2644), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2644), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2645), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2646), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2647), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2648), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2648), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2649), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2650), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2651), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2651), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2652), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2653), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2654), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2655), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2655), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2656), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2657), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2658), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(3504), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(3507), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "FoodMenuCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(5266), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "FoodMenuCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(5271), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(6112), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(6114), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(6115), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(6117), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "FoodType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(6117), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "GuestStays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "ModifyDate", "VerificationCode" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(6988), new DateTime(2026, 6, 4, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(6990), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(7124), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(7125), "38e4e3ff-7b55-40e9-b3a2-579164e620df" });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(8154), new DateTime(2026, 6, 2, 15, 32, 15, 476, DateTimeKind.Local).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(2264), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(6182), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(6187), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(6188), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(6188), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(6189), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(6190), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(7165), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(8116), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(8119), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(8120), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(8121), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9031), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9043), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9045), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9047), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9049), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9051), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9053), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9055), new DateTime(2026, 6, 2, 15, 32, 15, 477, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1452), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1459), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1467), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1468), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1470), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1471), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1507), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1509), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1510), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1512), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1514), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1516), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1518), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1519), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1521), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1523), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1524), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1527), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1528), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1529), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1532), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1533), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1534), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1536), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1537), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1538), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1540), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1541), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1542), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1544), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1545), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1546), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1547), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1548), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1549), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1552), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1553), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1554), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1556), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1557), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1558), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1560), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1561), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1563), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1564), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1566), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1567), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1619), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1621), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1622), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1623), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1625), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1628), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1629), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1630), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1632), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1633), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1635), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1636), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1638), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1639), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1641), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1642), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1643), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1645), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1646), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1647), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1650), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1651), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1652), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1654), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1655), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitionFields",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1657), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(364), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(381), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(384), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(386), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(389), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(391), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(394), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(396), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(398), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(401), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(403), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(405), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(408), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(410), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(412), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(414), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(416), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(463), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(466), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(468), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(470), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(473), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(475), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(477), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(479), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(481), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(483), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(485), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(487), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "ServiceDefinitions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(488), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(2721), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(2727), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(2729), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(2731), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "ServiceRoleAssignment",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(2733), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(3684), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(3694), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(3697), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7005), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7013), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7014), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7016), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7017), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7018), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7019), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7020), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7021), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7022), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7023), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7024), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7025), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7026), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7027), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7028), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7093), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7095), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7096), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7097), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7099), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7100), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7102), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7103), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7105), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7105), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7106), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7107), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7108), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7108), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7111), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7111), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7112), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7112), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7113), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7114), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7115), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7115), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7116), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7116), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7117), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7118), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7119), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7119), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7120), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7120), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7121), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7122), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7123), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7123), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7124), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7125), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7125), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7126), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7127), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7127), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7128), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7128), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7129), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7130), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7131), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7131), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7132), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7133), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7133), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7134), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7135), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7135), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7136), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7136), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7137), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7137), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7138), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7139), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7139), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7140), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7141), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7141), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7142), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7143), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7143), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7144), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7146), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7146), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7148), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7148), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7149), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7149), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7150), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7150), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7151), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7152), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7152), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7153), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7153), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7154), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7155), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7155), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7156), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7156), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7157), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7158), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7158), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7159), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7159), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7160), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7161), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7161), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7162), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7162), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7163), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7163), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7164), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7165), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7165), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7166), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7167), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7167), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7168), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7168), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7169), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7170), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7171), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7172), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7173), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7173), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7174), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7174), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7175), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7176), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7177), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7177), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7178), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7178), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7179), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7180), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7182), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7182), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7183), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7183), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7184), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7184), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7185), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7186), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7187), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7187), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7188), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7188), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7189), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7190), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7190), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7191), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7192), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7192), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7193), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7193), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7194), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7195), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7195), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7196), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7196), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7197), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7198), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7198), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7199), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7199), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7200), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7201), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7202), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7202), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7203), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7204), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7204), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7205), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7206), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7206), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7207), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7207), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7208), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7209), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7210), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7210), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7211), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7211), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7212), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7213), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7213), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7214), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7215), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7215), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifyDate", "TableName" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7217), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7218), "TechnicalNeed" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7220), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7221), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7222), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7224), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7225), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7226), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7228), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7229), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7230), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7232), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7233), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7275), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7277), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7278), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7280), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7281), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7283), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7284), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7285), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7286), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7288), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7289), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7291), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7292), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7294), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7295), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7298), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7300), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7301), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7302), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7303), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7305), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7306), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7307), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7309), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7310), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7311), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7312), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7314), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7315), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7317), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7318), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7319), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7320), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7322), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7323), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7324), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7326), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7327), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7328), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7329), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7330), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7331), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7334), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7335), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7337), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7338), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7339), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7340), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7342), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7344), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7345), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7346), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7347), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7349), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7350), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7351), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7353), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7354), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7355), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7357), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7358), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7360), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7361), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7362), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7364), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7365), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7366), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7367), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7369), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7371), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7372), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7374), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7375), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7376), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7378), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7379), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7380), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7381), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7382), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7384), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7385), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7386), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7387), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7389), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7390), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(9043), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(9076), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(9097), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(9117), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(9162), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(9183), new DateTime(2026, 6, 2, 15, 32, 15, 478, DateTimeKind.Local).AddTicks(9183) });
        }
    }
}
