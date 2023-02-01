using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace given
{
    internal class TryParse
    {
        static void Main(string[] args)
        {
            String tekstAtParse = "3x2";
            bool virkedeDet = int.TryParse(tekstAtParse, out int result);
            Console.WriteLine("Virkede det? " + virkedeDet);
            if (virkedeDet)
            {
                Console.WriteLine("Resultat: " + result);
            }
            Console.ReadLine();
        }
    }
}
