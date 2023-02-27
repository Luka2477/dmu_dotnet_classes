using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using task6.Models;

namespace task6.DAL;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<StudentClass> StudentClasses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=localhost,1433;Initial Catalog=dotnet_day08_task6;user=SA;password=Knudsen123!;TrustServerCertificate=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Student>().HasData(
            new { ID = 1, Name = "Lukas" },
            new { ID = 2, Name = "Mads" },
            new { ID = 3, Name = "Mike" }
        );
        modelBuilder.Entity<Class>().HasData(
            new { ID = 1, Title = "Maths" },
            new { ID = 2, Title = "Physics" },
            new { ID = 3, Title = "Danish" }
        );
        modelBuilder.Entity<StudentClass>().HasData(
            new { ID = 1, StudentID = 1, ClassID = 1 },
            new { ID = 2, StudentID = 1, ClassID = 2 },
            new { ID = 3, StudentID = 2, ClassID = 1 },
            new { ID = 4, StudentID = 2, ClassID = 3 },
            new { ID = 5, StudentID = 3, ClassID = 1 },
            new { ID = 6, StudentID = 3, ClassID = 2 },
            new { ID = 7, StudentID = 3, ClassID = 3 }
        );
    }
}