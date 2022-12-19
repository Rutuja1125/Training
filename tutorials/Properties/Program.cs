using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Properties
    {
        private int CId;
        public void SetId(int CId)
        {
            this.CId = CId;
            Console.WriteLine( CId <= 0 ? "kindly enter Class Id greater than 0" : "CId is " + CId);
            //    if (CId <= 0)
            //{
            //    Console.WriteLine("kindly enter Class Id greater than 0");
            //}
            //else
            //{
            //    Console.WriteLine("CId is " + CId);
            //}

        }

    }
    internal class Program
    {
  
        public static void  check(int MId)
        {
           Console.WriteLine( MId <= 0? "kindly enter Method Id greater than 0": "MId is " + MId);
            //if(MId <= 0)
            //{
            //    Console.WriteLine("kindly enter Method Id greater than 0");
            //}
            //else
            //{
            //    Console.WriteLine("MId is " + MId);
            //}
        }
            
        static void Main()
        {
            Console.WriteLine("Enter Id = ");
            int MId =Convert.ToInt16(Console.ReadLine());
            check(MId);

            Console.WriteLine("Enter Id = ");
            int CId = Convert.ToInt16(Console.ReadLine());
            Properties prop = new Properties();
            prop.SetId(CId);
            //Console.WriteLine(prop.GetId());
            Console.ReadKey();
        }
    }
}
