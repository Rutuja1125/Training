using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    internal class Program
    {
        private string[] Data=new string[5];

        //indexers
        public string this[int index] //Accessed using instance of class
        {
            get //Readonly access
            { return Data[index]; }
            set //Writing values
            {
                Data[index] = value;
            }
        }
        static void Main()
        {
            Program p= new Program();
            p[0] = "ABC";
            p[1] = "DEF";
            p[2] = "GHI";
            for (int i=0; i<5;i++)
            {
                Console.WriteLine(p[i]);
            }
                   Console.ReadKey();
        }
    }
}
