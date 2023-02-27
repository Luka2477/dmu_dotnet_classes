using Microsoft.EntityFrameworkCore;
using test.Models;

namespace test.DAL;

public class PersonContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<House> Houses { get; set; }
    public DbSet<Pet> Pets { get; set; }

    // Define connection string
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=localhost,1433;Initial Catalog=dotnet_day08_test;user=SA;password=Knudsen123!;TrustServerCertificate=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Person p1 = new(1, "Lukas Knudsen");
        Person p2 = new(2, "Mads Bjerg");
        Person p3 = new(3, "Berta Vazquez");

        House h1 = new(1, "Aarhus", 1);
        House h2 = new(2, "København", 2);

        Pet pet1 = new(1, "Bailey", 1);
        Pet pet2 = new(2, "Cody", 3);
        Pet pet3 = new(3, "Maggie", 3);

        modelBuilder.Entity<Person>().HasData(p1, p2, p3);
        modelBuilder.Entity<House>().HasData(h1, h2);
        modelBuilder.Entity<Pet>().HasData(pet1, pet2, pet3);
    }
}