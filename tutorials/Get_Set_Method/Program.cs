using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set_Method
{
    class Properties
    {
        private int Id;
        private string Name;
        public string Username;
        public int Idcheck //If output msg to be printed
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id > 0");
                }
                this.Id = value;

            }
            get
            {
                return this.Id;
            }
        }
        public string nm
        {
            set { this.Name = value; }
            get { return this.Name; }
        }
        
        public void Display(int Id,string Name)
        {
            Console.WriteLine("This is " + Name + " with Roll NO " + Id);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Properties p = new Properties();
            p.Display(1, "Rita");
            Console.ReadKey();

        }
    }
}
