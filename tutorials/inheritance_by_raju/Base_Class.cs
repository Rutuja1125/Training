using System;


namespace inheritance_by_raju
{
    internal class Base_Class
    {
        internal double salary;
        public Base_Class(int sal) 
        {
            this.salary = sal;
            Console.WriteLine("This is base class having salary = " + this.salary);
        }
        //internal void Bunglow()
        //{
        //    Console.WriteLine("This is base class bunglow");
        //}
        //protected void Factory()
        //{
        //    Console.WriteLine("This is base class factory ");
        //}
        ////static void Main()
        ////{
        ////    Base_Class bc= new Base_Class();
        ////    //bc.Job(); //cannot be called either public or internal
        ////}
    }
}
