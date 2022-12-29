using System;

namespace indexers
{
    internal class Employee
    {
        //indexers are used to access class vlauefrom outside the class
        //class will act as an virtual array
        int empid;
        string empname;
        public Employee(int empid, string empname)
        {
            this.empid = empid;
            this.empname = empname;
        }
        internal void Display()
        {
            Console.WriteLine("Employee class method");
        }
        internal object this[int index]
        {
            get
            {
                if (index == 0)
                    return empid;
                return null;

            }
            set
            {
                if (index == 0)
                    empid = (int)value;
            }
        }
    }
}
