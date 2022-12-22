using System;
namespace overriding_vs_hiding
{
    internal class Program
    {
        public void Display()
        {
            Console.WriteLine("Simple display method in parent class");
        }
        public virtual void Override_method()
        {
            Console.WriteLine("Base class Method to be overriden ");
        }
    }
    internal class ClassA : Program
    {
        public new  void Display()
        {
            Console.WriteLine("Hiding is intended in child class");
        }
        public override void Override_method() 
        {
            Console.WriteLine("Overriden method in child class ");
        }
        static void Main()
        { 
            ClassA c = new ClassA();
            Program p = c;
            p.Display();
            p.Override_method();
            Console.ReadKey();
        }
    }
}
