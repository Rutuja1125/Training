using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading
{
    internal class Program
    {
        int a, b;
        public Program(int a1, int b1)
        {
            this.a = a1;
            this.b = b1;
        }
        public static Program operator +(Program obj1, Program obj2)
        {
            Program obj = new Program(obj1.a + obj2.a, obj1.b + obj2.b);
            return obj;
        }
    }
    public class class1
    {
        static void Main(string[] args)
        {
            Program p = new Program(23, 55);
            Program p1 = new Program(32, 54);
            Program p2 = p + p1;
            Console.ReadKey();

        }

    }
           
        
    
}
