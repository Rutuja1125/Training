using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Area
    {
       public static double Pi = 3.142;
       public int value1 ;
       public int value2 ;
       public int value3 ;
        public void Result(int val1, int val2)
        {
            Console.WriteLine("the values are"+this.value1 +" "+this.value2);
        }
        public Area(int val1, int val2)
        {
            this.value1 = val1;
            this.value2 = val2;
        }
    }
    class Rect:Area
    {
        public Rect(int val1, int val2,int val3)
        {
            this.value1 = val1;      
            this.value2 = val2;
            this.value3 = val3;

        }

        public double Rect_area =0;
        public new void Result(int val, int val2)
        {
            double Recta_area = this.value1 * this.value2;
            Console.WriteLine("Area of Rect is " +Recta_area);
        }

    }
   
    
    internal class Program
    {
        static void Main()
        {
            Rect R = new Rect();
            R.Result(23, 45);
        }
    }
}
