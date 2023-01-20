using System;

namespace ExtensionMethods
{
    public  class ClassTobeExtended
    {
        internal void Display()
        {
            Console.WriteLine("Hii,Yoour name is ABC");

        }
        internal void Display1()
        {
            Console.WriteLine("Your age is 25");
        }
        public static void Main()
        {
           ClassTobeExtended extend = new ClassTobeExtended();

            extend.ExtensionMethod1();
        }
    }
    
}
