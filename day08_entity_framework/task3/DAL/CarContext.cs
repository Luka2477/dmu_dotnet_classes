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
            Car = car1
        };
        car1.Owners.Add(owner11);
        Owner owner12 = new()
        {
            ID = 2,
            Name = "Nicolai Knudsen",
            Cpr = 1122334455,
            Car = car1
        };
        car1.Owners.Add(owner12);
        Owner owner21 = new()
        {
            ID = 3,
            Name = "Berta Vazquez de Zubiaurre",
            Cpr = 12345678,
            Car = car2
        };
        car2.Owners.Add(owner21);

        modelBuilder.Entity<Car>().HasData(new Car[]
        {
            car1,
            car2
        });
        modelBuilder.Entity<Owner>().HasData(new Owner[]
        {
            owner11,
            owner12,
            owner21
        });
    }
}