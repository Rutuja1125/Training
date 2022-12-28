using System;
namespace Exception_Handling
{
    internal class Program
    {
        public static void Divide(int x,int y)
        {
            try
            {
                Console.WriteLine("Division  is = "+(x/y));
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("finally block of code ");
            }
        }
       
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter int x = ");
                int x = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("enter int y = ");
                int y = Convert.ToInt16(Console.ReadLine());
                Divide(x,y);
                Console.ReadKey();


            }
            catch 
            {
                Console.WriteLine("enter proper inputs");
                Console.ReadKey();
            }
           

        }
    }
}
