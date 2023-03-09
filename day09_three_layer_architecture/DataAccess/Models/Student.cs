namespace DataAccess.Models;

internal class Student
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