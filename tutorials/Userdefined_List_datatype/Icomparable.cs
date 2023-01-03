using System;
using System.Collections.Generic;


namespace Userdefined_List_datatype
{
    public class Musician : IComparable<Musician> //Inherited for comparing complex type objects
    {
        int RollNo;
        string name;
        double fees;
        public Musician(int RollNo, string name, double fees)
        {
            this.RollNo = RollNo;
            this.name = name;
            this.fees = fees;
        }

        static void Main(string[] args)
        {
            Musician MS1 = new Musician(35, "ABC", 2000.00);
            Musician MS2 = new Musician(23, "DEF", 3000.00);
            Musician MS3 = new Musician(30, "GHI", 4000.00);

            List<Musician> Musicians = new List<Musician>() { MS1, MS2, MS3 };
            Compare cp = new Compare();

            Musicians.Sort(cp);
            //Musicians.Add();
            foreach (Musician element in Musicians)
            {
                Console.WriteLine(element.RollNo + " = " + element.name + " = " + element.fees);
            }
            Console.ReadKey();
        }

        public int CompareTo(Musician other)
        {
            if (RollNo > other.RollNo)
                return 1;
            else if (RollNo < other.RollNo)
                return -1;
            else
                return 0;
        }
        internal class Compare : IComparer<Musician>
        {
            int IComparer<Musician>.Compare(Musician x, Musician y)
            {
               if(x.fees < y.fees) 
                    return -1;
               else if(x.fees > y.fees)
                    return 1;
               else
                    return 0;
            }
        }
    }
    
}
