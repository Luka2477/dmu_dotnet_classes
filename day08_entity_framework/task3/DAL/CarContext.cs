using Microsoft.EntityFrameworkCore;
using task3.Models;

namespace task3.DAL;

public class CarContext : DbContext
{
    public DbSet<Car> Cars { get; set; }

    // Define connection string
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=localhost,1433;Initial Catalog=dotnet_day08_task1;user=SA;password=Knudsen123!;TrustServerCertificate=true");
    }

    // Initialize database with pre-set data
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().HasData(new Car[]
        {
            new()
            {
                ID = 1,
                Make = "Volkswagen",
                Model = "Golf GTI",
                Wheels = 4,
                Year = 2016
            },
            new()
            {
                ID = 2,
                Make = "Mercedes",
                Model = "C300",
                Wheels = 4,
                Year = 2022
            }
        });
    }
}