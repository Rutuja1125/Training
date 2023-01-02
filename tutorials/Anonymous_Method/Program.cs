using System;

namespace Anonymous_Method
{
    internal delegate void Greetrings(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            //Anonymous method
            //Greetrings greet = delegate (string name)
            //{
            //    Console.WriteLine("good Morning " + name);
            //};
            //greet("rutu");

            //Lambda 
            Greetrings greet1 = name => Console.WriteLine(name + "this is lambda Expression");
            greet1("XYZ ");
            Console.ReadKey();
        }
    }
}
