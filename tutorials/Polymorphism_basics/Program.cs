using System;
using System.ComponentModel;

namespace Polymorphism_basics
{
    class KHS
    {
        public virtual void Display()
        {
            Console.WriteLine("This is Display method of Base class method");
        }
    }
    class Fourth : KHS
    {
        public void Show()
        {
            Console.WriteLine("This is show method of child class");
        }
        public new void Display() //Hide base method
        {
            Console.WriteLine("This is Display method of fourth class method.We have used new Keyword");
        }

    }
    class Fifth : KHS
    {
        public  override void Display() //Hide base method
        {
            Console.WriteLine("This is Display method of fifth class method");
        }

    }
    internal class Program
    {
        static void Main()
        {
            KHS k= new Fourth();
            k.Display();

            KHS k1 = new Fifth();
            k1.Display();

            Fourth f4 = new Fourth();
            f4.Display();



            Console.ReadKey();
        }
    }
}
