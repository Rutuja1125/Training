using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    internal class Program
    {
        internal class Gen_Class
        {
            int Id;
            string name;
            public Gen_Class(int id, string name)
            {
                Id = id;
                this.name = name;
            }

            static void Main()
            {
                Gen_Class GC1 = new Gen_Class(22, "ABC");
                Gen_Class GC2 = new Gen_Class(23, "XYZ");

                List<Gen_Class> Class_List= new List<Gen_Class>() { GC1, GC2 };
                //Class_List.Add(GC1);
                //Class_List.Add(GC2);
                foreach(Gen_Class obj in Class_List)
                {
                    Console.WriteLine(obj.Id);

                }
                Console.ReadKey();
            }
        }
    }

}
