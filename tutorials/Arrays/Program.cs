using System;
using System.Linq;


namespace Arrays
{
    internal class Program
    {
        static void Addarray(int[] array)
        {
            for(int index=0; index<array.Length; index++)
            {
                array[index] = array[index] + 10;
            }
            Console.WriteLine("After Addition elements are = ");
            //foreach loop
            foreach(int item in array)
                Console.WriteLine(item);
        }
        static void Main()
        {
            int[] array = { 2, 4, 6, 8 };
            Console.WriteLine("Original array");
            foreach(int item in array)
            {
                Console.WriteLine(item);
            }
            Addarray(array);
            //using system.linq
            Console.WriteLine("Maximum element for array = " + array.Max());

            //using System.Array
            Console.WriteLine("Reversing the array = ");
            Array.Reverse(array);
            foreach(int item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
