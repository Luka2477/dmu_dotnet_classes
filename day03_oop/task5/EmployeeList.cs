using System;
namespace task5
{
    public class EmployeeList<TKey> where TKey : notnull
    {
        private readonly Dictionary<TKey, Employee> _dict;

        public EmployeeList() => _dict = new Dictionary<TKey, Employee>();

        public void AddElement(TKey key, Employee val)
        {
            if (_dict.ContainsKey(key)) return;

            _dict.Add(key, val);
        }

        public Employee GetElement(TKey key)
        {
            return _dict[key];
        }

        public int Size()
        {
            return _dict.Keys.Count;
        }
    }
}

