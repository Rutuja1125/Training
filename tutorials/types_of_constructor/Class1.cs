using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types_of_constructor
{

    internal class Class1
    {
        public void Test1()
        {
            Console.WriteLine("Public access Specifier");
        }
        private void Test2()
        {
            Console.WriteLine("private access Specifier");
        }
        protected void Test3()
        {
            Console.WriteLine("Protected access Specifier");
        }
        internal void Test4()
        {
            Console.WriteLine("internal access Specifier");
        }
        protected internal void Test5() 
        {
            Console.WriteLine("protected internal access Specifier");
        }
     
        class Class2 :Class1
        {

        }
        static void Main()
        {
            Class1 c1 = new Class1();
            c1.Test5();//protected internal
            c1.Test1();//public
            c1.Test4();//internal

            Class2 cl2= new Class2();
            cl2.Test2();
        }
    }
    
}
