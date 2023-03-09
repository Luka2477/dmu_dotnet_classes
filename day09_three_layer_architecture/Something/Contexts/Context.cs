using Microsoft.EntityFrameworkCore;

namespace Something.Contexts;

public sealed class Context : DbContext
{
    public Context()
    {
        if (Database.EnsureCreated())
        {
            Console.WriteLine("Database created");
        }

        string connected = !Database.CanConnect() ? "not " : string.Empty;
        Console.WriteLine($"Database {connected}connected");
    }
    
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=localhost,1433;Initial Catalog=Something_DB;user=SA;password=Knudsen123!;TrustServerCertificate=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Initialize many to many relationship
        // |
        modelBuilder.Entity<Student>()
            .HasMany(s => s.Courses)
            .WithMany(c => c.Students)
            .UsingEntity<Enrollment>(
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
        modelBuilder.Entity<Student>().HasData(
            new { StudentID = 1, Name = "Lukas" },
            new { StudentID = 2, Name = "Mads" },
            new { StudentID = 3, Name = "Mike" }
        );
        // Initialize course data
        modelBuilder.Entity<Course>().HasData(
            new { CourseID = 1, Title = "Maths" },
            new { CourseID = 2, Title = "Physics" },
            new { CourseID = 3, Title = "Danish" }
        );
        // Initialize many-to-many relationship data between students and classes as enrollments
        modelBuilder.Entity<Enrollment>().HasData(
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

public class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    
    public ICollection<Course> Courses { get; set; }
    public List<Enrollment> Enrollments { get; set; }

    public override string ToString()
    {
        return $"{StudentID}: {Name}";
    }
}

public class Course
{
    public int CourseID { get; set; }
    public string Title { get; set; }
    
    public ICollection<Student> Students { get; set; }
    public List<Enrollment> Enrollments { get; set; }

    public override string ToString()
    {
        return $"{CourseID}: {Title}";
    }
}

public class Enrollment
{
    public int StudentID { get; set; }
    public Student Student { get; set; }
    
    public int CourseID { get; set; }
    public Course Course { get; set; }
}