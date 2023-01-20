using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Demo_Ienumerable
{
    internal class Program
    {
        List<Demo> listname = new List<Demo>
            {
                new Demo { Id = 1 },
                new Demo { Id = 2 },
                new Demo { Id = 3 },
            };
        public  int GetDemos()
        {
            foreach(var n in listname) 
            { 
                return(n.Id); 
            }
            
        }

        public static void Main()
        {
            Program p = new Program();
            p.GetDemos();
            Console.ReadKey();
            //IEnumerable iname = from item in listname select item;
            //foreach (object n in iname)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.ReadKey();


        }
    }
    internal class Demo
    {
        public int Id { get; set; }
    }

}
