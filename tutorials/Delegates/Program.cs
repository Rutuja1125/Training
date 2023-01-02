using System;

namespace Delegates
{ //step 1 : creating delegates
    internal delegate void Instance_Delegate();
    internal delegate void Add_Delegate(int val1,double val2);

    delegate void Static_Delegate();

    internal class Program
    {
        internal void Instance()
        {
            Console.WriteLine("This is instance method");
        }
        internal void Add(int val1,double val2)
        {
            Console.WriteLine("Addition is = "+(val1 +val2));
        }

        static void Static_Method()
        {
            Console.WriteLine("This is static method");
        }
        static void Main(string[] args)
        {
             Program p= new Program();
            // p.Instance();
            // //Two ways of calling static method.
            // Non_Static(); 
            //Program.Non_Static();


            //step 2 :Instantiating a delegate

            Instance_Delegate ID = new Instance_Delegate(p.Instance);
            Add_Delegate AD = new Add_Delegate(p.Add);
            Static_Delegate SD = new Static_Delegate(Static_Method);

            //step 3:Calling a method using delegate instance

            ID();
            AD(22, 44.33);
            SD();
            Console.ReadKey();
        }
    }
}
