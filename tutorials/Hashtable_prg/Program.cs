using System;
using System.Collections;


namespace Hashtable_prg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable Marks = new Hashtable();
            Marks.Add("Eng", 100);
            Marks.Add("Hist", 80);
            Marks.Add("Maths", 700);
            //Console.WriteLine(Marks["Eng"]); //single value w.r.t key
            foreach(string key in Marks.Keys)
            {
                Console.WriteLine(key +" = " + Marks[key]);
            }

            Console.ReadKey();
        }
    }
}
