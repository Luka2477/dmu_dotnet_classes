namespace DataAccess.Models;

public class Course
{
    public int ID { get; set; }
    public string Title { get; set; }
    public virtual ICollection<Enrollment> Enrollments { get; }
}