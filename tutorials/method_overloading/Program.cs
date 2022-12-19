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
        public static void Add(int a, int b,int c) //overloading with different no of parameters
        {
            int Sum = a + b +c;
            Console.WriteLine("Addition is = " + Sum);
        }

        public static void Add(int a, float b) //overloading with different no of parameters
        {
            float Sum = a + b ;
            Console.WriteLine("Addition is = " + Sum);
        }
        static void Main()
        {
            Add(2, 4);
            Add(2, 4,6);
            Add(2, 4.567F);
            Console.ReadKey();
        }
    }
}
