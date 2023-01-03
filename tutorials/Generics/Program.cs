using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program<T>
    {
        //static void Int_Method(int val1, int val2)
        //{
        //    if (val1 == val2)
        //        Console.WriteLine("Both values are equal");
        //    else
        //        Console.WriteLine("both values are not equal");
        //}
        //static void Object_Method(object val1, object val2)
        //{
        //    if (val1 == val2)
        //        Console.WriteLine("Both values are equal");
        //    else
        //        Console.WriteLine("both values are not equal");
        //}
        internal void Generic_Method(T val1, T val2)
        {
            if (val1.Equals(val2))  //== opeartor is not supported 
                Console.WriteLine("Both values are equal");
            else
                Console.WriteLine("both values are not equal");
        }
        static void Main()
        {
            Program<int> obj1 = new Program<int>();
            //Int_Method(22, 33);
            //    Object_Method(33, 33.00);
            //obj1.Generic_Method(22, 44);
            Console.ReadKey();
        }
    }
}
