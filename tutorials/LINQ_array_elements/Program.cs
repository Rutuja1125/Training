using System;
using System.Linq;

namespace LINQ_array_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Num = { 22, 45, 33, 90, 11, 76 };         
            //List<int> Final = new List<int>();
            //for(int index=0; index<Num.Length; index++)
            //{
            //    if (Num[index] > 20) 
            //        Final.Add(Num[index]);
            //}
            //Final.Sort();

            //foreach (int item in Final)
            //{
            //    Console.WriteLine(item);
            //}
           
            //Display all elements from array
            var Result = from items in Num select items;
            Console.WriteLine("Display all items from array");
            foreach(var item in Result) 
            {
                Console.WriteLine(item);
            }

            //items > 20
            Console.WriteLine("Display all items > 20 ");
            var Result1 = from items in Num where items > 20 select items;
            foreach (var item in Result1)
            {
                Console.WriteLine(item);
            }

            //items > 20 in ascending order
            Console.WriteLine("Display all items > 20 in ascending order ");
            var Result2 = from items in Num where items > 20 orderby items select items;
            foreach (var item in Result2)
            {
                Console.WriteLine(item);
            }

            //items > 20 in descending order
            Console.WriteLine("Display all items > 20 in descending order ");
            var Result3 = from items in Num where items > 20 orderby  items descending select items;
            foreach (var item in Result3)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
