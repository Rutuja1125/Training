using System;

namespace overload_VS_overriding
{
    class ClassA
    {
        internal double Add(double a, double b)
        {
            return a + b;
        }
        public void  Add(int a,double b) //overloaded method Add in the same class
        {
            double sum = a+ b;
            Console.WriteLine("sum is = "+sum);
        }
        protected virtual void display()
        {
            Console.WriteLine("This method is in base class");
        }
       
    }
    internal class Program:ClassA
    {
        internal void Add(int a, int b,int c) //overloaded method Add in the diff  class
        {
            Console.WriteLine(a + b + c);
        }
        protected override void display() //override method in child class
        {
            Console.WriteLine("overriden method in child class");
        }
        internal new double Add(double a, double b)
        {
            return a + b;
        }
        static void Main()
        {
            Program p = new Program();
            p.Add(3, 5);
            p.display();
            Console.ReadKey();
        }
    }
}
