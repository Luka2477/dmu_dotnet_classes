using System;
namespace task6
{
    public class MyList
    {
        private List<int> _numbers;

        public MyList()
        {
            _numbers = new List<int>();
        }

        public List<int> Numbers
        {
            get { return _numbers; }
        }

        public void Add(int number)
        {
            _numbers.Add(number);
        }

        public void PrintNumbers()
        {
            foreach (int number in _numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

