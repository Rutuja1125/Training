using System;
using System.Collections;


namespace arraylist_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList alobj = new ArrayList();
            alobj.Add("Rita");
            alobj.Add(22);
            alobj.Insert(0, 33);
            alobj.Insert(3, 33);
            alobj.Add("Neena");
            Console.WriteLine("Capacity of alobj = "+alobj.Capacity);
            alobj.Remove(33); //removes the first appeared element
            Console.WriteLine("Capacity of alobj = " + alobj.Capacity);

            foreach (var item in alobj)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
