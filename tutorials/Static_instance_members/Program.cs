using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_instance_members
{
    class Fourth
    {

        //static string History = "Tina";
        static string History;
        string eng;
        static Fourth()
        {
            Console.WriteLine("Static Constructor is called Once");
            Fourth.History = "tina";
        }
        // Constructor to use class field
        public Fourth(string Eng)
        {
            Console.WriteLine("Instance Constructor is called");
            this.eng = Eng;
        }
        //instance method
        public void SubMiss()
        {
            Console.WriteLine("Class Fourth History Miss = " + Fourth.History);
            Console.WriteLine("English Miss =" + eng);

        }

    }

    internal class Program
    {
        static void Main()
        {
            Fourth F4 = new Fourth("Rita");
            F4.SubMiss();
            Fourth Four = new Fourth("ABC");
            Four.SubMiss();
            Console.ReadKey();
        }


    }
}

