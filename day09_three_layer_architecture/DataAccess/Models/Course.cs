namespace DataAccess.Models;

internal class Course
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