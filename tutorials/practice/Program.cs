using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class KHS
    {
        public int RollNo;
        public void Display(int roll)
        {
            this.RollNo = roll;
            Console.WriteLine("Displayed in base class "+this.RollNo);
        }
    }
    class Four : KHS
    {
        public void Show(int ID)
        {
            this.RollNo = ID;
            Console.WriteLine("Displayed in derievd classs" + this.RollNo);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //KHS k=new KHS();
            //k.Display(10);
            Four f4= new Four();
            f4.Display(4);
            f4.Show(14);
            Console.ReadLine();
        }
    }
}
