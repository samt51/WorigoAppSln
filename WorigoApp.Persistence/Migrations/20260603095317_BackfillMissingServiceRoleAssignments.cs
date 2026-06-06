using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BackfillMissingServiceRoleAssignments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                DECLARE @TemplateHotelId int = 1;

                INSERT INTO [EmployeeType] (
                    CreatedDate, ModifyDate, IsDeleted, IsActive,
                    Name, DepartmentId
                )
                SELECT
                    SYSUTCDATETIME(), SYSUTCDATETIME(), 0, 1,
                    sourceEmployeeType.Name, targetDepartment.Id
                FROM [EmployeeType] sourceEmployeeType
                INNER JOIN [Department] sourceDepartment
                    ON sourceDepartment.Id = sourceEmployeeType.DepartmentId
                   AND sourceDepartment.HotelId = @TemplateHotelId
                   AND sourceDepartment.IsDeleted = 0
                INNER JOIN [Department] targetDepartment
                    ON targetDepartment.HotelId <> @TemplateHotelId
                   AND targetDepartment.IsDeleted = 0
                   AND targetDepartment.Name = sourceDepartment.Name
                WHERE sourceEmployeeType.IsDeleted = 0
                  AND NOT EXISTS (
                      SELECT 1
                      FROM [EmployeeType] existingEmployeeType
                      WHERE existingEmployeeType.DepartmentId = targetDepartment.Id
                        AND existingEmployeeType.IsDeleted = 0
                        AND existingEmployeeType.Name = sourceEmployeeType.Name
                  );

                MERGE [ServiceRoleAssignment] AS target
                USING (
                    SELECT
                        targetHotel.Id AS TargetHotelId,
                        targetDepartment.Id AS TargetDepartmentId,
                        source.ServiceId,
                        source.ServicesEnumId,
                        targetEmployeeType.Id AS TargetEmployeeTypeRoleId,
                        MAX(CAST(source.IsPrimaryAssignment AS int)) AS IsPrimaryAssignment,
                        source.Priority,
                        MAX(source.SlaMinutes) AS SlaMinutes
                    FROM [Hotel] targetHotel
                    INNER JOIN [ServiceRoleAssignment] source
                        ON source.HotelId = @TemplateHotelId
                       AND source.IsDeleted = 0
                    INNER JOIN [Department] sourceDepartment
                        ON sourceDepartment.Id = source.DepartmentId
                       AND sourceDepartment.IsDeleted = 0
                    INNER JOIN [EmployeeType] sourceEmployeeType
                        ON sourceEmployeeType.Id = source.EmployeeTypeRoleId
                       AND sourceEmployeeType.IsDeleted = 0
                    INNER JOIN [Department] targetDepartment
                        ON targetDepartment.HotelId = targetHotel.Id
                       AND targetDepartment.IsDeleted = 0
                       AND targetDepartment.Name = sourceDepartment.Name
                    INNER JOIN [EmployeeType] targetEmployeeType
                        ON targetEmployeeType.DepartmentId = targetDepartment.Id
                       AND targetEmployeeType.IsDeleted = 0
                       AND targetEmployeeType.Name = sourceEmployeeType.Name
                    WHERE targetHotel.Id <> @TemplateHotelId
                      AND targetHotel.IsDeleted = 0
                    GROUP BY
                        targetHotel.Id,
                        targetDepartment.Id,
                        source.ServiceId,
                        source.ServicesEnumId,
                        targetEmployeeType.Id,
                        source.Priority
                ) AS source
                ON target.HotelId = source.TargetHotelId
                   AND target.IsDeleted = 0
                   AND target.ServiceId = source.ServiceId
                   AND target.ServicesEnumId = source.ServicesEnumId
                   AND target.EmployeeTypeRoleId = source.TargetEmployeeTypeRoleId
                   AND target.Priority = source.Priority
                WHEN MATCHED THEN
                    UPDATE SET
                        target.IsActive = 1,
                        target.DepartmentId = source.TargetDepartmentId,
                        target.IsPrimaryAssignment = CAST(source.IsPrimaryAssignment AS bit),
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
                        source.TargetHotelId, source.TargetDepartmentId, source.ServiceId, source.ServicesEnumId,
                        source.TargetEmployeeTypeRoleId, CAST(source.IsPrimaryAssignment AS bit), source.Priority, source.SlaMinutes
                    );
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Data backfill only. Intentionally left as no-op to avoid deleting hotel-managed role changes.
        }
    }
}
