using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    internal class Company
    {
        static void Main()
        {
            Employee emp = new Employee(1001,"rita");
            emp[0] = 2000;
            Console.WriteLine(emp[0]);
            emp.Display();
            Console.ReadKey();
        }
    }
}
