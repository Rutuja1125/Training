using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    internal class Program
    {
        public static void Add(int a,int b)
        {
            int Sum = a + b;
            Console.WriteLine("Addition is = " + Sum);
        }
        static void Main()
        {
            Add(2, 4);
            Console.ReadKey();
        }
    }
}
