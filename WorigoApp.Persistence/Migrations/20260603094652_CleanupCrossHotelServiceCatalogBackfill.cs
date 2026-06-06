using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CleanupCrossHotelServiceCatalogBackfill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                DECLARE @TemplateHotelId int = 1;

                DECLARE @InvalidDefinitionIds TABLE (Id int NOT NULL PRIMARY KEY);
                DECLARE @InvalidFieldIds TABLE (Id int NOT NULL PRIMARY KEY);
                DECLARE @InvalidOptionIds TABLE (Id int NOT NULL PRIMARY KEY);

                INSERT INTO @InvalidDefinitionIds (Id)
                SELECT definition.Id
                FROM [ServiceDefinitions] definition
                LEFT JOIN [ServiceCategories] category
                    ON category.Id = definition.ServiceCategoryId
                WHERE definition.IsDeleted = 0
                  AND (
                      category.Id IS NULL
                      OR category.IsDeleted = 1
                      OR category.HotelId <> definition.HotelId
                  );

                INSERT INTO @InvalidFieldIds (Id)
                SELECT field.Id
                FROM [ServiceDefinitionFields] field
                INNER JOIN @InvalidDefinitionIds invalidDefinition
                    ON invalidDefinition.Id = field.ServiceDefinitionId
                WHERE field.IsDeleted = 0;

                INSERT INTO @InvalidOptionIds (Id)
                SELECT [option].Id
                FROM [ServiceDefinitionFieldOptions] [option]
                INNER JOIN @InvalidFieldIds invalidField
                    ON invalidField.Id = [option].ServiceDefinitionFieldId
                WHERE [option].IsDeleted = 0;

                UPDATE [Translations]
                SET IsDeleted = 1,
                    IsActive = 0,
                    ModifyDate = SYSUTCDATETIME()
                WHERE IsDeleted = 0
                  AND (
                      (TableName = N'ServiceDefinition' AND RecordId IN (SELECT Id FROM @InvalidDefinitionIds))
                      OR (TableName = N'ServiceDefinitionField' AND RecordId IN (SELECT Id FROM @InvalidFieldIds))
                      OR (TableName = N'ServiceDefinitionFieldOption' AND RecordId IN (SELECT Id FROM @InvalidOptionIds))
                  );

                UPDATE [HotelServicePolicies]
                SET IsDeleted = 1,
                    IsActive = 0,
                    IsVisible = 0,
                    ModifyDate = SYSUTCDATETIME()
                WHERE IsDeleted = 0
                  AND ServiceDefinitionId IN (SELECT Id FROM @InvalidDefinitionIds);

                UPDATE [ServiceDefinitionFieldOptions]
                SET IsDeleted = 1,
                    IsActive = 0,
                    ModifyDate = SYSUTCDATETIME()
                WHERE Id IN (SELECT Id FROM @InvalidOptionIds);

                UPDATE [ServiceDefinitionFields]
                SET IsDeleted = 1,
                    IsActive = 0,
                    ModifyDate = SYSUTCDATETIME()
                WHERE Id IN (SELECT Id FROM @InvalidFieldIds);

                UPDATE [ServiceDefinitions]
                SET IsDeleted = 1,
                    IsActive = 0,
                    IsVisibleToGuest = 0,
                    ModifyDate = SYSUTCDATETIME()
                WHERE Id IN (SELECT Id FROM @InvalidDefinitionIds);

                INSERT INTO [ServiceDefinitionFields] (
                    CreatedDate, ModifyDate, IsDeleted, IsActive,
                    ServiceDefinitionId, FieldKey, Label, Placeholder, FieldType,
                    IsRequired, DisplayOrder, OptionsJson, ValidationRegex, DefaultValue
                )
                SELECT
                    SYSUTCDATETIME(), SYSUTCDATETIME(), 0, 1,
                    targetDefinition.Id, sourceField.FieldKey, sourceField.Label, sourceField.Placeholder, sourceField.FieldType,
                    sourceField.IsRequired, sourceField.DisplayOrder, sourceField.OptionsJson, sourceField.ValidationRegex, sourceField.DefaultValue
                FROM [ServiceDefinitionFields] sourceField
                INNER JOIN [ServiceDefinitions] sourceDefinition
                    ON sourceDefinition.Id = sourceField.ServiceDefinitionId
                   AND sourceDefinition.HotelId = @TemplateHotelId
                   AND sourceDefinition.IsDeleted = 0
                INNER JOIN [ServiceCategories] sourceCategory
                    ON sourceCategory.Id = sourceDefinition.ServiceCategoryId
                   AND sourceCategory.IsDeleted = 0
                INNER JOIN [ServiceCategories] targetCategory
                    ON targetCategory.HotelId <> @TemplateHotelId
                   AND targetCategory.IsDeleted = 0
                   AND targetCategory.Name = sourceCategory.Name
                   AND targetCategory.DisplayOrder = sourceCategory.DisplayOrder
                INNER JOIN [ServiceDefinitions] targetDefinition
                    ON targetDefinition.HotelId = targetCategory.HotelId
                   AND targetDefinition.IsDeleted = 0
                   AND targetDefinition.ServiceCategoryId = targetCategory.Id
                   AND targetDefinition.ServiceType = sourceDefinition.ServiceType
                   AND targetDefinition.Name = sourceDefinition.Name
                WHERE sourceField.IsDeleted = 0
                  AND NOT EXISTS (
                      SELECT 1
                      FROM [ServiceDefinitionFields] existingField
                      WHERE existingField.ServiceDefinitionId = targetDefinition.Id
                        AND existingField.IsDeleted = 0
                        AND existingField.FieldKey = sourceField.FieldKey
                        AND existingField.DisplayOrder = sourceField.DisplayOrder
                  );

                INSERT INTO [ServiceDefinitionFieldOptions] (
                    CreatedDate, ModifyDate, IsDeleted, IsActive,
                    ServiceDefinitionFieldId, Value, Label, DisplayOrder
                )
                SELECT
                    SYSUTCDATETIME(), SYSUTCDATETIME(), 0, 1,
                    targetField.Id, sourceOption.Value, sourceOption.Label, sourceOption.DisplayOrder
                FROM [ServiceDefinitionFieldOptions] sourceOption
                INNER JOIN [ServiceDefinitionFields] sourceField
                    ON sourceField.Id = sourceOption.ServiceDefinitionFieldId
                   AND sourceField.IsDeleted = 0
                INNER JOIN [ServiceDefinitions] sourceDefinition
                    ON sourceDefinition.Id = sourceField.ServiceDefinitionId
                   AND sourceDefinition.HotelId = @TemplateHotelId
                   AND sourceDefinition.IsDeleted = 0
                INNER JOIN [ServiceCategories] sourceCategory
                    ON sourceCategory.Id = sourceDefinition.ServiceCategoryId
                   AND sourceCategory.IsDeleted = 0
                INNER JOIN [ServiceCategories] targetCategory
                    ON targetCategory.HotelId <> @TemplateHotelId
                   AND targetCategory.IsDeleted = 0
                   AND targetCategory.Name = sourceCategory.Name
                   AND targetCategory.DisplayOrder = sourceCategory.DisplayOrder
                INNER JOIN [ServiceDefinitions] targetDefinition
                    ON targetDefinition.HotelId = targetCategory.HotelId
                   AND targetDefinition.IsDeleted = 0
                   AND targetDefinition.ServiceCategoryId = targetCategory.Id
                   AND targetDefinition.ServiceType = sourceDefinition.ServiceType
                   AND targetDefinition.Name = sourceDefinition.Name
                INNER JOIN [ServiceDefinitionFields] targetField
                    ON targetField.ServiceDefinitionId = targetDefinition.Id
                   AND targetField.IsDeleted = 0
                   AND targetField.FieldKey = sourceField.FieldKey
                   AND targetField.DisplayOrder = sourceField.DisplayOrder
                WHERE sourceOption.IsDeleted = 0
                  AND NOT EXISTS (
                      SELECT 1
                      FROM [ServiceDefinitionFieldOptions] existingOption
                      WHERE existingOption.ServiceDefinitionFieldId = targetField.Id
                        AND existingOption.IsDeleted = 0
                        AND existingOption.Value = sourceOption.Value
                  );

                WITH TranslationMap AS (
                    SELECT
                        N'ServiceCategory' AS TableName,
                        sourceCategory.Id AS TemplateId,
                        targetCategory.Id AS NewId
                    FROM [ServiceCategories] sourceCategory
                    INNER JOIN [ServiceCategories] targetCategory
                        ON targetCategory.HotelId <> @TemplateHotelId
                       AND targetCategory.IsDeleted = 0
                       AND targetCategory.Name = sourceCategory.Name
                       AND targetCategory.DisplayOrder = sourceCategory.DisplayOrder
                    WHERE sourceCategory.HotelId = @TemplateHotelId
                      AND sourceCategory.IsDeleted = 0
                    UNION ALL
                    SELECT
                        N'ServiceDefinition',
                        sourceDefinition.Id,
                        targetDefinition.Id
                    FROM [ServiceDefinitions] sourceDefinition
                    INNER JOIN [ServiceCategories] sourceCategory
                        ON sourceCategory.Id = sourceDefinition.ServiceCategoryId
                       AND sourceCategory.IsDeleted = 0
                    INNER JOIN [ServiceCategories] targetCategory
                        ON targetCategory.HotelId <> @TemplateHotelId
                       AND targetCategory.IsDeleted = 0
                       AND targetCategory.Name = sourceCategory.Name
                       AND targetCategory.DisplayOrder = sourceCategory.DisplayOrder
                    INNER JOIN [ServiceDefinitions] targetDefinition
                        ON targetDefinition.HotelId = targetCategory.HotelId
                       AND targetDefinition.IsDeleted = 0
                       AND targetDefinition.ServiceCategoryId = targetCategory.Id
                       AND targetDefinition.ServiceType = sourceDefinition.ServiceType
                       AND targetDefinition.Name = sourceDefinition.Name
                    WHERE sourceDefinition.HotelId = @TemplateHotelId
                      AND sourceDefinition.IsDeleted = 0
                    UNION ALL
                    SELECT
                        N'ServiceDefinitionField',
                        sourceField.Id,
                        targetField.Id
                    FROM [ServiceDefinitionFields] sourceField
                    INNER JOIN [ServiceDefinitions] sourceDefinition
                        ON sourceDefinition.Id = sourceField.ServiceDefinitionId
                       AND sourceDefinition.HotelId = @TemplateHotelId
                       AND sourceDefinition.IsDeleted = 0
                    INNER JOIN [ServiceCategories] sourceCategory
                        ON sourceCategory.Id = sourceDefinition.ServiceCategoryId
                       AND sourceCategory.IsDeleted = 0
                    INNER JOIN [ServiceCategories] targetCategory
                        ON targetCategory.HotelId <> @TemplateHotelId
                       AND targetCategory.IsDeleted = 0
                       AND targetCategory.Name = sourceCategory.Name
                       AND targetCategory.DisplayOrder = sourceCategory.DisplayOrder
                    INNER JOIN [ServiceDefinitions] targetDefinition
                        ON targetDefinition.HotelId = targetCategory.HotelId
                       AND targetDefinition.IsDeleted = 0
                       AND targetDefinition.ServiceCategoryId = targetCategory.Id
                       AND targetDefinition.ServiceType = sourceDefinition.ServiceType
                       AND targetDefinition.Name = sourceDefinition.Name
                    INNER JOIN [ServiceDefinitionFields] targetField
                        ON targetField.ServiceDefinitionId = targetDefinition.Id
                       AND targetField.IsDeleted = 0
                       AND targetField.FieldKey = sourceField.FieldKey
                       AND targetField.DisplayOrder = sourceField.DisplayOrder
                    WHERE sourceField.IsDeleted = 0
                    UNION ALL
                    SELECT
                        N'ServiceDefinitionFieldOption',
                        sourceOption.Id,
                        targetOption.Id
                    FROM [ServiceDefinitionFieldOptions] sourceOption
                    INNER JOIN [ServiceDefinitionFields] sourceField
                        ON sourceField.Id = sourceOption.ServiceDefinitionFieldId
                       AND sourceField.IsDeleted = 0
                    INNER JOIN [ServiceDefinitions] sourceDefinition
                        ON sourceDefinition.Id = sourceField.ServiceDefinitionId
                       AND sourceDefinition.HotelId = @TemplateHotelId
                       AND sourceDefinition.IsDeleted = 0
                    INNER JOIN [ServiceCategories] sourceCategory
                        ON sourceCategory.Id = sourceDefinition.ServiceCategoryId
                       AND sourceCategory.IsDeleted = 0
                    INNER JOIN [ServiceCategories] targetCategory
                        ON targetCategory.HotelId <> @TemplateHotelId
                       AND targetCategory.IsDeleted = 0
                       AND targetCategory.Name = sourceCategory.Name
                       AND targetCategory.DisplayOrder = sourceCategory.DisplayOrder
                    INNER JOIN [ServiceDefinitions] targetDefinition
                        ON targetDefinition.HotelId = targetCategory.HotelId
                       AND targetDefinition.IsDeleted = 0
                       AND targetDefinition.ServiceCategoryId = targetCategory.Id
                       AND targetDefinition.ServiceType = sourceDefinition.ServiceType
                       AND targetDefinition.Name = sourceDefinition.Name
                    INNER JOIN [ServiceDefinitionFields] targetField
                        ON targetField.ServiceDefinitionId = targetDefinition.Id
                       AND targetField.IsDeleted = 0
                       AND targetField.FieldKey = sourceField.FieldKey
                       AND targetField.DisplayOrder = sourceField.DisplayOrder
                    INNER JOIN [ServiceDefinitionFieldOptions] targetOption
                        ON targetOption.ServiceDefinitionFieldId = targetField.Id
                       AND targetOption.IsDeleted = 0
                       AND targetOption.Value = sourceOption.Value
                    WHERE sourceOption.IsDeleted = 0
                )
                INSERT INTO [Translations] (
                    CreatedDate, ModifyDate, IsDeleted, IsActive,
                    TableName, RecordId, FieldName, TranslationValue, LanguageCode
                )
                SELECT
                    SYSUTCDATETIME(), SYSUTCDATETIME(), 0, 1,
                    translation.TableName, translationMap.NewId, translation.FieldName, translation.TranslationValue, translation.LanguageCode
                FROM [Translations] translation
                INNER JOIN TranslationMap translationMap
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
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Data cleanup only. Intentionally left as no-op to avoid deleting hotel-managed catalog changes.
        }
    }
}
