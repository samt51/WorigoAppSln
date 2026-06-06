using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BackfillServiceCatalogForExistingHotels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                DECLARE @TemplateHotelId int = 1;
                DECLARE @HotelId int;

                DECLARE hotel_cursor CURSOR LOCAL FAST_FORWARD FOR
                    SELECT Id
                    FROM [Hotel]
                    WHERE Id <> @TemplateHotelId
                      AND IsDeleted = 0;

                OPEN hotel_cursor;
                FETCH NEXT FROM hotel_cursor INTO @HotelId;

                WHILE @@FETCH_STATUS = 0
                BEGIN
                    DECLARE @CategoryMap TABLE (TemplateId int NOT NULL, NewId int NOT NULL);
                    DECLARE @DefinitionMap TABLE (TemplateId int NOT NULL, NewId int NOT NULL);
                    DECLARE @FieldMap TABLE (TemplateId int NOT NULL, NewId int NOT NULL);
                    DECLARE @OptionMap TABLE (TemplateId int NOT NULL, NewId int NOT NULL);

                    UPDATE target
                    SET
                        target.IsActive = 1,
                        target.ModifyDate = SYSUTCDATETIME()
                    FROM [ServiceCategories] target
                    INNER JOIN [ServiceCategories] source
                        ON source.HotelId = @TemplateHotelId
                       AND source.IsDeleted = 0
                       AND target.HotelId = @HotelId
                       AND target.IsDeleted = 0
                       AND target.Name = source.Name
                       AND target.DisplayOrder = source.DisplayOrder;

                    INSERT INTO [ServiceCategories] (
                        CreatedDate, ModifyDate, IsDeleted, IsActive,
                        HotelId, Name, Description, IconUrl, IconKey,
                        DisplayOrder, ShowOnHome, IsPopular, HomeDisplayOrder, LegacyServiceType
                    )
                    SELECT
                        SYSUTCDATETIME(), SYSUTCDATETIME(), 0, 1,
                        @HotelId, source.Name, source.Description, source.IconUrl, source.IconKey,
                        source.DisplayOrder, source.ShowOnHome, source.IsPopular, source.HomeDisplayOrder, source.LegacyServiceType
                    FROM [ServiceCategories] source
                    WHERE source.HotelId = @TemplateHotelId
                      AND source.IsDeleted = 0
                      AND NOT EXISTS (
                          SELECT 1
                          FROM [ServiceCategories] target
                          WHERE target.HotelId = @HotelId
                            AND target.IsDeleted = 0
                            AND target.Name = source.Name
                            AND target.DisplayOrder = source.DisplayOrder
                      );

                    INSERT INTO @CategoryMap (TemplateId, NewId)
                    SELECT source.Id, MIN(target.Id)
                    FROM [ServiceCategories] source
                    INNER JOIN [ServiceCategories] target
                        ON target.HotelId = @HotelId
                       AND target.IsDeleted = 0
                       AND target.Name = source.Name
                       AND target.DisplayOrder = source.DisplayOrder
                    WHERE source.HotelId = @TemplateHotelId
                      AND source.IsDeleted = 0
                    GROUP BY source.Id;

                    UPDATE target
                    SET
                        target.IsActive = 1,
                        target.IsVisibleToGuest = 1,
                        target.ModifyDate = SYSUTCDATETIME()
                    FROM [ServiceDefinitions] target
                    INNER JOIN [ServiceDefinitions] source
                        ON source.HotelId = @TemplateHotelId
                       AND source.IsDeleted = 0
                    INNER JOIN @CategoryMap categoryMap
                        ON categoryMap.TemplateId = source.ServiceCategoryId
                    WHERE target.HotelId = @HotelId
                      AND target.IsDeleted = 0
                      AND target.ServiceCategoryId = categoryMap.NewId
                      AND target.ServiceType = source.ServiceType
                      AND target.Name = source.Name;

                    INSERT INTO [ServiceDefinitions] (
                        CreatedDate, ModifyDate, IsDeleted, IsActive,
                        HotelId, ServiceCategoryId, DepartmentId, ServiceType,
                        Name, Description, ImageUrl, OpeningMessage,
                        IsVisibleToGuest, IsChargeable, SupportsFreeText, RequiresAppointment,
                        FlowUiType, EstimatedDurationMinutes, DisplayOrder, Price, CurrencyCode
                    )
                    SELECT
                        SYSUTCDATETIME(), SYSUTCDATETIME(), 0, 1,
                        @HotelId, categoryMap.NewId, targetDepartment.Id, source.ServiceType,
                        source.Name, source.Description, source.ImageUrl, source.OpeningMessage,
                        1, source.IsChargeable, source.SupportsFreeText, source.RequiresAppointment,
                        source.FlowUiType, source.EstimatedDurationMinutes, source.DisplayOrder, source.Price, source.CurrencyCode
                    FROM [ServiceDefinitions] source
                    INNER JOIN @CategoryMap categoryMap
                        ON categoryMap.TemplateId = source.ServiceCategoryId
                    LEFT JOIN [Department] sourceDepartment
                        ON sourceDepartment.Id = source.DepartmentId
                    LEFT JOIN [Department] targetDepartment
                        ON targetDepartment.HotelId = @HotelId
                       AND targetDepartment.IsDeleted = 0
                       AND sourceDepartment.Id IS NOT NULL
                       AND targetDepartment.Name = sourceDepartment.Name
                    WHERE source.HotelId = @TemplateHotelId
                      AND source.IsDeleted = 0
                      AND NOT EXISTS (
                          SELECT 1
                          FROM [ServiceDefinitions] target
                          WHERE target.HotelId = @HotelId
                            AND target.IsDeleted = 0
                            AND target.ServiceCategoryId = categoryMap.NewId
                            AND target.ServiceType = source.ServiceType
                            AND target.Name = source.Name
                      );

                    INSERT INTO @DefinitionMap (TemplateId, NewId)
                    SELECT source.Id, MIN(target.Id)
                    FROM [ServiceDefinitions] source
                    INNER JOIN @CategoryMap categoryMap
                        ON categoryMap.TemplateId = source.ServiceCategoryId
                    INNER JOIN [ServiceDefinitions] target
                        ON target.HotelId = @HotelId
                       AND target.IsDeleted = 0
                       AND target.ServiceCategoryId = categoryMap.NewId
                       AND target.ServiceType = source.ServiceType
                       AND target.Name = source.Name
                    WHERE source.HotelId = @TemplateHotelId
                      AND source.IsDeleted = 0
                    GROUP BY source.Id;

                    UPDATE target
                    SET
                        target.IsActive = 1,
                        target.ModifyDate = SYSUTCDATETIME()
                    FROM [ServiceDefinitionFields] target
                    INNER JOIN [ServiceDefinitionFields] source
                        ON source.IsDeleted = 0
                    INNER JOIN @DefinitionMap definitionMap
                        ON definitionMap.TemplateId = source.ServiceDefinitionId
                    WHERE target.ServiceDefinitionId = definitionMap.NewId
                      AND target.IsDeleted = 0
                      AND target.FieldKey = source.FieldKey
                      AND target.DisplayOrder = source.DisplayOrder;

                    INSERT INTO [ServiceDefinitionFields] (
                        CreatedDate, ModifyDate, IsDeleted, IsActive,
                        ServiceDefinitionId, FieldKey, Label, Placeholder, FieldType,
                        IsRequired, DisplayOrder, OptionsJson, ValidationRegex, DefaultValue
                    )
                    SELECT
                        SYSUTCDATETIME(), SYSUTCDATETIME(), 0, 1,
                        definitionMap.NewId, source.FieldKey, source.Label, source.Placeholder, source.FieldType,
                        source.IsRequired, source.DisplayOrder, source.OptionsJson, source.ValidationRegex, source.DefaultValue
                    FROM [ServiceDefinitionFields] source
                    INNER JOIN @DefinitionMap definitionMap
                        ON definitionMap.TemplateId = source.ServiceDefinitionId
                    WHERE source.IsDeleted = 0
                      AND NOT EXISTS (
                          SELECT 1
                          FROM [ServiceDefinitionFields] target
                          WHERE target.ServiceDefinitionId = definitionMap.NewId
                            AND target.IsDeleted = 0
                            AND target.FieldKey = source.FieldKey
                            AND target.DisplayOrder = source.DisplayOrder
                      );

                    INSERT INTO @FieldMap (TemplateId, NewId)
                    SELECT source.Id, MIN(target.Id)
                    FROM [ServiceDefinitionFields] source
                    INNER JOIN @DefinitionMap definitionMap
                        ON definitionMap.TemplateId = source.ServiceDefinitionId
                    INNER JOIN [ServiceDefinitionFields] target
                        ON target.ServiceDefinitionId = definitionMap.NewId
                       AND target.IsDeleted = 0
                       AND target.FieldKey = source.FieldKey
                       AND target.DisplayOrder = source.DisplayOrder
                    WHERE source.IsDeleted = 0
                    GROUP BY source.Id;

                    UPDATE target
                    SET
                        target.IsActive = 1,
                        target.ModifyDate = SYSUTCDATETIME()
                    FROM [ServiceDefinitionFieldOptions] target
                    INNER JOIN [ServiceDefinitionFieldOptions] source
                        ON source.IsDeleted = 0
                    INNER JOIN @FieldMap fieldMap
                        ON fieldMap.TemplateId = source.ServiceDefinitionFieldId
                    WHERE target.ServiceDefinitionFieldId = fieldMap.NewId
                      AND target.IsDeleted = 0
                      AND target.Value = source.Value;

                    INSERT INTO [ServiceDefinitionFieldOptions] (
                        CreatedDate, ModifyDate, IsDeleted, IsActive,
                        ServiceDefinitionFieldId, Value, Label, DisplayOrder
                    )
                    SELECT
                        SYSUTCDATETIME(), SYSUTCDATETIME(), 0, 1,
                        fieldMap.NewId, source.Value, source.Label, source.DisplayOrder
                    FROM [ServiceDefinitionFieldOptions] source
                    INNER JOIN @FieldMap fieldMap
                        ON fieldMap.TemplateId = source.ServiceDefinitionFieldId
                    WHERE source.IsDeleted = 0
                      AND NOT EXISTS (
                          SELECT 1
                          FROM [ServiceDefinitionFieldOptions] target
                          WHERE target.ServiceDefinitionFieldId = fieldMap.NewId
                            AND target.IsDeleted = 0
                            AND target.Value = source.Value
                      );

                    INSERT INTO @OptionMap (TemplateId, NewId)
                    SELECT source.Id, MIN(target.Id)
                    FROM [ServiceDefinitionFieldOptions] source
                    INNER JOIN @FieldMap fieldMap
                        ON fieldMap.TemplateId = source.ServiceDefinitionFieldId
                    INNER JOIN [ServiceDefinitionFieldOptions] target
                        ON target.ServiceDefinitionFieldId = fieldMap.NewId
                       AND target.IsDeleted = 0
                       AND target.Value = source.Value
                    WHERE source.IsDeleted = 0
                    GROUP BY source.Id;

                    DECLARE @TranslationMap TABLE (TableName nvarchar(128) NOT NULL, TemplateId int NOT NULL, NewId int NOT NULL);

                    INSERT INTO @TranslationMap (TableName, TemplateId, NewId)
                    SELECT N'ServiceCategory', TemplateId, NewId FROM @CategoryMap
                    UNION ALL
                    SELECT N'ServiceDefinition', TemplateId, NewId FROM @DefinitionMap
                    UNION ALL
                    SELECT N'ServiceDefinitionField', TemplateId, NewId FROM @FieldMap
                    UNION ALL
                    SELECT N'ServiceDefinitionFieldOption', TemplateId, NewId FROM @OptionMap;

                    INSERT INTO [Translations] (
                        CreatedDate, ModifyDate, IsDeleted, IsActive,
                        TableName, RecordId, FieldName, TranslationValue, LanguageCode
                    )
                    SELECT
                        SYSUTCDATETIME(), SYSUTCDATETIME(), 0, 1,
                        translation.TableName, translationMap.NewId, translation.FieldName, translation.TranslationValue, translation.LanguageCode
                    FROM [Translations] translation
                    INNER JOIN @TranslationMap translationMap
                        ON translationMap.TableName = translation.TableName
                       AND translationMap.TemplateId = translation.RecordId
                    WHERE translation.IsDeleted = 0
                      AND NOT EXISTS (
                          SELECT 1
                          FROM [Translations] existing
                          WHERE existing.IsDeleted = 0
                            AND existing.TableName = translation.TableName
                            AND existing.RecordId = translationMap.NewId
                            AND existing.FieldName = translation.FieldName
                            AND existing.LanguageCode = translation.LanguageCode
                      );

                    MERGE [HotelServicePolicies] AS target
                    USING (
                        SELECT source.*, definitionMap.NewId AS TargetDefinitionId
                        FROM [HotelServicePolicies] source
                        LEFT JOIN @DefinitionMap definitionMap ON definitionMap.TemplateId = source.ServiceDefinitionId
                        WHERE source.HotelId = @TemplateHotelId
                          AND source.IsDeleted = 0
                    ) AS source
                    ON target.HotelId = @HotelId
                       AND target.IsDeleted = 0
                       AND target.ServiceType = source.ServiceType
                       AND target.AccommodationConceptType = source.AccommodationConceptType
                       AND ISNULL(target.ServiceItemId, -1) = ISNULL(source.ServiceItemId, -1)
                       AND ISNULL(target.ServiceDefinitionId, -1) = ISNULL(source.TargetDefinitionId, -1)
                    WHEN MATCHED THEN
                        UPDATE SET
                            target.IsActive = 1,
                            target.IsVisible = 1,
                            target.ModifyDate = SYSUTCDATETIME()
                    WHEN NOT MATCHED THEN
                        INSERT (
                            CreatedDate, ModifyDate, IsDeleted, IsActive,
                            HotelId, ServiceType, ServiceItemId, ServiceDefinitionId,
                            AccommodationConceptType, IsVisible, IsIncludedInPackage, IsChargeable,
                            AllowRoomCharge, AllowOnlinePayment, AllowOnSitePayment,
                            PriceOverride, CurrencyCode, Description
                        )
                        VALUES (
                            SYSUTCDATETIME(), SYSUTCDATETIME(), 0, 1,
                            @HotelId, source.ServiceType, source.ServiceItemId, source.TargetDefinitionId,
                            source.AccommodationConceptType, 1, source.IsIncludedInPackage, source.IsChargeable,
                            source.AllowRoomCharge, source.AllowOnlinePayment, source.AllowOnSitePayment,
                            source.PriceOverride, source.CurrencyCode, source.Description
                        );

                    MERGE [ServiceRoleAssignment] AS target
                    USING (
                        SELECT
                            source.ServiceId,
                            source.ServicesEnumId,
                            targetDepartment.Id AS TargetDepartmentId,
                            targetEmployeeType.Id AS TargetEmployeeTypeRoleId,
                            MAX(CAST(source.IsPrimaryAssignment AS int)) AS IsPrimaryAssignment,
                            source.Priority,
                            MAX(source.SlaMinutes) AS SlaMinutes
                        FROM [ServiceRoleAssignment] source
                        LEFT JOIN [Department] sourceDepartment ON sourceDepartment.Id = source.DepartmentId
                        LEFT JOIN [EmployeeType] sourceEmployeeType ON sourceEmployeeType.Id = source.EmployeeTypeRoleId
                        LEFT JOIN [Department] targetDepartment
                            ON targetDepartment.HotelId = @HotelId
                           AND targetDepartment.IsDeleted = 0
                           AND sourceDepartment.Id IS NOT NULL
                           AND targetDepartment.Name = sourceDepartment.Name
                        LEFT JOIN [EmployeeType] targetEmployeeType
                            ON targetEmployeeType.DepartmentId = targetDepartment.Id
                           AND targetEmployeeType.IsDeleted = 0
                           AND sourceEmployeeType.Id IS NOT NULL
                           AND targetEmployeeType.Name = sourceEmployeeType.Name
                        WHERE source.HotelId = @TemplateHotelId
                          AND source.IsDeleted = 0
                          AND targetEmployeeType.Id IS NOT NULL
                        GROUP BY
                            source.ServiceId,
                            source.ServicesEnumId,
                            targetDepartment.Id,
                            targetEmployeeType.Id,
                            source.Priority
                    ) AS source
                    ON target.HotelId = @HotelId
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
                            @HotelId, source.TargetDepartmentId, source.ServiceId, source.ServicesEnumId,
                            source.TargetEmployeeTypeRoleId, CAST(source.IsPrimaryAssignment AS bit), source.Priority, source.SlaMinutes
                        );

                    FETCH NEXT FROM hotel_cursor INTO @HotelId;
                END

                CLOSE hotel_cursor;
                DEALLOCATE hotel_cursor;
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Data backfill only. Intentionally left as no-op to avoid deleting hotel-managed catalog changes.
        }
    }
}
