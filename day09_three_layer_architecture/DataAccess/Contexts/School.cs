using Microsoft.EntityFrameworkCore;
using Course = DataAccess.Mappers.Course;

namespace DataAccess.Contexts;

internal sealed class School : DbContext
{
    public School()
    {
        if (Database.EnsureCreated())
        {
            Console.WriteLine("Database created");
        }

        string connected = !Database.CanConnect() ? "not " : string.Empty;
        Console.WriteLine($"Database {connected}connected");
    }
    
    public DbSet<Models.Student> Students { get; set; }
    public DbSet<Models.Course> Courses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=localhost,1433;Initial Catalog=dmu_day09;user=SA;password=Knudsen123!;TrustServerCertificate=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Initialize many to many relationship
        // |
        modelBuilder.Entity<Models.Student>()
            .HasMany(s => s.Courses)
            .WithMany(c => c.Students)
            .UsingEntity<Models.Enrollment>(
                j => j
                    .HasOne(e => e.Course)
                    .WithMany(c => c.Enrollments)
                    .HasForeignKey(e => e.CourseID)
                    .OnDelete(DeleteBehavior.ClientCascade),
                j => j
                    .HasOne(e => e.Student)
                    .WithMany(s => s.Enrollments)
                    .HasForeignKey(e => e.StudentID)
                    .OnDelete(DeleteBehavior.ClientCascade),
                j =>
                {
                    j.HasKey(e => new { e.StudentID, e.CourseID });
                }
            );

        // Initialize student data
        // |
        modelBuilder.Entity<Models.Student>().HasData(
            new { StudentID = 1, Name = "Lukas" },
            new { StudentID = 2, Name = "Mads" },
            new { StudentID = 3, Name = "Mike" }
        );
        // Initialize course data
        modelBuilder.Entity<Models.Course>().HasData(
            new { CourseID = 1, Title = "Maths" },
            new { CourseID = 2, Title = "Physics" },
            new { CourseID = 3, Title = "Danish" }
        );
        // Initialize many-to-many relationship data between students and classes as enrollments
        modelBuilder.Entity<Models.Enrollment>().HasData(
            new { StudentID = 1, CourseID = 1 },
            new { StudentID = 1, CourseID = 2 },
            new { StudentID = 2, CourseID = 1 },
            new { StudentID = 2, CourseID = 3 },
            new { StudentID = 3, CourseID = 1 },
            new { StudentID = 3, CourseID = 2 },
            new { StudentID = 3, CourseID = 3 }
        );
    }
}