using System;

namespace Implementation_of_interface
{
    internal interface Interface1  //parent Interface 
    {
        void Area(double height, double width);
        
    }
    internal interface Circumference/*:Interface1*/ //Child interface
    {
        void Circum(double radius);
    }
    class figure: Interface1,Circumference //Multiple inheritance can be implemented in interface
    {
        const double Pi = 3.142;
        public void Area(double height, double width)
        {
            Console.WriteLine("area of Rect is = " + (height * width));
        }
        public void Circum(double radius)
        {
            Console.WriteLine("area os circle = " + (Pi * radius * radius));
        }
        static void Main()
        {
            figure r = new figure();
            r.Area(33.55, 22.5);
            r.Circum(4);
            Console.ReadKey();
        }
    }
}
