using System;
namespace ApplicationEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Odd no = ");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x % 2 == 0)
            {              
                throw new ApplicationException();
            }
            Console.ReadKey();
        }
    }
}
