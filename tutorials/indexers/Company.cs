using System;

namespace indexers
{
    internal class Company
    {
        static void Main()
        {
            Employee emp = new Employee(1001,"rita");
            emp[0] = 2000; //override class field, ssetting value using indexer.
            Console.WriteLine(emp[0]);
            Console.WriteLine(emp[1]);
            emp.Display();
            Console.ReadKey();
        }
    }
}
