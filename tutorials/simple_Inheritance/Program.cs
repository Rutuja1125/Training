using System;


namespace simple_Inheritance
{
    class KHS  //base class
    {
        public KHS()
        {
            Console.WriteLine("This is base Class Constructor");
        }
        public KHS(string input)
        {
            Console.WriteLine(input);
        }
    }
    class Fourth : KHS //Single Inheritance
    {
        public Fourth() 
        {
            Console.WriteLine("This is Child class constructor");

        }
        public Fourth(int level) : base("Overloaded base class constructor called in child class constructor")
        {
            Console.WriteLine("This is "+level+"class  in multi level inheritance");
        }
    }
    class Fifth : Fourth
    {
        public Fifth():base(2)
        {
            Console.WriteLine("This is multi level class constructor");
        }
    }
    internal class Program
    {
        static void Main()
        {
            //KHS k= new KHS("Overloaded constructor of base class");
            //Fourth F4 = new Fourth();
            Fifth F5= new Fifth();
            Console.ReadKey();
        }
    }
}
