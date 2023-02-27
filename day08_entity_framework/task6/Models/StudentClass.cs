namespace task6.Models;

public class StudentClass
{
    public int StudentID { get; set; }
    public virtual Student Student { get; set; }
    
    public int ClassID { get; set; }
    public virtual Class Class { get; set; }
}