namespace DataAccess.Repositories;

public static class Student
{
    public static DataTransfer.Student Get(int id)
    {
        using Contexts.School context = new();
        return Mappers.Student.Map(context.Students.Find(id));
    }

    public static ICollection<DataTransfer.Student> Get()
    {
        using Contexts.School context = new();
        return Mappers.Student.Map(context.Students.ToList());
    }

    public static void Add(DataTransfer.Student student)
    {
        using Contexts.School context = new();
        context.Students.Add(Mappers.Student.Map(student));
        context.SaveChanges();
    }

    public static void Update(DataTransfer.Student student)
    {
        using Contexts.School context = new();
        Models.Student dataStudent = context.Students.Find(student.ID);
        dataStudent.Name = student.Name;
        dataStudent.Enrollments = Mappers.Enrollment.Map(student);
        context.SaveChanges();
    }

    public static void Remove(DataTransfer.Student student)
    {
        using Contexts.School context = new();
        context.Students.Remove(Mappers.Student.Map(student));
        context.SaveChanges();
    }
}