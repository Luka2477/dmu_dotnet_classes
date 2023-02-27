using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using task3.Models;

namespace task3.DAL;

public class CarContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Owner> Owners { get; set; }

    // Define connection string
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=localhost,1433;Initial Catalog=dotnet_day08_task1;user=SA;password=Knudsen123!;TrustServerCertificate=true");
    }

    // Initialize database with pre-set data
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Car car1 = new()
        {
            ID = 1,
            Make = "Volkswagen",
            Model = "Golf GTI",
            Wheels = 4,
            Year = 2016
        };
        Car car2 = new()
        {
            ID = 2,
            Make = "Mercedes",
            Model = "C300",
            Wheels = 4,
            Year = 2022
        };

        Owner owner11 = new()
        {
            ID = 1,
            Name = "Lukas Knudsen",
            Cpr = 1902005109,
            CarID = 1
        };
        Owner owner12 = new()
        {
            ID = 2,
            Name = "Nicolai Knudsen",
            Cpr = 1122334455,
            CarID = 1
        };
        Owner owner21 = new()
        {
            ID = 3,
            Name = "Berta Vazquez de Zubiaurre",
            Cpr = 12345678,
            CarID = 2
        };

        modelBuilder.Entity<Car>().HasData(car1, car2);
        modelBuilder.Entity<Owner>().HasData(owner11, owner12, owner21);
    }
}