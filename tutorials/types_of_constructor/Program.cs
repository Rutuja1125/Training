using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types_of_constructor
{
    internal class Program
    {
       
        int point_value; //class variable
        public Program(int para_1 /*local variables*/) //Parameterized constructor
        {
            this.point_value = para_1;
            Console.WriteLine("Parameterized constructor =" + para_1);
        }
        //public void Display()
        //{
           
        //    Console.WriteLine("Using parameterized constructor value  =" + this.point_value);
        //}

        static void Main()
        {
            Program p = new Program(29);
            Program p1 = new Program(30);

            //p.Display();

            Console.ReadKey();

        }
    }
}
