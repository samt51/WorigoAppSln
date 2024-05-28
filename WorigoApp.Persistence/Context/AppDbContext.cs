using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Entites.GServices;

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
            optionsBuilder.UseSqlServer("Server=SAMETBAGLAN;Database=WorigoBackAppDb;Trusted_Connection=True;TrustServerCertificate=true;Encrypt=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

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

        #endregion
    }
}
