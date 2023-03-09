namespace DataTransfer;

public class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    
    public ICollection<Course> Courses { get; set; }

    public Student(int studentID, string name, ICollection<Course> courses)
    {
        StudentID = studentID;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Courses = courses;
    }

    public override string ToString()
    {
        return $"{StudentID}: {Name}";
    }
}