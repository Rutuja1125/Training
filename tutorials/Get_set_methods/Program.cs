using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Get_set_methods
{
    internal class Program
    {
        double Radius = 33.00;

        //public double ReadValue()
        //{
        //    return Radius;
        //}
        //public void SetValue(double radius)
        //{
        //    Radius = radius;
        //}
        public double RadiusProperty
        {
            get
            { return Radius; }
            set
            {
                Radius = value;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //double print_radius = p.ReadValue();//Get method-->Readonly method
            //Console.Write("Readonly value of radius = " + print_radius);
            //p.SetValue(22);
            p.RadiusProperty = 55.88;//setting the value-->writing 
            double print_radius = p.RadiusProperty;//Get method-->Readonly method
            Console.Write("Readonly value of radius = " + print_radius);
            Console.ReadKey();
        }
    }
}
