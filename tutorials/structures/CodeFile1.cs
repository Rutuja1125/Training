using System;
namespace structures
{
    struct Demo  //structures are value type
    {
        int val2;
      
        public void Display(int val1)
        {
            Console.WriteLine("This is struct having int i = " + val1);
        }
        public void struct_value()
        {
            Console.WriteLine("val2 = " + val2);
        }
        static void Main()
        {
            Demo demo = new Demo();
            demo.Display(10);
            demo.val2 = 100;
            demo.struct_value();
            Console.ReadKey();
        }
    }
}

