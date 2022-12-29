using System;
namespace Muldi_dimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array2d = new int[3, 2]
            { { 2, 4 },
                       {6,8 },
                               {10,0 }};
            //nested for loop
            Console.WriteLine("array elements = ");
            for (int row=0;row < array2d.GetLength(0);row++) //first dimension length
            {
                for(int column =0; column < array2d.GetLength(1);column++) //2nd dimension length
                {
                    Console.WriteLine(array2d[row,column]);

                }
            }
            Console.ReadKey();
        }
    }
}
