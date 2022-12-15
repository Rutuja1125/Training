using System;
internal class Program
{
   static void Pass_by_Value(int j)
    {
        Console.WriteLine(j); 
        j = 100;
        Console.WriteLine(j);
    }
    static void Main()
    {
        int i = 0;
        Pass_by_Value(i);
        Console.WriteLine("Value of i ="+i);
        Console.ReadKey();
        
    }
}

