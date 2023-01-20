using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Musician
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
            Musician MS1 = new Musician(35, "ABC", 4000.00);
            Musician MS2 = new Musician(23, "DEF", 3000.00);
            Musician MS3 = new Musician(30, "GHI", 5000.00);
            Musician MS4 = new Musician(31, "XYZ", 5000.00);
            // Console.WriteLine("column names are   ");
            Console.WriteLine("Display all the elements");

            Console.WriteLine("RollNo " + "  " + "Name " + " " + "Fees");
            List<Musician> Musicians = new List<Musician> { MS1, MS2, MS3 };
           // new Musician() { RollNo = 40, name = "JKI", fees = 6000 };

            // display all the elements
            var Result = from items in Musicians select items;

            foreach (var element in Result)
            {
                Console.WriteLine(element.RollNo + "      " + element.name + "     " + element.fees);

            }
            Console.WriteLine("---------------RollNo > 28---------");
            //where clause Rollno > 28

            var Result1 = from items in Musicians where items.RollNo > 28 select items;
            foreach (var element in Result1)
            {
                Console.WriteLine(element.RollNo + "      " + element.name + "     " + element.fees);

            }

            Console.WriteLine("---------------RollNo > 28 and fees > 2000---------");
            //where clause RollNo > 28 and fees > 2000

            var Result2 = from items in Musicians where items.RollNo > 28 && items.fees > 2000 select items;
            foreach (var element in Result2)
            {
                Console.WriteLine(element.RollNo + "      " + element.name + "     " + element.fees);

            }

            Console.WriteLine("-------------All the items in ascending order---------");
            //order by ascending 

            var Result3 = from items in Musicians orderby items.RollNo select items;
            foreach (var element in Result3)
            {
                Console.WriteLine(element.RollNo + "      " + element.name + "     " + element.fees);

            }

            Console.WriteLine("-------------All the items in descending order---------");
            //where clause for descending order

            var Result4 = from items in Musicians orderby items.RollNo descending select items;
            foreach (var element in Result4)
            {
                Console.WriteLine(element.RollNo + "      " + element.name + "     " + element.fees);

            }

            Console.WriteLine("-------------Items fees >2000 and in descending order---------");
           

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

            //changing name of a column and addding formula
            Console.WriteLine("-------------changing name of a column and adding formula ---------");
            var Result7 = from items in Musicians
                          select new
                          {
                              Musician_Fees = items.fees * 2,
                              Musician_Roll = items.RollNo
                          };
            foreach (var element in Result7)
            {
                Console.WriteLine(element);
            }

            //where clause to find all the related info by specifying value 
            Console.WriteLine("-------------specific item info ---------");
            var Result8 = from items in Musicians
                          where items.RollNo == 30
                          select items;
            foreach (var element in Result8)
            {
                Console.WriteLine(element.RollNo + "      " + element.name + "     " + element.fees);

            }
            Console.WriteLine("-------------fees =4000 ---------");
            var Result9 = from items in Musicians
                          where items.fees == 4000
                          select items;

            foreach (var element in Result9)
            {
                Console.WriteLine(element.RollNo + "      " + element.name + "     " + element.fees);

            }

            try
            {
                Console.WriteLine("-------------first item whose fees =5000 ---------");
                var Result10 = Musicians.First(items => items.fees == 5000);
                Console.WriteLine(Result10.RollNo + "  " + Result10.fees);

                Console.WriteLine("-------------first item whose fees > 5000 ---------");
                var Result11 = Musicians.FirstOrDefault(items => items.fees > 5000);
                if (Result11 == null)
                {
                    Console.WriteLine("Value is not present");
                }
                else
                {
                    Console.WriteLine(Result11.RollNo + "  " + Result11.fees);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Item satisfying the condition is not present");
            }

            Console.WriteLine("----------Contains method to check complex objects----------");
            var Result12 = (from items in Musicians
                            select items).Contains(MS1);
            Console.WriteLine(Result12);

            Console.WriteLine("----------Contains method to check complex objects----------");
            var comparer = new Musiciancomparer();
            Musician MS6 = new Musician(35, "ABC", 4000.00);
           //var search = 
           // var Result16 = (from items in Musicians
           //                 select items).Contains(MS6.R);

            Console.WriteLine("----------Count()----------");
            var Result13 = (from items in Musicians                        
                            select items.RollNo).Count();
            Console.WriteLine(Result13);

            Console.WriteLine("----------CountFiltered----------");
            var Result14 = (from items in Musicians
                            select items).Count(items => items.fees == 4000);
            Console.WriteLine(Result14);

            Console.WriteLine("----------Min()----------");
            var Result15 = (from items in Musicians
                            select items.RollNo).Min();
            Console.WriteLine(Result15);

            Console.WriteLine("----------Max()----------");
            var Result16 = (from items in Musicians
                            select items.fees).Max();
            Console.WriteLine(Result16);

            List<int> Numbers = new List<int> { 3, 6, 3, 4,1,5 };
            try
            {
                var rest1 = Numbers.First(item => item == 4);
                Console.WriteLine("-------------First()------------------");
                Console.WriteLine(rest1);

                var rest2 = Numbers.FirstOrDefault(item => item > 4);
                Console.WriteLine("-------------FirstOrDefault------------------");
                Console.WriteLine(rest2);

                var rest3 = Numbers.Last(item => item == 4);
                Console.WriteLine("-------------Last()------------------");
                Console.WriteLine(rest3);

                var rest4 = Numbers.LastOrDefault(item => item == 4);
                Console.WriteLine("-------------LastOrDefault()------------------");
                Console.WriteLine(rest4);

                var rest5 = Numbers.Single(item => item == 4);
                Console.WriteLine("-------------LastOrDefault()------------------");
                Console.WriteLine(rest4);

                var rest6 = (from items in Numbers
                            select items).Take(2);
                Console.WriteLine("-------------Take()------------------");
                foreach(var element in rest6)
                {
                    Console.WriteLine(element);
                }

                var rest7 = from items in Numbers
                            where items > 2
                            select items;
                Console.WriteLine("-------------items > 2------------------");
                foreach (var element in rest7)
                {
                    Console.WriteLine(element);
                }

                var rest8 = Numbers.TakeWhile(item => item > 2);
                Console.WriteLine("-------------items > 2 using take while------------------");
                foreach (var element in rest8)
                {
                    Console.WriteLine(element);
                }

                var rest9 = Numbers.Distinct();
                Console.WriteLine("-------------distinct items ------------------");
                foreach (var element in rest9)
                {
                    Console.WriteLine(element);
                }

                var rest10 = Numbers.All(items => items > 2);
                Console.WriteLine("-------------distinct items ------------------");
               Console.WriteLine(rest10);

                var rest11 = Numbers.Contains(3); //method format

                //Query syntax
                //var rest11 = (from items in Numbers
                //             select items).Contains(3);
                Console.WriteLine("-------------using contains------------------");
                Console.WriteLine(rest11);

                var rest12 = Numbers.Average();
                Console.WriteLine("-------------Average() ------------------");
                Console.WriteLine(rest12);               

                var rest13 = Numbers.Sum();
                Console.WriteLine("-------------Sum ------------------");
                Console.WriteLine(rest13);

                var rest14 = (from items in Numbers
                              select items).Aggregate(0, (final, item) => final += item * 3);
                Console.WriteLine("-------------Customized Average() ------------------");
               Console.WriteLine(rest14);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
        public class Musiciancomparer : EqualityComparer<Musician>
        {
            public override bool Equals(Musician x, Musician y)
            {
                return (x.RollNo == y.RollNo);
            }

            public override int GetHashCode(Musician obj)
            {
                return obj.RollNo.GetHashCode();    
            }
        }

    }
   
}
