using System;
namespace task6
{
	public class EmployeeList<TKey> where TKey : notnull
	{
		private readonly Dictionary<TKey, IHasAddress> _dict;

		public EmployeeList() => _dict = new Dictionary<TKey, IHasAddress>();

		public void AddElement(TKey key, IHasAddress val)
		{
			if (_dict.ContainsKey(key)) return;

			_dict.Add(key, val);
		}

		public IHasAddress GetElement(TKey key)
		{
			return _dict[key];
		}

		public int Size()
		{
			return _dict.Keys.Count;
		}

		public override string ToString()
		{
			var keys = _dict.Keys;
			var vals = _dict.Values;
			string result = "";

			for (int i = 0; i < Size(); i++)
			{
				result += $"({keys.ElementAt(i)}, {vals.ElementAt(i)})\n";
			}

			return result;
		}
	}
}

