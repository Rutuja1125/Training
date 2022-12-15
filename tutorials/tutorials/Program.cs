using System;


internal class Program
{
    //Void method
    public void EvenNumbers(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("Even No :");
            for (int i = 0; i <= number; i += 2)
            {

                Console.Write(i + " ");
            }

        }
        else
        {
            Console.WriteLine("Enter number greater than 0");
        }

    }
    //static Method
    public static void OddNumbers(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("\n Odd No:");
            for (int i = 1; i <= number; i += 2)
            {

                Console.Write(i + " ");
            }

        }
        else
        {
            Console.WriteLine("Enter number greater than 0");
        }


    }
    static void Main()
    {
        Console.WriteLine("Enter the Number = ");
        int Number = Convert.ToInt16(Console.ReadLine());
        Program p1 = new Program();
        p1.EvenNumbers(Number);
        OddNumbers(Number);
        Console.ReadKey();


    }
}

