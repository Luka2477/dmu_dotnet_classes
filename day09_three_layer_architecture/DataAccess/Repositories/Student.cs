using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public static class Student
{
    public static DataTransfer.Student Get(int id)
    {
        using Contexts.School context = new();
        return Mappers.Student.Map(context.Students.Include(s => s.Courses).Single(s => s.StudentID == id));
    }

    public static ICollection<DataTransfer.Student> Get()
    {
        using Contexts.School context = new();
        return Mappers.Student.Map(context.Students.Include(s => s.Courses).ToList());
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
        Models.Student dataStudent =
            context.Students.Include(s => s.Courses).Single(s => s.StudentID == student.StudentID);
        dataStudent.Name = student.Name;
        dataStudent.Courses = Mappers.Course.Map(student.Courses);
        context.SaveChanges();
    }

    public static void Remove(DataTransfer.Student student)
    {
        using Contexts.School context = new();
        context.Students.Remove(Mappers.Student.Map(student));
        context.SaveChanges();
    }
}