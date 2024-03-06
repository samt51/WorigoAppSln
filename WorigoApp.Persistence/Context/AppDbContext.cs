using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetail { get; set; }
        public DbSet<EmployeeType> EmployeeType { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<ContentsOfFood> ContentsOfFood { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<FoodMenuCategory> FoodMenuCategory { get; set; }
        public DbSet<FoodType>  FoodType { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Image>  Image { get; set; }
        public DbSet<ImageCategory> ImageCategory { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<ServiceOfFeature> ServiceOfFeature { get; set; }
        public DbSet<ServiceOfValue> ServiceOfValue { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
