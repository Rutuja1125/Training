using System;


namespace Figure_abstract_application
{
    public abstract class Figures
    {
        public double Height, Width, Radius;
        public const double Pi = 3.142;

        internal abstract void Area();
        
    }
    public class Rect : Figures
    {
        public Rect(double Height, double Width)
        {
            this.Width = Width;
            this.Height = Height;
        }
        internal override void Area()
        {
            Console.WriteLine("Area of rect is = " + (this.Width * this.Height));
        }
        
    }

    public class Circle : Figures
    {
        public Circle(double radius)
        {
            this.Radius = radius;
          
        }
        internal override void Area()
        {
            Console.WriteLine("Area of Circle is = " + (Pi * this.Radius * this.Radius));
        }
        
    }
    class access
    {
        static void Main()
        {
            Rect r = new Rect(12.33, 44.55);
            r.Area();
            Circle c = new Circle(13);
            c.Area();
            Console.ReadKey();
        }
    }
    



}
