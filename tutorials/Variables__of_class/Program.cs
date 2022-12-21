using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables__of_class
{
    class Program
    {
        static int st; 
        const float pi = 3.142f; //conatnat value
        readonly string pwd ;
        string Non_static;//class variable
        static Program() //static constructor
        {
            Console.WriteLine("this is static constructor");
        }
        public Program(string pswd,string non_static)//non-static constructor 
        {
            this.pwd = pswd;
           this.Non_static = non_static;
        }
        
        static void Main()
        {
            Console.WriteLine(23); //values to static variable
            Console.WriteLine(pi);
            Program p= new Program("XYz","i am non static class variable");
           
           Console.WriteLine(p.pwd);
            Console.WriteLine(p.Non_static);

            Console.ReadKey();
        }

    }
    
}
