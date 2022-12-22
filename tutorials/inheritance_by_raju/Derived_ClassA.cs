using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_by_raju
{
    internal class Derived_ClassA : Base_Class
    {
        internal int Child_slary;
        public Derived_ClassA(int Child_salary) : base(3000)
        {
            this.Child_slary = Child_salary;
            Console.WriteLine("Child class salary = "+this.Child_slary);
        }
        static void Main()
        {            
            Derived_ClassA A = new Derived_ClassA(6000);
            Console.ReadKey();
        }
    }
}
