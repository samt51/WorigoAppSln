# WorigoApp Veritabanı Şema Haritası

Bu doküman WorigoApp projesindeki entity'leri ve aralarındaki ilişkileri (Foreign Key) gösteren veritabanı şema haritasıdır.

## Veritabanı İlişkileri (Mermaid ER Diyagramı)

Aşağıdaki diyagramda tablolar ve aralarındaki ilişkiler gösterilmektedir. Diyagramı daha rahat incelemek için Mermaid desteği olan bir araç veya tarayıcı kullanabilirsiniz.

```mermaid
erDiagram
    Allergen {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
        string Description
    }
    Announcement {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Title
        string Description
        string ImageUrl
        int HotelId FK
        AnnouncementTypeEnum Type
        DateTime StartAt
        DateTime EndAt
        string Location
        bool IsPinned
        bool IsVisibleToGuest
        string AudienceType
        int DepartmentId FK
        int CreatedByEmployeeId FK
        InternalAnnouncementAudienceEnum InternalAudience
    }
    AttendanceRecord {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        int EmployeeId FK
        int DepartmentId FK
        int ShiftId FK
        DateTime WorkDate
        TimeSpan PlannedStartTime
        TimeSpan PlannedEndTime
        DateTime CheckInAt
        DateTime CheckOutAt
        AttendanceStatusEnum Status
        int LateMinutes
        int OvertimeMinutes
        string Note
    }
    Charge {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int GuestStayId FK
        int OrderId FK
        int ServiceRequestId FK
        string Description
        decimal Amount
        string CurrencyCode
        bool IsPostedToRoom
        DateTime PostedToRoomAt
        ChargeStatusEnum Status
    }
    Company {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
    }
    ContentsOfFood {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
    }
    Conversation {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        int GuestStayId FK
        int CustomerId FK
        int ServiceRequestId FK
        string Subject
        ConversationStatusEnum Status
        ConversationTypeEnum ConversationType
        string LanguageCode
        DateTime StartedAt
        DateTime ClosedAt
    }
    ConversationFlowSession {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int ConversationId FK
        int ServiceCategoryId FK
        int ServiceDefinitionId FK
        string FlowType
        string CurrentStep
        string StateJson
        bool IsCompleted
        DateTime StartedAt
        DateTime CompletedAt
    }
    ConversationMessage {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int ConversationId FK
        int SenderUserId FK
        int SenderCustomerId FK
        MessageSenderTypeEnum SenderType
        string OriginalLanguageCode
        string OriginalText
        string TranslatedText
        string TranslatedLanguageCode
        DateTime SentAt
        DateTime ReadAt
        ConversationMessageTypeEnum MessageType
        string PayloadJson
        string NormalizedText
        string TranslationProvider
        string TranslationModel
        string TranslationStatus
    }
    Currency {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Code
        string Name
        string Symbol
        string Country
        string CultureCode
        int DecimalDigits
        bool IsBaseCurrency
        bool IsSupported
        int SortOrder
    }
    Customer {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
        string SurName
        bool Gender
        string Email
        string PhoneNumber
        string Nationality
        string PreferredLanguageCode
        DateTime BirthDate
        bool IsPrimaryGuest
        int GuestStayId FK
    }
    Department {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
        string ImageUrl
        string Description
        int ManagerEmployeeId FK
        int DisplayOrder
        bool IsGuestFacing
        int HotelId FK
    }
    DietaryRestriction {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
        string Description
    }
    Employee {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
        string Surname
        string ImageUrl
        int EmployeeTypeId FK
        int HotelId FK
        DateTime DateOfBirth
        string PhoneNumber
        bool Gender
        DateTime StartDateOfWork
        DateTime ExitDateOfWork
        DateTime LastOnlineTime
        int FloorNo
        bool OnlineOrOfflineNow
        string EmergencyContactName
        string EmergencyContactPhone
        string NationalId FK
        string Address
        string ProfileLanguage
        int UserId FK
        string EmployeeCode
        bool Status
        string HireType
        int ShiftId FK
        bool IsAvailableForTask
        decimal AverageRating
        DateTime LastAssignedAt
        string LanguageCodes
    }
    EmployeeDeviceToken {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int UserId FK
        int EmployeeId FK
        string Token
        string Platform
        string DeviceId FK
        DateTime LastSeenAt
    }
    EmployeeDocument {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        int EmployeeId FK
        DocumentTypeEnum DocumentType
        string Title
        string FileUrl
        string DocumentNumber
        DateTime IssuedAt
        DateTime ExpireAt
        bool IsMandatory
        int VerifiedByEmployeeId FK
        DateTime VerifiedAt
        string Note
    }
    EmployeeTask {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        int AssignedEmployeeId FK
        int AssignedByEmployeeId FK
        int DepartmentId FK
        int RelatedServiceRequestId FK
        string Title
        string Description
        EmployeeTaskPriorityEnum Priority
        EmployeeTaskStatusEnum Status
        DateTime DueAt
        DateTime StartedAt
        DateTime CompletedAt
        string CompletionNote
    }
    EmployeeType {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
        int DepartmentId FK
    }
    Food {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
        int PriceStatusId FK
        decimal Price
        string Description
        int FoodMenuCategoryId FK
        decimal DiscountPrice
        bool IsOnPromotion
        bool IsAvailable
        TimeOnly PREPARATIONTIME
    }
    FoodAllergens {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int FoodId FK
        int AllergenId FK
    }
    FoodContentsOfFood {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int FoodId FK
        int ContentsOfFoodId FK
        bool IsActive
    }
    FoodDietaryRestrictions {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int FoodId FK
        int DietaryRestrictionId FK
    }
    FoodMenuCategory {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
        int HotelId FK
    }
    FoodType {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        RoomFoodTypeEnum RoomFoodTypeEnum
    }
    GuestSession {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int GuestStayId FK
        int CustomerId FK
        string SessionToken
        string QrCodeToken
        DateTime ExpiresAt
        DateTime LastAccessAt
        string DeviceToken
        string LanguageCode
        bool IsActiveSession
    }
    GuestStay {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        int RoomId FK
        string ReservationNo
        int PrimaryCustomerId FK
        DateTime CheckInDate
        DateTime CheckOutDate
        DateTime ActualCheckInAt
        DateTime ActualCheckOutAt
        string VerificationCode
        string Channel
        string GuestLanguageCode
        string DeviceToken
        bool IsMobileAccessEnabled
        string Status
        AccommodationConceptTypeEnum AccommodationConceptType
        string CurrencyCode
        decimal TotalPrice
        bool IsVip
        bool HasAllergy
        bool DoNotDisturb
        bool IsLateCheckOut
    }
    Hotel {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
        string Location
        string Adress
        string Code
        string PhoneNumber
        string Email
        int NumberOfStar
        string TimeZone
        string DefaultLanguageCode
        string AddressLine1
        string AddressLine2
        string City
        string Country
        string LogoUrl
        string Latitude
        string Longitude
        bool IsDemoHotel
        int Companyid
    }
    HotelServicePolicy {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        ServicesEnum ServiceType
        int ServiceItemId FK
        int ServiceDefinitionId FK
        AccommodationConceptTypeEnum AccommodationConceptType
        bool IsVisible
        bool IsIncludedInPackage
        bool IsChargeable
        bool AllowRoomCharge
        bool AllowOnlinePayment
        bool AllowOnSitePayment
        decimal PriceOverride
        string CurrencyCode
        string Description
    }
    Image {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string ImageUrl
        int ImageCategoryId FK
        int OrderItemId FK
        int FoodId FK
    }
    ImageCategory {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
        int HotelId FK
    }
    LeaveRequest {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        int EmployeeId FK
        int DepartmentId FK
        int ManagerEmployeeId FK
        int HrEmployeeId FK
        LeaveRequestTypeEnum LeaveType
        string Title
        string Reason
        DateTime StartDate
        DateTime EndDate
        decimal TotalDayCount
        LeaveRequestStatusEnum Status
        DateTime RequestedAt
        DateTime ManagerActionAt
        DateTime HrActionAt
        string ManagerNote
        string HrNote
    }
    LogEntry {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Message
        string MessageTemplate
        string Level
        DateTime TimeStamp
        string Exception
        string Properties
        string LogEvent
    }
    NutritionalInfo {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        decimal Calories
        decimal Protein
        decimal Fat
        decimal Carbohydrates
        decimal Sugar
        decimal Fiber
        int FoodId FK
    }
    Order {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string OrderNumber
        decimal TotalPrice
        decimal DiscountAmount
        decimal TaxAmount
        decimal ServiceChargeAmount
        decimal NetAmount
        decimal PaidAmount
        string CurrencyCode
        int PriceStatusId FK
        OrderPaymentOptionEnum PaymentOption
        OrderPaymentStatusEnum PaymentStatus
        bool IsPostedToRoom
        DateTime PostedToRoomAt
        int ServiceRequestId FK
        int GuestStayId FK
    }
    OrderItem {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        ServicesEnum ServicesEnumId FK
        int ServiceItemId FK
        int Quantity
        decimal Price
        decimal UnitPrice
        decimal LineTotal
        decimal DiscountAmount
        decimal TaxAmount
        decimal ServiceChargeAmount
        string CurrencyCode
        bool IsIncludedInPackage
        int AppliedHotelServicePolicyId FK
        OrderPaymentOptionEnum PaymentOption
        int PriceStatusId FK
        DateTime AppointmentDate
        DateTime AppointmentLastDate
        int OrderId FK
        StatusTypeEnum StatusTypeEnum
        string Text
    }
    PaymentTransaction {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int ChargeId FK
        PaymentProviderEnum PaymentProvider
        string ExternalTransactionId FK
        string PaymentMethod
        OrderPaymentStatusEnum PaymentStatus
        decimal Amount
        string CurrencyCode
        string RedirectUrl
        DateTime PaidAt
        string FailureReason
    }
    PerformanceReview {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        int EmployeeId FK
        int ReviewerEmployeeId FK
        int DepartmentId FK
        DateTime ReviewDate
        DateTime PeriodStartDate
        DateTime PeriodEndDate
        decimal Score
        string Strengths
        string ImprovementAreas
        string ManagerNote
        PerformanceReviewStatusEnum Status
    }
    Roles {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
    }
    Room {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
        string RoomNumber
        int RoomTypeId FK
        int RoomFoodTypeId FK
        int HotelId FK
        int FloorNo
        int Capacity
        string Description
        bool IsFull
        string CurrentStatus
        double TargetTemperature
        int LightsIntensity
        bool AreCurtainsOpen
        decimal Price
        int PriceStatusId FK
        string InternalPhoneNumber
    }
    RoomType {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        string Name
        string Description
        int Capacity
        decimal BasePrice
        int DisplayOrder
    }
    ServiceCategory {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        string Name
        string Description
        string IconUrl
        string IconKey
        int DisplayOrder
        bool ShowOnHome
        bool IsPopular
        int HomeDisplayOrder
        ServicesEnum LegacyServiceType
    }
    ServiceDefinition {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        int ServiceCategoryId FK
        int DepartmentId FK
        ServicesEnum ServiceType
        string Name
        string Description
        string ImageUrl
        string OpeningMessage
        bool IsVisibleToGuest
        bool IsChargeable
        bool SupportsFreeText
        bool RequiresAppointment
        ServiceFlowUiTypeEnum FlowUiType
        int EstimatedDurationMinutes
        int DisplayOrder
        decimal Price
        string CurrencyCode
    }
    ServiceDefinitionField {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int ServiceDefinitionId FK
        string FieldKey
        string Label
        string Placeholder
        ServiceDefinitionFieldTypeEnum FieldType
        bool IsRequired
        int DisplayOrder
        string OptionsJson
        string ValidationRegex
        string DefaultValue
    }
    ServiceDefinitionFieldOption {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int ServiceDefinitionFieldId FK
        string Value
        string Label
        int DisplayOrder
    }
    ServiceRequest {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        int GuestStayId FK
        int RoomId FK
        int CustomerId FK
        ServicesEnum ServiceType
        int ServiceCatalogItemId FK
        int ServiceDefinitionId FK
        string Title
        string Description
        ServiceRequestStatusEnum Status
        ServiceRequestPriorityEnum Priority
        ServiceRequestSourceEnum RequestSource
        int DepartmentId FK
        int AssignedEmployeeId FK
        string LanguageCode
        DateTime RequestedAt
        DateTime AssignedAt
        DateTime StartedAt
        DateTime CompletedAt
        DateTime ClosedAt
        DateTime DueAt
        string ResolutionNote
        bool IsChatStarted
        int ConversationId FK
    }
    ServiceRequestFieldValue {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int ServiceRequestId FK
        int ServiceDefinitionFieldId FK
        string FieldKey
        string Value
    }
    ServiceRequestHistory {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int ServiceRequestId FK
        ServiceRequestStatusEnum OldStatus
        ServiceRequestStatusEnum NewStatus
        int ChangedByUserId FK
        DateTime ChangedAt
        string Note
    }
    ServiceRequestItem {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int ServiceRequestId FK
        int ServiceDefinitionId FK
        string ItemName
        int Quantity
        string Note
    }
    ServiceRequestRating {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int ServiceRequestId FK
        int CustomerId FK
        decimal SpeedScore
        decimal QualityScore
        decimal StaffScore
        string Comment
        DateTime RatedAt
        int OrderId FK
        int OrderItemId FK
        int FoodId FK
    }
    ServiceRoleAssignments {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        ServicesEnum ServicesEnumId FK
        int HotelId FK
        int DepartmentId FK
        int ServiceId FK
        int EmployeeTypeRoleId FK
        bool IsPrimaryAssignment
        int Priority
        int SlaMinutes
    }
    Shift {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Name
        TimeSpan StartTime
        TimeSpan EndTime
        int HotelId FK
        string Description
        bool IsNightShift
    }
    SpaAppointment {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        int GuestStayId FK
        string ServiceName
        string TherapistName
        DateTime AppointmentDate
        string TimeSlot
        decimal Price
        string CurrencyCode
        string Status
    }
    StockItem {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        int DepartmentId FK
        string Code
        string Name
        string Unit
        decimal CurrentQuantity
        decimal MinimumQuantity
        decimal LastPurchasePrice
        decimal AverageUnitCost
        bool IsCritical
        string Description
    }
    StockMovement {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        int StockItemId FK
        int DepartmentId FK
        int EmployeeId FK
        StockMovementTypeEnum MovementType
        decimal Quantity
        decimal UnitPrice
        decimal TotalAmount
        string Reason
        string ReferenceType
        int ReferenceId FK
        DateTime OccurredAt
    }
    StockRequest {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        int RequestedByEmployeeId FK
        int AssignedManagerEmployeeId FK
        int DepartmentId FK
        int RelatedServiceRequestId FK
        string Title
        string Description
        StockRequestPriorityEnum Priority
        StockRequestStatusEnum Status
        DateTime RequestedAt
        DateTime ApprovedAt
        DateTime FulfilledAt
        string ManagerNote
    }
    StockRequestItem {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int StockRequestId FK
        int StockItemId FK
        decimal RequestedQuantity
        decimal ApprovedQuantity
        decimal FulfilledQuantity
        decimal UnitPrice
        string Note
    }
    SystemParametre {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string ParametreKey
        bool IsDeleted
    }
    SystemParametreValues {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int SystemParametreId FK
        string ParametreValue
        string Description
        int SystemParametreValueId FK
        bool IsDeleted
    }
    Translation {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string TableName
        int RecordId FK
        string FieldName
        string TranslationValue
        string LanguageCode
    }
    UserNotification {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        int HotelId FK
        int UserId FK
        int EmployeeId FK
        int DepartmentId FK
        int ServiceRequestId FK
        string Title
        string Message
        string NotificationType
        bool IsRead
        DateTime ReadAt
    }
    Users {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        string Email
        string Password
        string UserName
        string PreferredLanguageCode
        DateTime LastLoginAt
        int FailedLoginCount
        bool IsLocked
        string RefreshToken
        DateTime RefreshTokenExpireDate
        int RoleId FK
    }
    ValidationMessages {
        int Id PK
        DateTime CreatedDate
        DateTime ModifyDate
        bool IsDeleted
        bool IsActive
        ValidationMessageType ValidationMessageType
        string ValidationMessage
        string LanguageCode
        bool IsDeleted
    }
    Charge ||--o{ PaymentTransaction : "ChargeId"
    Conversation |o--o{ ConversationFlowSession : "ServiceCategoryId"
    Conversation |o--o{ ConversationFlowSession : "ServiceDefinitionId"
    Conversation |o--o{ ConversationMessage : "SenderCustomerId"
    Conversation |o--o{ ConversationMessage : "SenderUserId"
    Conversation ||--o{ ConversationFlowSession : "ConversationId"
    Conversation ||--o{ ConversationMessage : "ConversationId"
    Customer |o--o{ ServiceRequestRating : "CustomerId"
    Department |o--o{ Announcement : "DepartmentId"
    Department |o--o{ ServiceRoleAssignments : "DepartmentId"
    Department ||--o{ EmployeeType : "DepartmentId"
    Employee |o--o{ Department : "ManagerEmployeeId"
    EmployeeType |o--o{ Employee : "EmployeeTypeId"
    Food |o--o{ Image : "FoodId"
    Food |o--o{ ServiceRequestRating : "FoodId"
    Food ||--o{ FoodAllergens : "AllergenId"
    Food ||--o{ FoodAllergens : "FoodId"
    Food ||--o{ FoodContentsOfFood : "ContentsOfFoodId"
    Food ||--o{ FoodContentsOfFood : "FoodId"
    Food ||--o{ FoodDietaryRestrictions : "DietaryRestrictionId"
    Food ||--o{ FoodDietaryRestrictions : "FoodId"
    Food ||--o{ NutritionalInfo : "FoodId"
    FoodMenuCategory ||--o{ Food : "FoodMenuCategoryId"
    GuestStay |o--o{ Charge : "OrderId"
    GuestStay |o--o{ Charge : "ServiceRequestId"
    GuestStay |o--o{ GuestSession : "CustomerId"
    GuestStay ||--o{ Charge : "GuestStayId"
    GuestStay ||--o{ Customer : "GuestStayId"
    GuestStay ||--o{ GuestSession : "GuestStayId"
    GuestStay ||--o{ Order : "GuestStayId"
    GuestStay ||--o{ SpaAppointment : "GuestStayId"
    Hotel |o--o{ AttendanceRecord : "DepartmentId"
    Hotel |o--o{ AttendanceRecord : "ShiftId"
    Hotel |o--o{ Conversation : "CustomerId"
    Hotel |o--o{ Conversation : "GuestStayId"
    Hotel |o--o{ Employee : "HotelId"
    Hotel |o--o{ EmployeeDocument : "VerifiedByEmployeeId"
    Hotel |o--o{ EmployeeTask : "DepartmentId"
    Hotel |o--o{ EmployeeTask : "RelatedServiceRequestId"
    Hotel |o--o{ HotelServicePolicy : "ServiceDefinitionId"
    Hotel |o--o{ LeaveRequest : "DepartmentId"
    Hotel |o--o{ LeaveRequest : "HrEmployeeId"
    Hotel |o--o{ LeaveRequest : "ManagerEmployeeId"
    Hotel |o--o{ PerformanceReview : "DepartmentId"
    Hotel |o--o{ ServiceDefinition : "DepartmentId"
    Hotel |o--o{ ServiceRequest : "AssignedEmployeeId"
    Hotel |o--o{ ServiceRequest : "ConversationId"
    Hotel |o--o{ ServiceRequest : "CustomerId"
    Hotel |o--o{ ServiceRequest : "DepartmentId"
    Hotel |o--o{ ServiceRequest : "ServiceDefinitionId"
    Hotel |o--o{ ServiceRoleAssignments : "HotelId"
    Hotel |o--o{ Shift : "HotelId"
    Hotel |o--o{ StockItem : "DepartmentId"
    Hotel |o--o{ StockMovement : "DepartmentId"
    Hotel |o--o{ StockMovement : "EmployeeId"
    Hotel |o--o{ StockRequest : "AssignedManagerEmployeeId"
    Hotel |o--o{ StockRequest : "DepartmentId"
    Hotel |o--o{ StockRequest : "RelatedServiceRequestId"
    Hotel |o--o{ UserNotification : "DepartmentId"
    Hotel |o--o{ UserNotification : "EmployeeId"
    Hotel |o--o{ UserNotification : "ServiceRequestId"
    Hotel |o--o{ UserNotification : "UserId"
    Hotel ||--o{ Announcement : "HotelId"
    Hotel ||--o{ AttendanceRecord : "EmployeeId"
    Hotel ||--o{ AttendanceRecord : "HotelId"
    Hotel ||--o{ Conversation : "HotelId"
    Hotel ||--o{ Department : "HotelId"
    Hotel ||--o{ EmployeeDocument : "EmployeeId"
    Hotel ||--o{ EmployeeDocument : "HotelId"
    Hotel ||--o{ EmployeeTask : "AssignedByEmployeeId"
    Hotel ||--o{ EmployeeTask : "AssignedEmployeeId"
    Hotel ||--o{ EmployeeTask : "HotelId"
    Hotel ||--o{ FoodMenuCategory : "HotelId"
    Hotel ||--o{ GuestStay : "HotelId"
    Hotel ||--o{ HotelServicePolicy : "HotelId"
    Hotel ||--o{ ImageCategory : "HotelId"
    Hotel ||--o{ LeaveRequest : "EmployeeId"
    Hotel ||--o{ LeaveRequest : "HotelId"
    Hotel ||--o{ PerformanceReview : "EmployeeId"
    Hotel ||--o{ PerformanceReview : "HotelId"
    Hotel ||--o{ PerformanceReview : "ReviewerEmployeeId"
    Hotel ||--o{ Room : "HotelId"
    Hotel ||--o{ RoomType : "HotelId"
    Hotel ||--o{ ServiceCategory : "HotelId"
    Hotel ||--o{ ServiceDefinition : "HotelId"
    Hotel ||--o{ ServiceDefinition : "ServiceCategoryId"
    Hotel ||--o{ ServiceRequest : "GuestStayId"
    Hotel ||--o{ ServiceRequest : "HotelId"
    Hotel ||--o{ SpaAppointment : "HotelId"
    Hotel ||--o{ StockItem : "HotelId"
    Hotel ||--o{ StockMovement : "HotelId"
    Hotel ||--o{ StockMovement : "StockItemId"
    Hotel ||--o{ StockRequest : "HotelId"
    Hotel ||--o{ StockRequest : "RequestedByEmployeeId"
    Hotel ||--o{ UserNotification : "HotelId"
    ImageCategory ||--o{ Image : "ImageCategoryId"
    Order |o--o{ ServiceRequestRating : "OrderId"
    Order ||--o{ OrderItem : "OrderId"
    OrderItem |o--o{ Image : "OrderItemId"
    OrderItem |o--o{ ServiceRequestRating : "OrderItemId"
    Roles ||--o{ Users : "RoleId"
    Room |o--o{ ServiceRequest : "RoomId"
    Room ||--o{ GuestStay : "RoomId"
    RoomType ||--o{ Room : "RoomTypeId"
    ServiceDefinition ||--o{ ServiceDefinitionField : "ServiceDefinitionId"
    ServiceDefinitionField ||--o{ ServiceDefinitionFieldOption : "ServiceDefinitionFieldId"
    ServiceRequest |o--o{ Conversation : "ServiceRequestId"
    ServiceRequest |o--o{ Order : "ServiceRequestId"
    ServiceRequest |o--o{ ServiceRequestItem : "ServiceDefinitionId"
    ServiceRequest ||--o{ ServiceRequestFieldValue : "ServiceDefinitionFieldId"
    ServiceRequest ||--o{ ServiceRequestFieldValue : "ServiceRequestId"
    ServiceRequest ||--o{ ServiceRequestHistory : "ServiceRequestId"
    ServiceRequest ||--o{ ServiceRequestItem : "ServiceRequestId"
    ServiceRequest ||--o{ ServiceRequestRating : "ServiceRequestId"
    StockRequest ||--o{ StockRequestItem : "StockItemId"
    StockRequest ||--o{ StockRequestItem : "StockRequestId"
    SystemParametre ||--o{ SystemParametreValues : "SystemParametreId"
    SystemParametreValues ||--o{ SystemParametreValues : "SystemParametreValueId"
    Users |o--o{ Employee : "ShiftId"
    Users |o--o{ Employee : "UserId"
    Users |o--o{ ServiceRequestHistory : "ChangedByUserId"
    Users ||--o{ EmployeeDeviceToken : "EmployeeId"
    Users ||--o{ EmployeeDeviceToken : "UserId"
```

## Tablo ve Kolon Detayları

Aşağıdaki tablolarda her bir entity'nin sahip olduğu tüm kolonlar, veri tipleri ve Foreign Key bilgileri listelenmiştir.

### Allergen Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |
| `Description` | `string` | Evet |  |


### Announcement Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Title` | `string` | Evet |  |
| `Description` | `string` | Evet |  |
| `ImageUrl` | `string?` | Evet |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `Type` | `AnnouncementTypeEnum` | Hayır |  |
| `StartAt` | `DateTime` | Hayır |  |
| `EndAt` | `DateTime?` | Evet |  |
| `Location` | `string?` | Evet |  |
| `IsPinned` | `bool` | Hayır |  |
| `IsVisibleToGuest` | `bool` | Hayır |  |
| `AudienceType` | `string?` | Evet |  |
| `DepartmentId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Department` |
| `CreatedByEmployeeId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `InternalAudience` | `InternalAnnouncementAudienceEnum?` | Evet |  |


### AttendanceRecord Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `EmployeeId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `DepartmentId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `ShiftId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `WorkDate` | `DateTime` | Hayır |  |
| `PlannedStartTime` | `TimeSpan?` | Evet |  |
| `PlannedEndTime` | `TimeSpan?` | Evet |  |
| `CheckInAt` | `DateTime?` | Evet |  |
| `CheckOutAt` | `DateTime?` | Evet |  |
| `Status` | `AttendanceStatusEnum` | Hayır |  |
| `LateMinutes` | `int` | Hayır |  |
| `OvertimeMinutes` | `int` | Hayır |  |
| `Note` | `string?` | Evet |  |


### Charge Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `GuestStayId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `GuestStay` |
| `OrderId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `GuestStay` |
| `ServiceRequestId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `GuestStay` |
| `Description` | `string` | Evet |  |
| `Amount` | `decimal` | Hayır |  |
| `CurrencyCode` | `string` | Evet |  |
| `IsPostedToRoom` | `bool` | Hayır |  |
| `PostedToRoomAt` | `DateTime?` | Evet |  |
| `Status` | `ChargeStatusEnum` | Hayır |  |


### Company Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |


### ContentsOfFood Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |


### Conversation Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `GuestStayId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `CustomerId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `ServiceRequestId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `ServiceRequest` |
| `Subject` | `string?` | Evet |  |
| `Status` | `ConversationStatusEnum` | Hayır |  |
| `ConversationType` | `ConversationTypeEnum` | Hayır |  |
| `LanguageCode` | `string` | Evet |  |
| `StartedAt` | `DateTime` | Hayır |  |
| `ClosedAt` | `DateTime?` | Evet |  |


### ConversationFlowSession Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `ConversationId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Conversation` |
| `ServiceCategoryId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Conversation` |
| `ServiceDefinitionId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Conversation` |
| `FlowType` | `string` | Evet |  |
| `CurrentStep` | `string` | Evet |  |
| `StateJson` | `string` | Evet |  |
| `IsCompleted` | `bool` | Hayır |  |
| `StartedAt` | `DateTime` | Hayır |  |
| `CompletedAt` | `DateTime?` | Evet |  |


### ConversationMessage Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `ConversationId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Conversation` |
| `SenderUserId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Conversation` |
| `SenderCustomerId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Conversation` |
| `SenderType` | `MessageSenderTypeEnum` | Hayır |  |
| `OriginalLanguageCode` | `string` | Evet |  |
| `OriginalText` | `string` | Evet |  |
| `TranslatedText` | `string?` | Evet |  |
| `TranslatedLanguageCode` | `string?` | Evet |  |
| `SentAt` | `DateTime` | Hayır |  |
| `ReadAt` | `DateTime?` | Evet |  |
| `MessageType` | `ConversationMessageTypeEnum` | Hayır |  |
| `PayloadJson` | `string?` | Evet |  |
| `NormalizedText` | `string?` | Evet |  |
| `TranslationProvider` | `string?` | Evet |  |
| `TranslationModel` | `string?` | Evet |  |
| `TranslationStatus` | `string` | Evet |  |


### Currency Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Code` | `string` | Evet |  |
| `Name` | `string` | Evet |  |
| `Symbol` | `string` | Evet |  |
| `Country` | `string` | Evet |  |
| `CultureCode` | `string` | Evet |  |
| `DecimalDigits` | `int` | Hayır |  |
| `IsBaseCurrency` | `bool` | Hayır |  |
| `IsSupported` | `bool` | Hayır |  |
| `SortOrder` | `int` | Hayır |  |


### Customer Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |
| `SurName` | `string` | Evet |  |
| `Gender` | `bool` | Hayır |  |
| `Email` | `string?` | Evet |  |
| `PhoneNumber` | `string?` | Evet |  |
| `Nationality` | `string?` | Evet |  |
| `PreferredLanguageCode` | `string` | Evet |  |
| `BirthDate` | `DateTime?` | Evet |  |
| `IsPrimaryGuest` | `bool` | Hayır |  |
| `GuestStayId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `GuestStay` |


### Department Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |
| `ImageUrl` | `string?` | Evet |  |
| `Description` | `string?` | Evet |  |
| `ManagerEmployeeId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Employee` |
| `DisplayOrder` | `int` | Hayır |  |
| `IsGuestFacing` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |


### DietaryRestriction Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |
| `Description` | `string` | Evet |  |


### Employee Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |
| `Surname` | `string` | Evet |  |
| `ImageUrl` | `string?` | Evet |  |
| `EmployeeTypeId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `EmployeeType` |
| `HotelId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `DateOfBirth` | `DateTime` | Hayır |  |
| `PhoneNumber` | `string` | Evet |  |
| `Gender` | `bool` | Hayır |  |
| `StartDateOfWork` | `DateTime` | Hayır |  |
| `ExitDateOfWork` | `DateTime?` | Evet |  |
| `LastOnlineTime` | `DateTime?` | Evet |  |
| `FloorNo` | `int?` | Evet |  |
| `OnlineOrOfflineNow` | `bool` | Hayır |  |
| `EmergencyContactName` | `string?` | Evet |  |
| `EmergencyContactPhone` | `string?` | Evet |  |
| `NationalId` | `string?` | Evet | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `Address` | `string?` | Evet |  |
| `ProfileLanguage` | `string?` | Evet |  |
| `UserId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Users` |
| `EmployeeCode` | `string?` | Evet |  |
| `Status` | `bool` | Hayır |  |
| `HireType` | `string?` | Evet |  |
| `ShiftId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Users` |
| `IsAvailableForTask` | `bool` | Hayır |  |
| `AverageRating` | `decimal` | Hayır |  |
| `LastAssignedAt` | `DateTime?` | Evet |  |
| `LanguageCodes` | `string?` | Evet |  |


### EmployeeDeviceToken Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `UserId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Users` |
| `EmployeeId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Users` |
| `Token` | `string` | Evet |  |
| `Platform` | `string` | Evet |  |
| `DeviceId` | `string?` | Evet | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `LastSeenAt` | `DateTime` | Hayır |  |


### EmployeeDocument Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `EmployeeId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `DocumentType` | `DocumentTypeEnum` | Hayır |  |
| `Title` | `string` | Evet |  |
| `FileUrl` | `string` | Evet |  |
| `DocumentNumber` | `string?` | Evet |  |
| `IssuedAt` | `DateTime?` | Evet |  |
| `ExpireAt` | `DateTime?` | Evet |  |
| `IsMandatory` | `bool` | Hayır |  |
| `VerifiedByEmployeeId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `VerifiedAt` | `DateTime?` | Evet |  |
| `Note` | `string?` | Evet |  |


### EmployeeTask Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `AssignedEmployeeId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `AssignedByEmployeeId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `DepartmentId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `RelatedServiceRequestId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `Title` | `string` | Evet |  |
| `Description` | `string?` | Evet |  |
| `Priority` | `EmployeeTaskPriorityEnum` | Hayır |  |
| `Status` | `EmployeeTaskStatusEnum` | Hayır |  |
| `DueAt` | `DateTime?` | Evet |  |
| `StartedAt` | `DateTime?` | Evet |  |
| `CompletedAt` | `DateTime?` | Evet |  |
| `CompletionNote` | `string?` | Evet |  |


### EmployeeType Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |
| `DepartmentId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Department` |


### Food Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |
| `PriceStatusId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `Price` | `decimal` | Hayır |  |
| `Description` | `string` | Evet |  |
| `FoodMenuCategoryId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `FoodMenuCategory` |
| `DiscountPrice` | `decimal?` | Evet |  |
| `IsOnPromotion` | `bool` | Hayır |  |
| `IsAvailable` | `bool` | Hayır |  |
| `PREPARATIONTIME` | `TimeOnly` | Hayır |  |


### FoodAllergens Tablosu

*Base Class:* `IEntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `FoodId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Food` |
| `AllergenId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Food` |


### FoodContentsOfFood Tablosu

*Base Class:* `IEntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `FoodId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Food` |
| `ContentsOfFoodId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Food` |
| `IsActive` | `bool` | Hayır |  |


### FoodDietaryRestrictions Tablosu

*Base Class:* `IEntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `FoodId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Food` |
| `DietaryRestrictionId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Food` |


### FoodMenuCategory Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |


### FoodType Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `RoomFoodTypeEnum` | `RoomFoodTypeEnum` | Hayır |  |


### GuestSession Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `GuestStayId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `GuestStay` |
| `CustomerId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `GuestStay` |
| `SessionToken` | `string` | Evet |  |
| `QrCodeToken` | `string?` | Evet |  |
| `ExpiresAt` | `DateTime` | Hayır |  |
| `LastAccessAt` | `DateTime?` | Evet |  |
| `DeviceToken` | `string?` | Evet |  |
| `LanguageCode` | `string` | Evet |  |
| `IsActiveSession` | `bool` | Hayır |  |


### GuestStay Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `RoomId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Room` |
| `ReservationNo` | `string?` | Evet |  |
| `PrimaryCustomerId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `CheckInDate` | `DateTime` | Hayır |  |
| `CheckOutDate` | `DateTime` | Hayır |  |
| `ActualCheckInAt` | `DateTime?` | Evet |  |
| `ActualCheckOutAt` | `DateTime?` | Evet |  |
| `VerificationCode` | `string` | Evet |  |
| `Channel` | `string?` | Evet |  |
| `GuestLanguageCode` | `string` | Evet |  |
| `DeviceToken` | `string?` | Evet |  |
| `IsMobileAccessEnabled` | `bool` | Hayır |  |
| `Status` | `string` | Evet |  |
| `AccommodationConceptType` | `AccommodationConceptTypeEnum` | Hayır |  |
| `CurrencyCode` | `string` | Evet |  |
| `TotalPrice` | `decimal` | Hayır |  |
| `IsVip` | `bool` | Hayır |  |
| `HasAllergy` | `bool` | Hayır |  |
| `DoNotDisturb` | `bool` | Hayır |  |
| `IsLateCheckOut` | `bool` | Hayır |  |


### Hotel Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |
| `Location` | `string` | Evet |  |
| `Adress` | `string` | Evet |  |
| `Code` | `string` | Evet |  |
| `PhoneNumber` | `string` | Evet |  |
| `Email` | `string` | Evet |  |
| `NumberOfStar` | `int` | Hayır |  |
| `TimeZone` | `string` | Evet |  |
| `DefaultLanguageCode` | `string` | Evet |  |
| `AddressLine1` | `string` | Evet |  |
| `AddressLine2` | `string?` | Evet |  |
| `City` | `string` | Evet |  |
| `Country` | `string` | Evet |  |
| `LogoUrl` | `string?` | Evet |  |
| `Latitude` | `string?` | Evet |  |
| `Longitude` | `string?` | Evet |  |
| `IsDemoHotel` | `bool` | Hayır |  |
| `Companyid` | `int` | Hayır |  |


### HotelServicePolicy Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `ServiceType` | `ServicesEnum` | Hayır |  |
| `ServiceItemId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `ServiceDefinitionId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `AccommodationConceptType` | `AccommodationConceptTypeEnum` | Hayır |  |
| `IsVisible` | `bool` | Hayır |  |
| `IsIncludedInPackage` | `bool` | Hayır |  |
| `IsChargeable` | `bool` | Hayır |  |
| `AllowRoomCharge` | `bool` | Hayır |  |
| `AllowOnlinePayment` | `bool` | Hayır |  |
| `AllowOnSitePayment` | `bool` | Hayır |  |
| `PriceOverride` | `decimal?` | Evet |  |
| `CurrencyCode` | `string` | Evet |  |
| `Description` | `string?` | Evet |  |


### Image Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `ImageUrl` | `string` | Evet |  |
| `ImageCategoryId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `ImageCategory` |
| `OrderItemId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `OrderItem` |
| `FoodId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Food` |


### ImageCategory Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |


### LeaveRequest Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `EmployeeId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `DepartmentId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `ManagerEmployeeId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `HrEmployeeId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `LeaveType` | `LeaveRequestTypeEnum` | Hayır |  |
| `Title` | `string` | Evet |  |
| `Reason` | `string?` | Evet |  |
| `StartDate` | `DateTime` | Hayır |  |
| `EndDate` | `DateTime` | Hayır |  |
| `TotalDayCount` | `decimal` | Hayır |  |
| `Status` | `LeaveRequestStatusEnum` | Hayır |  |
| `RequestedAt` | `DateTime` | Hayır |  |
| `ManagerActionAt` | `DateTime?` | Evet |  |
| `HrActionAt` | `DateTime?` | Evet |  |
| `ManagerNote` | `string?` | Evet |  |
| `HrNote` | `string?` | Evet |  |


### LogEntry Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Message` | `string` | Evet |  |
| `MessageTemplate` | `string` | Evet |  |
| `Level` | `string` | Evet |  |
| `TimeStamp` | `DateTime` | Hayır |  |
| `Exception` | `string?` | Evet |  |
| `Properties` | `string?` | Evet |  |
| `LogEvent` | `string?` | Evet |  |


### NutritionalInfo Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Calories` | `decimal` | Hayır |  |
| `Protein` | `decimal` | Hayır |  |
| `Fat` | `decimal` | Hayır |  |
| `Carbohydrates` | `decimal` | Hayır |  |
| `Sugar` | `decimal` | Hayır |  |
| `Fiber` | `decimal` | Hayır |  |
| `FoodId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Food` |


### Order Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `OrderNumber` | `string` | Evet |  |
| `TotalPrice` | `decimal` | Hayır |  |
| `DiscountAmount` | `decimal` | Hayır |  |
| `TaxAmount` | `decimal` | Hayır |  |
| `ServiceChargeAmount` | `decimal` | Hayır |  |
| `NetAmount` | `decimal` | Hayır |  |
| `PaidAmount` | `decimal` | Hayır |  |
| `CurrencyCode` | `string` | Evet |  |
| `PriceStatusId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `PaymentOption` | `OrderPaymentOptionEnum` | Hayır |  |
| `PaymentStatus` | `OrderPaymentStatusEnum` | Hayır |  |
| `IsPostedToRoom` | `bool` | Hayır |  |
| `PostedToRoomAt` | `DateTime?` | Evet |  |
| `ServiceRequestId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `ServiceRequest` |
| `GuestStayId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `GuestStay` |


### OrderItem Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `ServicesEnumId` | `ServicesEnum` | Hayır | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `ServiceItemId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `Quantity` | `int` | Hayır |  |
| `Price` | `decimal?` | Evet |  |
| `UnitPrice` | `decimal` | Hayır |  |
| `LineTotal` | `decimal` | Hayır |  |
| `DiscountAmount` | `decimal` | Hayır |  |
| `TaxAmount` | `decimal` | Hayır |  |
| `ServiceChargeAmount` | `decimal` | Hayır |  |
| `CurrencyCode` | `string` | Evet |  |
| `IsIncludedInPackage` | `bool` | Hayır |  |
| `AppliedHotelServicePolicyId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `PaymentOption` | `OrderPaymentOptionEnum` | Hayır |  |
| `PriceStatusId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `AppointmentDate` | `DateTime?` | Evet |  |
| `AppointmentLastDate` | `DateTime?` | Evet |  |
| `OrderId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Order` |
| `StatusTypeEnum` | `StatusTypeEnum` | Hayır |  |
| `Text` | `string` | Evet |  |


### PaymentTransaction Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `ChargeId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Charge` |
| `PaymentProvider` | `PaymentProviderEnum` | Hayır |  |
| `ExternalTransactionId` | `string?` | Evet | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `PaymentMethod` | `string` | Evet |  |
| `PaymentStatus` | `OrderPaymentStatusEnum` | Hayır |  |
| `Amount` | `decimal` | Hayır |  |
| `CurrencyCode` | `string` | Evet |  |
| `RedirectUrl` | `string?` | Evet |  |
| `PaidAt` | `DateTime?` | Evet |  |
| `FailureReason` | `string?` | Evet |  |


### PerformanceReview Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `EmployeeId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `ReviewerEmployeeId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `DepartmentId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `ReviewDate` | `DateTime` | Hayır |  |
| `PeriodStartDate` | `DateTime?` | Evet |  |
| `PeriodEndDate` | `DateTime?` | Evet |  |
| `Score` | `decimal` | Hayır |  |
| `Strengths` | `string?` | Evet |  |
| `ImprovementAreas` | `string?` | Evet |  |
| `ManagerNote` | `string?` | Evet |  |
| `Status` | `PerformanceReviewStatusEnum` | Hayır |  |


### Roles Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |


### Room Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |
| `RoomNumber` | `string?` | Evet |  |
| `RoomTypeId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `RoomType` |
| `RoomFoodTypeId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `FloorNo` | `int?` | Evet |  |
| `Capacity` | `int` | Hayır |  |
| `Description` | `string?` | Evet |  |
| `IsFull` | `bool` | Hayır |  |
| `CurrentStatus` | `string` | Evet |  |
| `TargetTemperature` | `double` | Hayır |  |
| `LightsIntensity` | `int` | Hayır |  |
| `AreCurtainsOpen` | `bool` | Hayır |  |
| `Price` | `decimal` | Hayır |  |
| `PriceStatusId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `InternalPhoneNumber` | `string?` | Evet |  |


### RoomType Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `Name` | `string` | Evet |  |
| `Description` | `string?` | Evet |  |
| `Capacity` | `int` | Hayır |  |
| `BasePrice` | `decimal` | Hayır |  |
| `DisplayOrder` | `int` | Hayır |  |


### ServiceCategory Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `Name` | `string` | Evet |  |
| `Description` | `string?` | Evet |  |
| `IconUrl` | `string?` | Evet |  |
| `IconKey` | `string?` | Evet |  |
| `DisplayOrder` | `int` | Hayır |  |
| `ShowOnHome` | `bool` | Hayır |  |
| `IsPopular` | `bool` | Hayır |  |
| `HomeDisplayOrder` | `int?` | Evet |  |
| `LegacyServiceType` | `ServicesEnum?` | Evet |  |


### ServiceDefinition Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `ServiceCategoryId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `DepartmentId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `ServiceType` | `ServicesEnum` | Hayır |  |
| `Name` | `string` | Evet |  |
| `Description` | `string?` | Evet |  |
| `ImageUrl` | `string?` | Evet |  |
| `OpeningMessage` | `string?` | Evet |  |
| `IsVisibleToGuest` | `bool` | Hayır |  |
| `IsChargeable` | `bool` | Hayır |  |
| `SupportsFreeText` | `bool` | Hayır |  |
| `RequiresAppointment` | `bool` | Hayır |  |
| `FlowUiType` | `ServiceFlowUiTypeEnum?` | Evet |  |
| `EstimatedDurationMinutes` | `int?` | Evet |  |
| `DisplayOrder` | `int` | Hayır |  |
| `Price` | `decimal` | Hayır |  |
| `CurrencyCode` | `string` | Evet |  |


### ServiceDefinitionField Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `ServiceDefinitionId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `ServiceDefinition` |
| `FieldKey` | `string` | Evet |  |
| `Label` | `string` | Evet |  |
| `Placeholder` | `string?` | Evet |  |
| `FieldType` | `ServiceDefinitionFieldTypeEnum` | Hayır |  |
| `IsRequired` | `bool` | Hayır |  |
| `DisplayOrder` | `int` | Hayır |  |
| `OptionsJson` | `string?` | Evet |  |
| `ValidationRegex` | `string?` | Evet |  |
| `DefaultValue` | `string?` | Evet |  |


### ServiceDefinitionFieldOption Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `ServiceDefinitionFieldId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `ServiceDefinitionField` |
| `Value` | `string` | Evet |  |
| `Label` | `string` | Evet |  |
| `DisplayOrder` | `int` | Hayır |  |


### ServiceRequest Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `GuestStayId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `RoomId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Room` |
| `CustomerId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `ServiceType` | `ServicesEnum` | Hayır |  |
| `ServiceCatalogItemId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `ServiceDefinitionId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `Title` | `string` | Evet |  |
| `Description` | `string?` | Evet |  |
| `Status` | `ServiceRequestStatusEnum` | Hayır |  |
| `Priority` | `ServiceRequestPriorityEnum` | Hayır |  |
| `RequestSource` | `ServiceRequestSourceEnum` | Hayır |  |
| `DepartmentId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `AssignedEmployeeId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `LanguageCode` | `string` | Evet |  |
| `RequestedAt` | `DateTime` | Hayır |  |
| `AssignedAt` | `DateTime?` | Evet |  |
| `StartedAt` | `DateTime?` | Evet |  |
| `CompletedAt` | `DateTime?` | Evet |  |
| `ClosedAt` | `DateTime?` | Evet |  |
| `DueAt` | `DateTime?` | Evet |  |
| `ResolutionNote` | `string?` | Evet |  |
| `IsChatStarted` | `bool` | Hayır |  |
| `ConversationId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |


### ServiceRequestFieldValue Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `ServiceRequestId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `ServiceRequest` |
| `ServiceDefinitionFieldId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `ServiceRequest` |
| `FieldKey` | `string` | Evet |  |
| `Value` | `string?` | Evet |  |


### ServiceRequestHistory Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `ServiceRequestId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `ServiceRequest` |
| `OldStatus` | `ServiceRequestStatusEnum?` | Evet |  |
| `NewStatus` | `ServiceRequestStatusEnum` | Hayır |  |
| `ChangedByUserId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Users` |
| `ChangedAt` | `DateTime` | Hayır |  |
| `Note` | `string?` | Evet |  |


### ServiceRequestItem Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `ServiceRequestId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `ServiceRequest` |
| `ServiceDefinitionId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `ServiceRequest` |
| `ItemName` | `string` | Evet |  |
| `Quantity` | `int` | Hayır |  |
| `Note` | `string?` | Evet |  |


### ServiceRequestRating Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `ServiceRequestId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `ServiceRequest` |
| `CustomerId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Customer` |
| `SpeedScore` | `decimal` | Hayır |  |
| `QualityScore` | `decimal` | Hayır |  |
| `StaffScore` | `decimal` | Hayır |  |
| `Comment` | `string?` | Evet |  |
| `RatedAt` | `DateTime` | Hayır |  |
| `OrderId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Order` |
| `OrderItemId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `OrderItem` |
| `FoodId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Food` |


### ServiceRoleAssignments Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `ServicesEnumId` | `ServicesEnum` | Hayır | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `HotelId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `DepartmentId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Department` |
| `ServiceId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `EmployeeTypeRoleId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `IsPrimaryAssignment` | `bool` | Hayır |  |
| `Priority` | `int` | Hayır |  |
| `SlaMinutes` | `int?` | Evet |  |


### Shift Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Name` | `string` | Evet |  |
| `StartTime` | `TimeSpan` | Hayır |  |
| `EndTime` | `TimeSpan` | Hayır |  |
| `HotelId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `Description` | `string?` | Evet |  |
| `IsNightShift` | `bool` | Hayır |  |


### SpaAppointment Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `GuestStayId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `GuestStay` |
| `ServiceName` | `string` | Evet |  |
| `TherapistName` | `string` | Evet |  |
| `AppointmentDate` | `DateTime` | Hayır |  |
| `TimeSlot` | `string` | Evet |  |
| `Price` | `decimal` | Hayır |  |
| `CurrencyCode` | `string` | Evet |  |
| `Status` | `string` | Evet |  |


### StockItem Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `DepartmentId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `Code` | `string` | Evet |  |
| `Name` | `string` | Evet |  |
| `Unit` | `string` | Evet |  |
| `CurrentQuantity` | `decimal` | Hayır |  |
| `MinimumQuantity` | `decimal` | Hayır |  |
| `LastPurchasePrice` | `decimal?` | Evet |  |
| `AverageUnitCost` | `decimal` | Hayır |  |
| `IsCritical` | `bool` | Hayır |  |
| `Description` | `string?` | Evet |  |


### StockMovement Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `StockItemId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `DepartmentId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `EmployeeId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `MovementType` | `StockMovementTypeEnum` | Hayır |  |
| `Quantity` | `decimal` | Hayır |  |
| `UnitPrice` | `decimal` | Hayır |  |
| `TotalAmount` | `decimal` | Hayır |  |
| `Reason` | `string?` | Evet |  |
| `ReferenceType` | `string?` | Evet |  |
| `ReferenceId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `OccurredAt` | `DateTime` | Hayır |  |


### StockRequest Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `RequestedByEmployeeId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `AssignedManagerEmployeeId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `DepartmentId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `RelatedServiceRequestId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `Title` | `string` | Evet |  |
| `Description` | `string?` | Evet |  |
| `Priority` | `StockRequestPriorityEnum` | Hayır |  |
| `Status` | `StockRequestStatusEnum` | Hayır |  |
| `RequestedAt` | `DateTime` | Hayır |  |
| `ApprovedAt` | `DateTime?` | Evet |  |
| `FulfilledAt` | `DateTime?` | Evet |  |
| `ManagerNote` | `string?` | Evet |  |


### StockRequestItem Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `StockRequestId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `StockRequest` |
| `StockItemId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `StockRequest` |
| `RequestedQuantity` | `decimal` | Hayır |  |
| `ApprovedQuantity` | `decimal?` | Evet |  |
| `FulfilledQuantity` | `decimal?` | Evet |  |
| `UnitPrice` | `decimal?` | Evet |  |
| `Note` | `string?` | Evet |  |


### SystemParametre Tablosu

*Base Class:* `IEntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `ParametreKey` | `string` | Evet |  |
| `IsDeleted` | `bool` | Hayır |  |


### SystemParametreValues Tablosu

*Base Class:* `IEntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `SystemParametreId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `SystemParametre` |
| `ParametreValue` | `string` | Evet |  |
| `Description` | `string` | Evet |  |
| `SystemParametreValueId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `SystemParametreValues` |
| `IsDeleted` | `bool` | Hayır |  |


### Translation Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `TableName` | `string` | Evet |  |
| `RecordId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Bilinmiyor` |
| `FieldName` | `string` | Evet |  |
| `TranslationValue` | `string` | Evet |  |
| `LanguageCode` | `string` | Evet |  |


### UserNotification Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `HotelId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `UserId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `EmployeeId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `DepartmentId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `ServiceRequestId` | `int?` | Evet | 🔗 **FK (Foreign Key)** -> `Hotel` |
| `Title` | `string` | Evet |  |
| `Message` | `string` | Evet |  |
| `NotificationType` | `string` | Evet |  |
| `IsRead` | `bool` | Hayır |  |
| `ReadAt` | `DateTime?` | Evet |  |


### Users Tablosu

*Base Class:* `EntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `Email` | `string` | Evet |  |
| `Password` | `string` | Evet |  |
| `UserName` | `string?` | Evet |  |
| `PreferredLanguageCode` | `string` | Evet |  |
| `LastLoginAt` | `DateTime?` | Evet |  |
| `FailedLoginCount` | `int` | Hayır |  |
| `IsLocked` | `bool` | Hayır |  |
| `RefreshToken` | `string?` | Evet |  |
| `RefreshTokenExpireDate` | `DateTime?` | Evet |  |
| `RoleId` | `int` | Hayır | 🔗 **FK (Foreign Key)** -> `Roles` |


### ValidationMessages Tablosu

*Base Class:* `IEntityBase`

| Kolon Adı | Veri Tipi | Boş Geçebilir (Nullable) | Anahtar / İlişki |

| --- | --- | --- | --- |

| `Id` | `int` | Hayır | 🔑 **PK (Primary Key)** |
| `CreatedDate` | `DateTime` | Hayır |  |
| `ModifyDate` | `DateTime` | Hayır |  |
| `IsDeleted` | `bool` | Hayır |  |
| `IsActive` | `bool` | Hayır |  |
| `ValidationMessageType` | `ValidationMessageType` | Hayır |  |
| `ValidationMessage` | `string` | Evet |  |
| `LanguageCode` | `string` | Evet |  |
| `IsDeleted` | `bool` | Hayır |  |

