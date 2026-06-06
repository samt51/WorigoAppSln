using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveReceptionistApplicationRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                DECLARE @EmployeeRoleId int;
                DECLARE @ReceptionistRoleId int;

                SELECT @EmployeeRoleId = Id
                FROM [Roles]
                WHERE Name = N'Employee'
                  AND IsDeleted = 0;

                SELECT @ReceptionistRoleId = Id
                FROM [Roles]
                WHERE Name = N'Resepsiyonist'
                  AND IsDeleted = 0;

                IF @EmployeeRoleId IS NOT NULL AND @ReceptionistRoleId IS NOT NULL
                BEGIN
                    UPDATE [Users]
                    SET RoleId = @EmployeeRoleId,
                        ModifyDate = SYSUTCDATETIME()
                    WHERE RoleId = @ReceptionistRoleId
                      AND IsDeleted = 0;

                    UPDATE [Roles]
                    SET IsDeleted = 1,
                        IsActive = 0,
                        ModifyDate = SYSUTCDATETIME()
                    WHERE Id = @ReceptionistRoleId;
                END
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                IF NOT EXISTS (
                    SELECT 1
                    FROM [Roles]
                    WHERE Name = N'Resepsiyonist'
                      AND IsDeleted = 0
                )
                BEGIN
                    INSERT INTO [Roles] (
                        CreatedDate, ModifyDate, IsDeleted, IsActive, Name
                    )
                    VALUES (
                        SYSUTCDATETIME(), SYSUTCDATETIME(), 0, 1, N'Resepsiyonist'
                    );
                END
                """);
        }
    }
}
