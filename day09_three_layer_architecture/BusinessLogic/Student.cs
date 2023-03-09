namespace BusinessLogic;

public static class Student
{
    public static DataTransfer.Student Get(int id)
    {
        return DataAccess.Repositories.Student.Get(id);
    }

    public static ICollection<DataTransfer.Student> Get()
    {
        return DataAccess.Repositories.Student.Get();
    }

    public static void Add(DataTransfer.Student student)
    {
        DataAccess.Repositories.Student.Add(student);
    }

    public static void Update(DataTransfer.Student student)
    {
        DataAccess.Repositories.Student.Update(student);
    }

    public static void Remove(DataTransfer.Student student)
    {
        DataAccess.Repositories.Student.Remove(student);
    }
}