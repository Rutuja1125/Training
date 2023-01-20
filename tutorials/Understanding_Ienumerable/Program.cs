using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_Ienumerable
{
    internal class Program
    {
        static void Main()
        {
            var Numbers = new int[] { 1, 2, 3, 4 };
            Numbers.GetEnumerator();
            foreach(int items in Numbers) 
            {
                Console.WriteLine(items);
            }
            Console.ReadKey();
        }
    }
}
