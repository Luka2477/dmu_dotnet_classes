namespace DataAccess.Repositories;

public static class Course
{
    public static DataTransfer.Course Get(int id)
    {
        using Contexts.School context = new();
        return Mappers.Course.Map(context.Courses.Find(id));
    }

    public static ICollection<DataTransfer.Course> Get()
    {
        using Contexts.School context = new();
        return Mappers.Course.Map(context.Courses.ToList());
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
        Models.Course dataCourse = context.Courses.Find(course.ID);
        dataCourse.Title = course.Title;
        dataCourse.Enrollments = Mappers.Enrollment.Map(course);
        context.SaveChanges();
    }

    public static void Remove(DataTransfer.Course course)
    {
        using Contexts.School context = new();
        Models.Course dataCourse = context.Courses.Find(course.ID);
        context.Courses.Remove(dataCourse);
        context.SaveChanges();
    }
}