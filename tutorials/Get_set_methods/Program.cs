using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Get_set_methods
{
    internal class Program
    {
        double Current_score = 33.00;

        //public double ReadValue()
        //{
        //    return Radius;
        //}
        //public void SetValue(double radius)
        //{
        //    Radius = radius;
        //}
        public double ScoreProperty
        {
            get
            { return Current_score; }
            set
            {
                if(Current_score < value)
                //{
                //    Console.WriteLine("sorry,Your score is noty highest score!!");
                //}
                Current_score = value;
                
               
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //double print_radius = p.ReadValue();//Get method-->Readonly method
            //Console.Write("Readonly value of radius = " + print_radius);
            //p.SetValue(22);
            p.ScoreProperty = 10;//setting the value-->writing 
            double print_radius = p.ScoreProperty;//Get method-->Readonly method
            Console.Write("Highest score is  " + p.Current_score);
            Console.ReadKey();
        }
    }
}
