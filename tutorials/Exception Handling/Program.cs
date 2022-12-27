using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("Re-enter inputs ");
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
               

            }
            catch 
            {
                Console.WriteLine("enter proper inputs");
                Console.ReadKey();
            }
           

        }
    }
}
