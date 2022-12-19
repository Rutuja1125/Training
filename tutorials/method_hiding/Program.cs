using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_hiding
{
    class KHS //Base class
    {
        public void Display() //Method hidden
        {
            Console.WriteLine("this is hidden base class method");
        }
    }
    class Fourth:KHS  //Derived Class (Child Class)
    {
        public new void Display()
        {
            Console.WriteLine("this is new  base class method called in child class");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Fourth f4= new Fourth();
            f4.Display();

            KHS k = new KHS();
            k.Display();
            Console.ReadKey();
        }
    }
}
