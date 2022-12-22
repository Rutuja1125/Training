using System;
namespace Implementation_of_interface
{
    struct Demo
    {
        int val1;
        public void Display(int val)
        {
            Console.WriteLine("This is struct having int i = " + i);
        }
        static void Main()
        {
            Demo demo = new Demo();
            demo.val1 = 10;
            demo.Display(demo.val1);
        }
    }
}
