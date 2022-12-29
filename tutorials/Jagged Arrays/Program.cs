using System;
namespace Jagged_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged1d = new int[2][] {
                               new int [3]{2,4,6},
                               new int [4]{8,10,12,14} };

            //another way of declaring jagged array
            //int[][] jagged1d = new int[2][];
            //jagged1d[0] = new int[3] { 1, 5, 7 };
            //jagged1d[1] = new int[4] { 2, 4, 6, 8 };

            //Accessing elements
            for(int no_of_array =0; no_of_array  < jagged1d.Length; no_of_array++)
            {
                for(int items=0;items < jagged1d[no_of_array].Length; items++)
                {
                    Console.WriteLine(jagged1d[no_of_array][items]);
                }
            }
            Console.ReadKey();
        }
    }
}
