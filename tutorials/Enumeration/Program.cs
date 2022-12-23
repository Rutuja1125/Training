using System;
namespace Enumeration
{
    public enum Audit_Course
    {
         Software_Testing=1,
        Cloud_computing,
        Cyber_security
    }
   
    internal class Program
    {
        //internal static Audit_Course Choose_Course
        //{ get; set; } = Audit_Course.Cyber_security;


        static void Main(string[] args)
        {
            Audit_Course ac = Audit_Course.Cyber_security;
            Audit_Course ac1 = (Audit_Course)1; //way of declaring enum
            Console.WriteLine("Audit course "+(int)ac +"= " + ac); //integer value of enum element

            Console.WriteLine("Audit course 1 = " + ac1);//value representation of enum
            Console.ReadKey();
        }
    }
}
