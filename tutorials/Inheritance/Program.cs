using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class KHS
    {
        //public string[] names;
       public string[] names;
        public string firstname;
        //static string[] SubMiss = { "A", "B", "C" };
        //public int[] RollNo = { 1, 2, 3 };
        float fees = 15000F;

        //instance method
        //public void Common()
        //{
        //    //for (int subject = 0; subject < SubMiss.Length; subject++)
        //    //{
        //    //    Console.WriteLine("This School has " + SubMiss[subject] + " Subject");

        //    //}
        //    //Console.WriteLine("Basic fees = " + fees);
        //}
        public void display(string[] names)
        {
            foreach(string nm in names)
            {
                Console.WriteLine(nm);
            }
        }

    }
    public class Class1 : KHS
    {
        //public int Totfees = 0;
        //public void Students1(string[] Names1)
        //{
        //    for (int i = 0; i < RollNo.Length; i++)
        //    {

        //        Console.WriteLine("{0} ,{1}", RollNo[i], Names1[i]);
        //    }

        //}
       

    }
    public class Class2 : Class1
    {
        public new void display(string[] names)
        {
            for (int i=0;i < names.Length;i++)
            {
                Console.WriteLine("Item at index "+i+" = " + names[i]);
            }
        }

    }

    internal class Program
    {
        static void Main()
        {
            //    KHS k = new KHS();
            //    k.Common();
            //    Class1 stu = new Class1();
            //    string[] Names1 = { "john", "Harry", "William" };
            //    stu.Students1(Names1);
            //KHS K = new KHS();
            string[] names = { "ABc", "DEF" };
            //K.display(names);
            //K.display(names);
            Class2 c2 = new Class2();
            c2.display(names);
            Console.ReadKey();
        }


    }
}
