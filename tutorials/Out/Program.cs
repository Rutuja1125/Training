using System;
internal class Program
{
    static void Out_parameter(int num1, int num2, out int sum, out int multi, out int div)
    {
        sum = num1 + num2;
        multi = num1 * num2;
        div = num1 / num2;
       
    }
    static void Main()
    {
        int total = 0;
        int product = 0;
        int divide = 0;
        Out_parameter(23, 33,out total,out product,out divide);
        Console.WriteLine("Addition is = {0} \n Multiplication is = {1} \n Division is = {2} " , total,product,divide);
        Console.ReadKey();
    }
}

