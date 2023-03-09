using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts;

internal class School : DbContext
{
    public DbSet<Models.Student> Students { get; set; }
    public DbSet<Models.Course> Courses { get; set; }
    public DbSet<Models.Enrollment> Enrollments { get; set; }

    public School()
    {
        if (Database.EnsureCreated())
        {
            Console.WriteLine("Database created");
        }

        string connected = Database.CanConnect() ? "not " : string.Empty;
        Console.WriteLine($"Database {connected}connected");
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=localhost,1433;Initial Catalog=dotnet_day08_task6;user=SA;password=Knudsen123!;TrustServerCertificate=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Initialize student data
        modelBuilder.Entity<Models.Student>().HasData(
            new { ID = 1, Name = "Lukas" },
            new { ID = 2, Name = "Mads" },
            new { ID = 3, Name = "Mike" }
        );
        // Initialize course data
        modelBuilder.Entity<Models.Course>().HasData(
            new { ID = 1, Title = "Maths" },
            new { ID = 2, Title = "Physics" },
            new { ID = 3, Title = "Danish" }
        );
        // Initialize many-to-many relationship data between students and classes as enrollments
        modelBuilder.Entity<Models.Enrollment>().HasData(
            new { ID = 1, StudentID = 1, CourseID = 1 },
            new { ID = 2, StudentID = 1, CourseID = 2 },
            new { ID = 3, StudentID = 2, CourseID = 1 },
            new { ID = 4, StudentID = 2, CourseID = 3 },
            new { ID = 5, StudentID = 3, CourseID = 1 },
            new { ID = 6, StudentID = 3, CourseID = 2 },
            new { ID = 7, StudentID = 3, CourseID = 3 }
        );
    }
}