using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Console.WriteLine("Enter a name");
            //string name = null;
        //    //Nullable<int> size = name.Length;
          int? size = null; //Another way of creating a nullable value type
           var result = size.HasValue ? size.Value : -1;

            //else
            //{
            //    Console.WriteLine("size of name is =" + size);
            //}
            //int? i = null;
            //int j;
            //if (i == null)
            //{
            //   j = default(int);

            //}
            //else
            //{
            //     j= i.Value;
            //}
            //Console.WriteLine(j);
#nullable 
            string msg = null;

            Console.WriteLine(msg);
            Console.ReadKey();





        }
    }
}
