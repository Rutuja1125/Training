using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Musician
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
            //Objects of Musician type
            Musician MS1 = new Musician(35, "ABC", 2000.00);
            Musician MS2 = new Musician(23, "DEF", 3000.00);
            Musician MS3 = new Musician(30, "GHI", 4000.00);

            List<Musician> Musicians = new List<Musician>() { MS1, MS2, MS3 };
           // Console.WriteLine("column names are   ");
            Console.WriteLine("Display all the elements");

            Console.WriteLine("RollNo " + "  " + "Name " + " " + "Fees");

            //display all the elements
            var Result = from items in Musicians select items;
            // List  = Musicians.Select(items => items.ToString()).ToList();

            foreach (var element in Result) 
            {
                Console.WriteLine(element.RollNo + "      " + element.name + "     " + element.fees);

            }
            Console.WriteLine("---------------RollNo > 28---------");
            //where clause
            
            var Result1  = from items in Musicians where items.RollNo > 28 select items;
            foreach (var element in Result1)
            {
                Console.WriteLine(element.RollNo + "      " + element.name + "     " + element.fees);

            }

            Console.WriteLine("---------------RollNo > 28 and fees > 2000---------");
            //where clause

            var Result2 = from items in Musicians where items.RollNo > 28 && items.fees > 2000 select items;
            foreach (var element in Result2)
            {
                Console.WriteLine(element.RollNo + "      " + element.name + "     " + element.fees);

            }

            Console.WriteLine("-------------All the items in ascending order---------");
            //where clause

            var Result3 = from items in Musicians orderby items.RollNo select items;
            foreach (var element in Result3)
            {
                Console.WriteLine(element.RollNo + "      " + element.name + "     " + element.fees);

            }

            Console.WriteLine("-------------All the items in descending order---------");
            //where clause

            var Result4 = from items in Musicians orderby items.RollNo descending select items;
            foreach (var element in Result4)
            {
                Console.WriteLine(element.RollNo + "      " + element.name + "     " + element.fees);

            }

            Console.WriteLine("-------------Items fees >2000 and in descending order---------");
            //where clause

            var Result5 = from items in Musicians where items.fees > 2000 orderby items.RollNo descending select items;
            foreach (var element in Result5)
            {
                Console.WriteLine(element.RollNo + "      " + element.name + "     " + element.fees);

            }

            //Selecting a single column
            Console.WriteLine("-------------Selecting a names column---------");

            var Result6 = from items in Musicians select items.name;
            foreach (var element in Result6)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("-------------Selecting a names column using new keyword and adding formula ---------");
            var Result7 = from items in Musicians
                          select new
                          {
                              Musician_Fees= items.fees * 2,
                              Musician_Roll =items.RollNo
                          };
            foreach (var element in Result7)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
