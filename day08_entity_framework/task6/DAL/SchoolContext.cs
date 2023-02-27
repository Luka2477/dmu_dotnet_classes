using Microsoft.EntityFrameworkCore;
using task6.Models;

namespace task6.DAL;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Class> Classes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=localhost,1433;Initial Catalog=dotnet_day08_task6;user=SA;password=Knudsen123!;TrustServerCertificate=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Initialize student data
        modelBuilder.Entity<Student>().HasData(
            new { ID = 1, Name = "Lukas" },
            new { ID = 2, Name = "Mads" },
            new { ID = 3, Name = "Mike" }
        );
        // Initialize class data
        modelBuilder.Entity<Class>().HasData(
            new { ID = 1, Title = "Maths" },
            new { ID = 2, Title = "Physics" },
            new { ID = 3, Title = "Danish" }
        );
        // Initialize many-to-many relationship data between students and classes
        modelBuilder.Entity<Student>()
            .HasMany(s => s.Classes)
            .WithMany(c => c.Students)
            .UsingEntity(j => j.HasData(
                new { StudentsID = 1, ClassesID = 1 },
                new { StudentsID = 1, ClassesID = 2 },
                new { StudentsID = 2, ClassesID = 1 },
                new { StudentsID = 2, ClassesID = 3 },
                new { StudentsID = 3, ClassesID = 1 },
                new { StudentsID = 3, ClassesID = 2 },
                new { StudentsID = 3, ClassesID = 3 }
            ));
    }
}