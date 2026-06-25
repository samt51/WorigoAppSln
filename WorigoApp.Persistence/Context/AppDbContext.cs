using Microsoft.EntityFrameworkCore;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Persistence.Context
{
    /// <summary>
    /// AppDbContext sınıfını temsil eder.
    /// </summary>
    public class AppDbContext : DbContext
    {
/// <summary>
/// AppDbContext sınıfının yeni bir örneğini başlatır.
/// </summary>
public AppDbContext()
        {
        }
/// <summary>
/// AppDbContext sınıfının yeni bir örneğini başlatır.
/// </summary>
public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
/// <summary>
/// OnModelCreating işlemini gerçekleştirir.
/// </summary>
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

            modelBuilder.Entity<ServiceDefinitionFieldOption>()
                .HasOne(x => x.ServiceDefinitionField)
                .WithMany(x => x.Options)
                .HasForeignKey(x => x.ServiceDefinitionFieldId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceDefinitionFieldOption>()
                .HasIndex(x => new { x.ServiceDefinitionFieldId, x.Value })
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

            modelBuilder.Entity<UserNotification>()
                .HasOne(x => x.Hotel)
                .WithMany()
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserNotification>()
                .HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserNotification>()
                .HasOne(x => x.Employee)
                .WithMany()
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserNotification>()
                .HasOne(x => x.Department)
                .WithMany()
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserNotification>()
                .HasOne(x => x.ServiceRequest)
                .WithMany()
                .HasForeignKey(x => x.ServiceRequestId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeDeviceToken>()
                .HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeDeviceToken>()
                .HasOne(x => x.Employee)
                .WithMany()
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeDeviceToken>()
                .HasIndex(x => x.Token)
                .IsUnique();

            modelBuilder.Entity<SpaAppointment>()
                .HasOne(x => x.GuestStay)
                .WithMany()
                .HasForeignKey(x => x.GuestStayId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Restaurant>()
                .HasOne(x => x.Hotel)
                .WithMany()
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RestaurantReservation>()
                .HasOne(x => x.Hotel)
                .WithMany()
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RestaurantReservation>()
                .HasOne(x => x.Restaurant)
                .WithMany(x => x.Reservations)
                .HasForeignKey(x => x.RestaurantId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RestaurantReservation>()
                .HasOne(x => x.GuestStay)
                .WithMany()
                .HasForeignKey(x => x.GuestStayId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RestaurantReservation>()
                .HasOne(x => x.Customer)
                .WithMany()
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RestaurantReservation>()
                .HasOne(x => x.ApprovedByEmployee)
                .WithMany()
                .HasForeignKey(x => x.ApprovedByEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TransferTracking>()
                .HasOne(x => x.Hotel)
                .WithMany()
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TransferTracking>()
                .HasOne(x => x.ServiceRequest)
                .WithMany()
                .HasForeignKey(x => x.ServiceRequestId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TransferTracking>()
                .HasOne(x => x.GuestStay)
                .WithMany()
                .HasForeignKey(x => x.GuestStayId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TransferTracking>()
                .HasOne(x => x.Customer)
                .WithMany()
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TransferTracking>()
                .HasOne(x => x.AssignedEmployee)
                .WithMany()
                .HasForeignKey(x => x.AssignedEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ConciergePlace>()
                .HasOne(x => x.Hotel)
                .WithMany()
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GuestNotification>()
                .HasOne(x => x.Hotel)
                .WithMany()
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GuestNotification>()
                .HasOne(x => x.GuestStay)
                .WithMany()
                .HasForeignKey(x => x.GuestStayId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GuestNotification>()
                .HasOne(x => x.Customer)
                .WithMany()
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GuestNotification>()
                .HasOne(x => x.GuestSession)
                .WithMany()
                .HasForeignKey(x => x.GuestSessionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SpaService>()
                .HasOne(x => x.Hotel)
                .WithMany()
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);
        }

/// <summary>
/// Employee değerini alır veya ayarlar.
/// </summary>
public DbSet<Employee> Employee { get; set; }
/// <summary>
/// EmployeeType değerini alır veya ayarlar.
/// </summary>
public DbSet<EmployeeType> EmployeeType { get; set; }
/// <summary>
/// Shift değerini alır veya ayarlar.
/// </summary>
public DbSet<Shift> Shift { get; set; }
/// <summary>
/// Company değerini alır veya ayarlar.
/// </summary>
public DbSet<Company> Company { get; set; }
/// <summary>
/// ContentsOfFood değerini alır veya ayarlar.
/// </summary>
public DbSet<ContentsOfFood> ContentsOfFood { get; set; }
/// <summary>
/// Department değerini alır veya ayarlar.
/// </summary>
public DbSet<Department> Department { get; set; }
/// <summary>
/// Food değerini alır veya ayarlar.
/// </summary>
public DbSet<Food> Food { get; set; }
/// <summary>
/// FoodMenuCategory değerini alır veya ayarlar.
/// </summary>
public DbSet<FoodMenuCategory> FoodMenuCategory { get; set; }
/// <summary>
/// FoodType değerini alır veya ayarlar.
/// </summary>
public DbSet<FoodType> FoodType { get; set; }
/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public DbSet<Hotel> Hotel { get; set; }
/// <summary>
/// Image değerini alır veya ayarlar.
/// </summary>
public DbSet<Image> Image { get; set; }
/// <summary>
/// ImageCategory değerini alır veya ayarlar.
/// </summary>
public DbSet<ImageCategory> ImageCategory { get; set; }
/// <summary>
/// Room değerini alır veya ayarlar.
/// </summary>
public DbSet<Room> Room { get; set; }
/// <summary>
/// RoomType değerini alır veya ayarlar.
/// </summary>
public DbSet<RoomType> RoomType { get; set; }
/// <summary>
/// Users değerini alır veya ayarlar.
/// </summary>
public DbSet<Users> Users { get; set; }
/// <summary>
/// Roles değerini alır veya ayarlar.
/// </summary>
public DbSet<Roles> Roles { get; set; }
/// <summary>
/// LogEntries değerini alır veya ayarlar.
/// </summary>
public DbSet<LogEntry> LogEntries { get; set; }
/// <summary>
/// Orders değerini alır veya ayarlar.
/// </summary>
public DbSet<Order> Orders { get; set; }
/// <summary>
/// OrderItems değerini alır veya ayarlar.
/// </summary>
public DbSet<OrderItem> OrderItems { get; set; }
/// <summary>
/// Translations değerini alır veya ayarlar.
/// </summary>
public DbSet<Translation> Translations { get; set; }
/// <summary>
/// GuestStays değerini alır veya ayarlar.
/// </summary>
public DbSet<GuestStay> GuestStays { get; set; }
/// <summary>
/// Customers değerini alır veya ayarlar.
/// </summary>
public DbSet<Customer> Customers { get; set; }
/// <summary>
/// FoodContentsOfFood değerini alır veya ayarlar.
/// </summary>
public DbSet<FoodContentsOfFood> FoodContentsOfFood { get; set; }
/// <summary>
/// SystemParameter değerini alır veya ayarlar.
/// </summary>
public DbSet<SystemParametre> SystemParameter { get; set; }
/// <summary>
/// SystemParametreValues değerini alır veya ayarlar.
/// </summary>
public DbSet<SystemParametreValues> SystemParametreValues { get; set; }
/// <summary>
/// ServiceRoleAssignment değerini alır veya ayarlar.
/// </summary>
public DbSet<ServiceRoleAssignments> ServiceRoleAssignment { get; set; }
/// <summary>
/// Allergen değerini alır veya ayarlar.
/// </summary>
public DbSet<Allergen> Allergen { get; set; }
/// <summary>
/// DietaryRestriction değerini alır veya ayarlar.
/// </summary>
public DbSet<DietaryRestriction> DietaryRestriction { get; set; }
/// <summary>
/// NutritionalInfo değerini alır veya ayarlar.
/// </summary>
public DbSet<NutritionalInfo> NutritionalInfo { get; set; }
/// <summary>
/// FoodAllergen değerini alır veya ayarlar.
/// </summary>
public DbSet<FoodAllergens> FoodAllergen { get; set; }
/// <summary>
/// FoodDietaryRestrictions değerini alır veya ayarlar.
/// </summary>
public DbSet<FoodDietaryRestrictions> FoodDietaryRestrictions { get; set; }
/// <summary>
/// ValidationMessages değerini alır veya ayarlar.
/// </summary>
public DbSet<ValidationMessages> ValidationMessages { get; set; }
/// <summary>
/// Announcements değerini alır veya ayarlar.
/// </summary>
public DbSet<Announcement> Announcements { get; set; }
/// <summary>
/// ServiceRequests değerini alır veya ayarlar.
/// </summary>
public DbSet<ServiceRequest> ServiceRequests { get; set; }
/// <summary>
/// ServiceRequestHistories değerini alır veya ayarlar.
/// </summary>
public DbSet<ServiceRequestHistory> ServiceRequestHistories { get; set; }
/// <summary>
/// ServiceRequestRatings değerini alır veya ayarlar.
/// </summary>
public DbSet<ServiceRequestRating> ServiceRequestRatings { get; set; }
/// <summary>
/// StockItems değerini alır veya ayarlar.
/// </summary>
public DbSet<StockItem> StockItems { get; set; }
/// <summary>
/// StockMovements değerini alır veya ayarlar.
/// </summary>
public DbSet<StockMovement> StockMovements { get; set; }
/// <summary>
/// StockRequests değerini alır veya ayarlar.
/// </summary>
public DbSet<StockRequest> StockRequests { get; set; }
/// <summary>
/// StockRequestItems değerini alır veya ayarlar.
/// </summary>
public DbSet<StockRequestItem> StockRequestItems { get; set; }
/// <summary>
/// LeaveRequests değerini alır veya ayarlar.
/// </summary>
public DbSet<LeaveRequest> LeaveRequests { get; set; }
/// <summary>
/// AttendanceRecords değerini alır veya ayarlar.
/// </summary>
public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
/// <summary>
/// PerformanceReviews değerini alır veya ayarlar.
/// </summary>
public DbSet<PerformanceReview> PerformanceReviews { get; set; }
/// <summary>
/// EmployeeTasks değerini alır veya ayarlar.
/// </summary>
public DbSet<EmployeeTask> EmployeeTasks { get; set; }
/// <summary>
/// EmployeeDocuments değerini alır veya ayarlar.
/// </summary>
public DbSet<EmployeeDocument> EmployeeDocuments { get; set; }
/// <summary>
/// HotelServicePolicies değerini alır veya ayarlar.
/// </summary>
public DbSet<HotelServicePolicy> HotelServicePolicies { get; set; }
/// <summary>
/// PaymentTransactions değerini alır veya ayarlar.
/// </summary>
public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
/// <summary>
/// GuestSessions değerini alır veya ayarlar.
/// </summary>
public DbSet<GuestSession> GuestSessions { get; set; }
/// <summary>
/// SpaAppointments değerini alır veya ayarlar.
/// </summary>
public DbSet<SpaAppointment> SpaAppointments { get; set; }
/// <summary>
/// Conversations değerini alır veya ayarlar.
/// </summary>
public DbSet<Conversation> Conversations { get; set; }
/// <summary>
/// ConversationMessages değerini alır veya ayarlar.
/// </summary>
public DbSet<ConversationMessage> ConversationMessages { get; set; }
/// <summary>
/// ConversationFlowSessions değerini alır veya ayarlar.
/// </summary>
public DbSet<ConversationFlowSession> ConversationFlowSessions { get; set; }
/// <summary>
/// Charges değerini alır veya ayarlar.
/// </summary>
public DbSet<Charge> Charges { get; set; }
/// <summary>
/// ServiceCategories değerini alır veya ayarlar.
/// </summary>
public DbSet<ServiceCategory> ServiceCategories { get; set; }
/// <summary>
/// ServiceDefinitions değerini alır veya ayarlar.
/// </summary>
public DbSet<ServiceDefinition> ServiceDefinitions { get; set; }
/// <summary>
/// ServiceDefinitionFields değerini alır veya ayarlar.
/// </summary>
public DbSet<ServiceDefinitionField> ServiceDefinitionFields { get; set; }
/// <summary>
/// ServiceDefinitionFieldOptions değerini alır veya ayarlar.
/// </summary>
public DbSet<ServiceDefinitionFieldOption> ServiceDefinitionFieldOptions { get; set; }
/// <summary>
/// ServiceRequestFieldValues değerini alır veya ayarlar.
/// </summary>
public DbSet<ServiceRequestFieldValue> ServiceRequestFieldValues { get; set; }
/// <summary>
/// ServiceRequestItems değerini alır veya ayarlar.
/// </summary>
public DbSet<ServiceRequestItem> ServiceRequestItems { get; set; }
/// <summary>
/// UserNotifications değerini alır veya ayarlar.
/// </summary>
public DbSet<UserNotification> UserNotifications { get; set; }
/// <summary>
/// EmployeeDeviceTokens değerini alır veya ayarlar.
/// </summary>
public DbSet<EmployeeDeviceToken> EmployeeDeviceTokens { get; set; }
/// <summary>
/// Restaurants değerini alır veya ayarlar.
/// </summary>
public DbSet<Restaurant> Restaurants { get; set; }
/// <summary>
/// RestaurantReservations değerini alır veya ayarlar.
/// </summary>
public DbSet<RestaurantReservation> RestaurantReservations { get; set; }
/// <summary>
/// TransferTrackings değerini alır veya ayarlar.
/// </summary>
public DbSet<TransferTracking> TransferTrackings { get; set; }
/// <summary>
/// ConciergePlaces değerini alır veya ayarlar.
/// </summary>
public DbSet<ConciergePlace> ConciergePlaces { get; set; }
/// <summary>
/// GuestNotifications değerini alır veya ayarlar.
/// </summary>
public DbSet<GuestNotification> GuestNotifications { get; set; }
/// <summary>
/// SpaServices değerini alır veya ayarlar.
/// </summary>
public DbSet<SpaService> SpaServices { get; set; }
/// <summary>
/// ReceptionShiftNotes değerini alır veya ayarlar.
/// </summary>
public DbSet<ReceptionShiftNote> ReceptionShiftNotes { get; set; }
/// <summary>
/// ReceptionAuditLogs değerini alır veya ayarlar.
/// </summary>
public DbSet<ReceptionAuditLog> ReceptionAuditLogs { get; set; }
/// <summary>
/// ReceptionCashShifts değerini alır veya ayarlar.
/// </summary>
public DbSet<ReceptionCashShift> ReceptionCashShifts { get; set; }
/// <summary>
/// ReceptionCashTransactions değerini alır veya ayarlar.
/// </summary>
public DbSet<ReceptionCashTransaction> ReceptionCashTransactions { get; set; }
    }
}
