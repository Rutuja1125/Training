using System;
internal class Reference
{
    static void Pass_by_Ref(ref int j)
    {
        Console.WriteLine(j);
        j = 100;
        Console.WriteLine(j);
    }
    static void Main()
    {
        int i = 0;
        Pass_by_Ref(ref i);
        Console.WriteLine("Value of i =" + i);
        Console.ReadKey();

    }
}
