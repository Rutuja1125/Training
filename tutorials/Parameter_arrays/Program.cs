using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_arrays
{
    internal class Program
    {
 
        public static void ParameterArrays(params int[] Even)
        {
            for(int index =0;index < Even.Length;index++)
            {
                Console.WriteLine("Element at index "+index+" = "+Even[index]);
            }
        }
        static void Main()
        {
            //int[] Even = { 2, 4, 6, 8 };
            //ParameterArrays(Even);
            //Console.WriteLine("Enter the size of array = ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] Even= new int[size];
            //for (int index = 0; index < size; index++)
            //{
            //    Even[index] =Convert.ToInt16(Console.ReadLine());
            //}
            ParameterArrays(2,4,6);
            Console.ReadKey();
        }
    }
}
