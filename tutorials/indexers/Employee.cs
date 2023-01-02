using System;

namespace indexers
{
    internal class Employee
    {
        //indexers are used to access class fields from outside the class
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
            get  //read value of a class field 
            {
                if (index == 0)
                    return empid;
                else if(index == 1)
                    return empname;
                return null;

            }
            set //set value of a class field
            {
                if (index == 0)
                    empid = (int)value;
                else if(index ==1)
                    empname = (string)value;
            }
        }
    }
}
