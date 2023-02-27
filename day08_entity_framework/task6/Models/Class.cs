using System.Collections.ObjectModel;

namespace task6.Models;

public class Class
{
    public int ID { get; set; }
    public string Title { get; set; }
    
    public virtual ObservableCollection<Student> Students { get; }
}