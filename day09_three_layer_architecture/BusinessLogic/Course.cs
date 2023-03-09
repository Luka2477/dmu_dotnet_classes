namespace BusinessLogic;

public static class Course
{
    public static DataTransfer.Course Get(int id) => DataAccess.Repositories.Course.Get(id);
    public static ICollection<DataTransfer.Course> Get() => DataAccess.Repositories.Course.Get();
    public static void Add(DataTransfer.Course course) => DataAccess.Repositories.Course.Add(course);
    public static void Update(DataTransfer.Course course) => DataAccess.Repositories.Course.Update(course);
    public static void Remove(DataTransfer.Course course) => DataAccess.Repositories.Course.Remove(course);
}