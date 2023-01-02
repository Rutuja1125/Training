using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_Prg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,object> Student = new Dictionary<int,object>();
            Student.Add(21, "A");
            Student.Add(22, "B");
            Student.Add(23, "C");
            foreach(int key in Student.Keys) 
            {
                Console.WriteLine(key +" = " + Student[key]);
            }
            Console.ReadKey();
        }
    }
}
