using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public static class Course
{
    public static DataTransfer.Course Get(int id)
    {
        using Contexts.School context = new();
        return Mappers.Course.Map(context.Courses.Include(c => c.Students).Single(c => c.CourseID == id));
    }

    public static ICollection<DataTransfer.Course> Get()
    {
        using Contexts.School context = new();
        return Mappers.Course.Map(context.Courses.Include(c => c.Students).ToList());
    }

    public static void Add(DataTransfer.Course course)
    {
        using Contexts.School context = new();
        context.Courses.Add(Mappers.Course.Map(course));
        context.SaveChanges();
    }

    public static void Update(DataTransfer.Course course)
    {
        using Contexts.School context = new();
        Models.Course dataCourse = context.Courses.Include(c => c.Students).Single(c => c.CourseID == course.CourseID);
        dataCourse.Title = course.Title;
        dataCourse.Students = Mappers.Student.Map(course.Students);
        context.SaveChanges();
    }

    public static void Remove(DataTransfer.Course course)
    {
        using Contexts.School context = new();
        context.Courses.Remove(Mappers.Course.Map(course));
        context.SaveChanges();
    }
}