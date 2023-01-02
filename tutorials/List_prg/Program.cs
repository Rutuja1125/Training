using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_prg
{
    internal class Program
    {
        static void Main()
        {
            List<int> even = new List<int>();
            even.Add(2);
            even.Add(4);
            even.Insert(2, 6);
            foreach(int item in even) 
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    
        
    
}
