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
        static string[] SubMiss = { "A", "B", "C" };
        public int[] RollNo = { 1, 2, 3 };
        float fees = 15000F;

        //instance method
        public void Common()
        {
            for (int subject = 0; subject < SubMiss.Length; subject++)
            {
                Console.WriteLine("This School has " + SubMiss[subject] + " Subject");

            }
            Console.WriteLine("Basic fees = " + fees);
        }

    }
    public class Class1 : KHS
    {
        public int Totfees = 0;
        public void Students1(string[] Names1)
        {
            for (int i = 0; i < RollNo.Length; i++)
            {

                Console.WriteLine("{0} ,{1}", RollNo[i], Names1[i]);
            }

        }

    }

    internal class Program
    {
        static void Main()
        {
            KHS k = new KHS();
            k.Common();
            Class1 stu = new Class1();
            string[] Names1 = { "john", "Harry", "William" };
            stu.Students1(Names1);
            Console.ReadKey();
        }


    }
}
