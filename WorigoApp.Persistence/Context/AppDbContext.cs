using Microsoft.EntityFrameworkCore;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Entites.GServices;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FoodContentsOfFood>()
                .HasKey(fc => new { fc.FoodId, fc.ContentsOfFoodId });

            modelBuilder.Entity<FoodContentsOfFood>()
                .HasOne(fc => fc.Food)
                .WithMany(f => f.FoodContentsOfFoods)
                .HasForeignKey(fc => fc.FoodId);

            modelBuilder.Entity<FoodContentsOfFood>()
                .HasOne(fc => fc.ContentsOfFood)
                .WithMany(c => c.FoodContentsOfFoods)
                .HasForeignKey(fc => fc.ContentsOfFoodId);

            modelBuilder.Entity<FoodAllergens>()
                .HasKey(fc => new { fc.FoodId, fc.AllergenId });

            modelBuilder.Entity<FoodAllergens>()
                .HasOne(fc => fc.Food)
                .WithMany(f => f.FoodAllergens)
                .HasForeignKey(fc => fc.FoodId);

            modelBuilder.Entity<FoodAllergens>()
                .HasOne(fc => fc.Allergen)
                .WithMany(c => c.FoodAllergens)
                .HasForeignKey(fc => fc.AllergenId);

            modelBuilder.Entity<FoodDietaryRestrictions>()
                .HasKey(fc => new { fc.FoodId, fc.DietaryRestrictionId });

            modelBuilder.Entity<FoodDietaryRestrictions>()
                .HasOne(fc => fc.Food)
                .WithMany(f => f.FoodDietaryRestrictions)
                .HasForeignKey(fc => fc.FoodId);

            modelBuilder.Entity<FoodDietaryRestrictions>()
                .HasOne(fc => fc.DietaryRestriction)
                .WithMany(c => c.FoodDietaryRestrictions)
                .HasForeignKey(fc => fc.DietaryRestrictionId);

            modelBuilder.Entity<Employee>()
                .HasOne(x => x.User)
                .WithOne(x => x.Employee)
                .HasForeignKey<Employee>(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                .HasOne(x => x.Shift)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.ShiftId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HotelServicePolicy>()
                .HasOne(x => x.Hotel)
                .WithMany(x => x.HotelServicePolicies)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceCategory>()
                .HasOne(x => x.Hotel)
                .WithMany(x => x.ServiceCategories)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceDefinition>()
                .HasOne(x => x.Hotel)
                .WithMany(x => x.ServiceDefinitions)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceDefinition>()
                .HasOne(x => x.ServiceCategory)
                .WithMany(x => x.ServiceDefinitions)
                .HasForeignKey(x => x.ServiceCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceDefinition>()
                .HasOne(x => x.Department)
                .WithMany(x => x.ServiceDefinitions)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceDefinitionField>()
                .HasOne(x => x.ServiceDefinition)
                .WithMany(x => x.Fields)
                .HasForeignKey(x => x.ServiceDefinitionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceDefinitionField>()
                .HasIndex(x => new { x.ServiceDefinitionId, x.FieldKey })
                .IsUnique();

            modelBuilder.Entity<HotelServicePolicy>()
                .HasOne(x => x.ServiceDefinition)
                .WithMany()
                .HasForeignKey(x => x.ServiceDefinitionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GuestSession>()
                .HasOne(x => x.GuestStay)
                .WithMany(x => x.GuestSessions)
                .HasForeignKey(x => x.GuestStayId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GuestSession>()
                .HasOne(x => x.Customer)
                .WithMany(x => x.GuestSessions)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Conversation>()
                .HasOne(x => x.Hotel)
                .WithMany(x => x.Conversations)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Conversation>()
                .HasOne(x => x.GuestStay)
                .WithMany(x => x.Conversations)
                .HasForeignKey(x => x.GuestStayId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Conversation>()
                .HasOne(x => x.Customer)
                .WithMany(x => x.Conversations)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ConversationMessage>()
                .HasOne(x => x.Conversation)
                .WithMany(x => x.Messages)
                .HasForeignKey(x => x.ConversationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ConversationMessage>()
                .HasOne(x => x.SenderUser)
                .WithMany(x => x.ConversationMessages)
                .HasForeignKey(x => x.SenderUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ConversationMessage>()
                .HasOne(x => x.SenderCustomer)
                .WithMany(x => x.ConversationMessages)
                .HasForeignKey(x => x.SenderCustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ConversationFlowSession>()
                .HasOne(x => x.Conversation)
                .WithMany(x => x.FlowSessions)
                .HasForeignKey(x => x.ConversationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ConversationFlowSession>()
                .HasOne(x => x.ServiceCategory)
                .WithMany(x => x.FlowSessions)
                .HasForeignKey(x => x.ServiceCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ConversationFlowSession>()
                .HasOne(x => x.ServiceDefinition)
                .WithMany(x => x.FlowSessions)
                .HasForeignKey(x => x.ServiceDefinitionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Charge>()
                .HasOne(x => x.GuestStay)
                .WithMany(x => x.Charges)
                .HasForeignKey(x => x.GuestStayId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Charge>()
                .HasOne(x => x.Order)
                .WithMany(x => x.Charges)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(x => x.ServiceRequest)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.ServiceRequestId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Charge>()
                .HasOne(x => x.ServiceRequest)
                .WithMany(x => x.Charges)
                .HasForeignKey(x => x.ServiceRequestId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PaymentTransaction>()
                .HasOne(x => x.Charge)
                .WithMany(x => x.PaymentTransactions)
                .HasForeignKey(x => x.ChargeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceRequest>()
                .HasOne(x => x.Hotel)
                .WithMany(x => x.ServiceRequests)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceRequest>()
                .HasOne(x => x.Department)
                .WithMany(x => x.ServiceRequests)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceRequest>()
                .HasOne(x => x.AssignedEmployee)
                .WithMany(x => x.AssignedServiceRequests)
                .HasForeignKey(x => x.AssignedEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceRequest>()
                .HasOne(x => x.Customer)
                .WithMany(x => x.ServiceRequests)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceRequest>()
                .HasOne(x => x.GuestStay)
                .WithMany(x => x.ServiceRequests)
                .HasForeignKey(x => x.GuestStayId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceRequest>()
                .HasOne(x => x.ServiceDefinition)
                .WithMany(x => x.ServiceRequests)
                .HasForeignKey(x => x.ServiceDefinitionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceRequest>()
                .HasOne(x => x.Conversation)
                .WithOne(x => x.ServiceRequest)
                .HasForeignKey<ServiceRequest>(x => x.ConversationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceRequestFieldValue>()
                .HasOne(x => x.ServiceRequest)
                .WithMany(x => x.FieldValues)
                .HasForeignKey(x => x.ServiceRequestId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceRequestFieldValue>()
                .HasOne(x => x.ServiceDefinitionField)
                .WithMany(x => x.RequestValues)
                .HasForeignKey(x => x.ServiceDefinitionFieldId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceRequestItem>()
                .HasOne(x => x.ServiceRequest)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.ServiceRequestId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceRequestItem>()
                .HasOne(x => x.ServiceDefinition)
                .WithMany(x => x.ServiceRequestItems)
                .HasForeignKey(x => x.ServiceDefinitionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceRequestHistory>()
                .HasOne(x => x.ChangedByUser)
                .WithMany(x => x.ServiceRequestHistories)
                .HasForeignKey(x => x.ChangedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceRequestMessage>()
                .HasOne(x => x.SenderUser)
                .WithMany(x => x.ServiceRequestMessages)
                .HasForeignKey(x => x.SenderUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockItem>()
                .HasOne(x => x.Hotel)
                .WithMany(x => x.StockItems)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockItem>()
                .HasOne(x => x.Department)
                .WithMany(x => x.StockItems)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockMovement>()
                .HasOne(x => x.Hotel)
                .WithMany(x => x.StockMovements)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockMovement>()
                .HasOne(x => x.Department)
                .WithMany(x => x.StockMovements)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockMovement>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.StockMovements)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockMovement>()
                .HasOne(x => x.StockItem)
                .WithMany(x => x.StockMovements)
                .HasForeignKey(x => x.StockItemId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockRequest>()
                .HasOne(x => x.Hotel)
                .WithMany(x => x.StockRequests)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockRequest>()
                .HasOne(x => x.RequestedByEmployee)
                .WithMany(x => x.RequestedStockRequests)
                .HasForeignKey(x => x.RequestedByEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockRequest>()
                .HasOne(x => x.AssignedManagerEmployee)
                .WithMany(x => x.ManagedStockRequests)
                .HasForeignKey(x => x.AssignedManagerEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockRequest>()
                .HasOne(x => x.Department)
                .WithMany(x => x.StockRequests)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockRequest>()
                .HasOne(x => x.RelatedServiceRequest)
                .WithMany(x => x.StockRequests)
                .HasForeignKey(x => x.RelatedServiceRequestId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockRequestItem>()
                .HasOne(x => x.StockRequest)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.StockRequestId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockRequestItem>()
                .HasOne(x => x.StockItem)
                .WithMany(x => x.StockRequestItems)
                .HasForeignKey(x => x.StockItemId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LeaveRequest>()
                .HasOne(x => x.Hotel)
                .WithMany(x => x.LeaveRequests)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LeaveRequest>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.LeaveRequests)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LeaveRequest>()
                .HasOne(x => x.Department)
                .WithMany(x => x.LeaveRequests)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LeaveRequest>()
                .HasOne(x => x.ManagerEmployee)
                .WithMany(x => x.ManagedLeaveRequests)
                .HasForeignKey(x => x.ManagerEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LeaveRequest>()
                .HasOne(x => x.HrEmployee)
                .WithMany(x => x.HrManagedLeaveRequests)
                .HasForeignKey(x => x.HrEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AttendanceRecord>()
                .HasOne(x => x.Hotel)
                .WithMany(x => x.AttendanceRecords)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AttendanceRecord>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.AttendanceRecords)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AttendanceRecord>()
                .HasOne(x => x.Department)
                .WithMany(x => x.AttendanceRecords)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AttendanceRecord>()
                .HasOne(x => x.Shift)
                .WithMany(x => x.AttendanceRecords)
                .HasForeignKey(x => x.ShiftId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PerformanceReview>()
                .HasOne(x => x.Hotel)
                .WithMany(x => x.PerformanceReviews)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PerformanceReview>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.PerformanceReviews)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PerformanceReview>()
                .HasOne(x => x.ReviewerEmployee)
                .WithMany(x => x.ReviewerPerformanceReviews)
                .HasForeignKey(x => x.ReviewerEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PerformanceReview>()
                .HasOne(x => x.Department)
                .WithMany(x => x.PerformanceReviews)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InternalAnnouncement>()
                .HasOne(x => x.Hotel)
                .WithMany(x => x.InternalAnnouncements)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InternalAnnouncement>()
                .HasOne(x => x.Department)
                .WithMany(x => x.InternalAnnouncements)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InternalAnnouncement>()
                .HasOne(x => x.CreatedByEmployee)
                .WithMany(x => x.InternalAnnouncements)
                .HasForeignKey(x => x.CreatedByEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeTask>()
                .HasOne(x => x.Hotel)
                .WithMany(x => x.EmployeeTasks)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeTask>()
                .HasOne(x => x.AssignedEmployee)
                .WithMany(x => x.AssignedEmployeeTasks)
                .HasForeignKey(x => x.AssignedEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeTask>()
                .HasOne(x => x.AssignedByEmployee)
                .WithMany(x => x.CreatedEmployeeTasks)
                .HasForeignKey(x => x.AssignedByEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeTask>()
                .HasOne(x => x.Department)
                .WithMany(x => x.EmployeeTasks)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeTask>()
                .HasOne(x => x.RelatedServiceRequest)
                .WithMany()
                .HasForeignKey(x => x.RelatedServiceRequestId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeDocument>()
                .HasOne(x => x.Hotel)
                .WithMany(x => x.EmployeeDocuments)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeDocument>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.EmployeeDocuments)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeDocument>()
                .HasOne(x => x.VerifiedByEmployee)
                .WithMany(x => x.VerifiedEmployeeDocuments)
                .HasForeignKey(x => x.VerifiedByEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetail { get; set; }
        public DbSet<EmployeeType> EmployeeType { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<ContentsOfFood> ContentsOfFood { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<FoodMenuCategory> FoodMenuCategory { get; set; }
        public DbSet<FoodType> FoodType { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<ImageCategory> ImageCategory { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<BellBoy> BellBoy { get; set; }
        public DbSet<Connection> Connection { get; set; }
        public DbSet<HouseKeeping> HouseKeeping { get; set; }
        public DbSet<SpaMassage> SpaMassage { get; set; }
        public DbSet<TechnicalNeed> TechnicalNeed { get; set; }
        public DbSet<DryCleaner> DryCleaner { get; set; }
        public DbSet<HotelInformationAndAnnouncements> HotelInformationAndAnnouncements { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<LogEntry> LogEntries { get; set; }
        public DbSet<FeedBackAndSurvey> FeedBackAndSurveys { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<CommentAndRating> CommentAndRatings { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<GuestStay> GuestStays { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FoodContentsOfFood> FoodContentsOfFood { get; set; }
        public DbSet<SystemParametre> SystemParameter { get; set; }
        public DbSet<SystemParametreValues> SystemParametreValues { get; set; }
        public DbSet<ServiceRoleAssignments> ServiceRoleAssignment { get; set; }
        public DbSet<Allergen> Allergen { get; set; }
        public DbSet<DietaryRestriction> DietaryRestriction { get; set; }
        public DbSet<NutritionalInfo> NutritionalInfo { get; set; }
        public DbSet<FoodAllergens> FoodAllergen { get; set; }
        public DbSet<FoodDietaryRestrictions> FoodDietaryRestrictions { get; set; }
        public DbSet<HealthAndSafety> HealthAndSafety { get; set; }
        public DbSet<TravelOrTransportation> TravelOrTransportation { get; set; }
        public DbSet<MinibarService> MinibarServices { get; set; }
        public DbSet<WakeUpCallService> WakeUpCallServices { get; set; }
        public DbSet<ValetParkingService> ValetParkingServices { get; set; }
        public DbSet<StayExtensionService> StayExtensionServices { get; set; }
        public DbSet<AmenityRequestService> AmenityRequestServices { get; set; }
        public DbSet<MedicalAssistanceService> MedicalAssistanceServices { get; set; }
        public DbSet<ValidationMessages> ValidationMessages { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<ServiceRequestHistory> ServiceRequestHistories { get; set; }
        public DbSet<ServiceRequestMessage> ServiceRequestMessages { get; set; }
        public DbSet<ServiceRequestRating> ServiceRequestRatings { get; set; }
        public DbSet<StockItem> StockItems { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }
        public DbSet<StockRequest> StockRequests { get; set; }
        public DbSet<StockRequestItem> StockRequestItems { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
        public DbSet<PerformanceReview> PerformanceReviews { get; set; }
        public DbSet<InternalAnnouncement> InternalAnnouncements { get; set; }
        public DbSet<EmployeeTask> EmployeeTasks { get; set; }
        public DbSet<EmployeeDocument> EmployeeDocuments { get; set; }
        public DbSet<HotelServicePolicy> HotelServicePolicies { get; set; }
        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public DbSet<GuestSession> GuestSessions { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<ConversationMessage> ConversationMessages { get; set; }
        public DbSet<ConversationFlowSession> ConversationFlowSessions { get; set; }
        public DbSet<Charge> Charges { get; set; }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<ServiceDefinition> ServiceDefinitions { get; set; }
        public DbSet<ServiceDefinitionField> ServiceDefinitionFields { get; set; }
        public DbSet<ServiceRequestFieldValue> ServiceRequestFieldValues { get; set; }
        public DbSet<ServiceRequestItem> ServiceRequestItems { get; set; }
    }
}
