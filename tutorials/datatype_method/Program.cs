using System;
internal class Program
{
    public string Greet(string name)
    {
        return "Hello" + name;
    }

    static void Main(string[] args)
    {

        Console.WriteLine("Enter your name = ");
        string name = Console.ReadLine();
        Program p2 = new Program();
        Console.WriteLine(p2.Greet(name));
        Console.ReadKey();

    }
}

