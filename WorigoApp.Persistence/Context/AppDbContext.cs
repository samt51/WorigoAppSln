using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Entites.GServices;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-L558L50\\SAMETSQL;Database=WorigoDb;Trusted_Connection=True;TrustServerCertificate=true;Encrypt=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            #region Yemek ve içindekiler ilişki

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

            #endregion

            #region Yemek ve alerjen maddeler

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
            #endregion

            #region Yemek ve diyet kısıtlaması
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
            #endregion
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region DbSets
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetail { get; set; }
        public DbSet<EmployeeType> EmployeeType { get; set; }
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
        public DbSet<RoomBasedTransaction> RoomBasedTransaction { get; set; }
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
        public DbSet<ValidationMessages> ValidationMessages { get; set; }


        #endregion
    }
}
