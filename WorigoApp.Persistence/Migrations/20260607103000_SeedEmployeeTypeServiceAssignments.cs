using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployeeTypeServiceAssignments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                DECLARE @TemplateHotelId int = 1;

                MERGE [ServiceRoleAssignment] AS target
                USING (
                    SELECT
                        targetHotel.Id AS HotelId,
                        targetDepartment.Id AS DepartmentId,
                        seed.ServiceId,
                        seed.ServicesEnumId,
                        targetEmployeeType.Id AS EmployeeTypeRoleId,
                        CAST(CASE WHEN seed.Priority = 1 THEN 1 ELSE 0 END AS bit) AS IsPrimaryAssignment,
                        seed.Priority,
                        seed.SlaMinutes
                    FROM (VALUES
                        (1, 3, 17, 3, 1, 30),
                        (1, 3, 18, 3, 2, 30),
                        (1, 3, 19, 3, 3, 30),
                        (1, 3, 20, 3, 4, 30),
                        (3, 1, 6, 1, 1, 10),
                        (3, 1, 5, 1, 2, 10),
                        (6, 2, 12, 2, 1, 20),
                        (6, 2, 11, 2, 2, 20),
                        (6, 2, 13, 2, 3, 25),
                        (6, 2, 10, 2, 4, 30),
                        (14, 2, 12, 2, 1, 20),
                        (14, 2, 13, 2, 2, 20),
                        (14, 2, 11, 2, 3, 25),
                        (11, 1, 4, 1, 1, 5),
                        (11, 1, 3, 1, 2, 5),
                        (11, 1, 2, 1, 3, 5),
                        (2, 4, 22, 4, 1, 30),
                        (2, 4, 23, 4, 2, 30),
                        (2, 4, 24, 4, 3, 30),
                        (2, 4, 21, 4, 4, 30),
                        (4, 4, 22, 4, 1, 30),
                        (4, 4, 21, 4, 2, 30),
                        (5, 2, 10, 2, 1, 60),
                        (5, 2, 11, 2, 2, 60),
                        (5, 2, 12, 2, 3, 60),
                        (7, 5, 25, 5, 1, 60),
                        (8, 1, 8, 1, 1, 10),
                        (8, 1, 1, 1, 2, 10),
                        (8, 1, 2, 1, 3, 10),
                        (9, 1, 5, 1, 1, 30),
                        (9, 1, 6, 1, 2, 30),
                        (12, 1, 6, 1, 1, 20),
                        (12, 1, 5, 1, 2, 20),
                        (10, 3, 20, 3, 1, 30),
                        (10, 3, 15, 3, 2, 30),
                        (10, 3, 16, 3, 3, 30),
                        (13, 1, 4, 1, 1, 15),
                        (13, 1, 3, 1, 2, 15),
                        (15, 1, 8, 1, 1, 5),
                        (15, 1, 1, 1, 2, 5)
                    ) AS seed(ServicesEnumId, SourceDepartmentId, SourceEmployeeTypeId, ServiceId, Priority, SlaMinutes)
                    INNER JOIN [Department] sourceDepartment
                        ON sourceDepartment.Id = seed.SourceDepartmentId
                       AND sourceDepartment.HotelId = @TemplateHotelId
                       AND sourceDepartment.IsDeleted = 0
                    INNER JOIN [EmployeeType] sourceEmployeeType
                        ON sourceEmployeeType.Id = seed.SourceEmployeeTypeId
                       AND sourceEmployeeType.DepartmentId = sourceDepartment.Id
                       AND sourceEmployeeType.IsDeleted = 0
                    INNER JOIN [Hotel] targetHotel
                        ON targetHotel.IsDeleted = 0
                    INNER JOIN [Department] targetDepartment
                        ON targetDepartment.HotelId = targetHotel.Id
                       AND targetDepartment.Name = sourceDepartment.Name
                       AND targetDepartment.IsDeleted = 0
                    INNER JOIN [EmployeeType] targetEmployeeType
                        ON targetEmployeeType.DepartmentId = targetDepartment.Id
                       AND targetEmployeeType.Name = sourceEmployeeType.Name
                       AND targetEmployeeType.IsDeleted = 0
                ) AS source
                ON target.HotelId = source.HotelId
                   AND target.ServicesEnumId = source.ServicesEnumId
                   AND target.Priority = source.Priority
                   AND target.IsDeleted = 0
                WHEN MATCHED THEN
                    UPDATE SET
                        target.IsActive = 1,
                        target.DepartmentId = source.DepartmentId,
                        target.ServiceId = source.ServiceId,
                        target.EmployeeTypeRoleId = source.EmployeeTypeRoleId,
                        target.IsPrimaryAssignment = source.IsPrimaryAssignment,
                        target.SlaMinutes = source.SlaMinutes,
                        target.ModifyDate = SYSUTCDATETIME()
                WHEN NOT MATCHED THEN
                    INSERT (
                        CreatedDate, ModifyDate, IsDeleted, IsActive,
                        HotelId, DepartmentId, ServiceId, ServicesEnumId,
                        EmployeeTypeRoleId, IsPrimaryAssignment, Priority, SlaMinutes
                    )
                    VALUES (
                        SYSUTCDATETIME(), SYSUTCDATETIME(), 0, 1,
                        source.HotelId, source.DepartmentId, source.ServiceId, source.ServicesEnumId,
                        source.EmployeeTypeRoleId, source.IsPrimaryAssignment, source.Priority, source.SlaMinutes
                    );
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Seed and backfill migration. Intentionally left as no-op to avoid removing hotel-managed rules.
        }
    }
}
