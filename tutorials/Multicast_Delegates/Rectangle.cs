using System;


namespace Multicast_Delegates
{

    internal delegate void Rectangle_Delegate();
    internal class Rectangle
    {
        double Height;
        double Width;
        public Rectangle(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
        internal void Area()
        {
            Console.WriteLine("Area is = " + (this.Height * this.Width));
        }
        internal void Perimeter()
        {
            Console.WriteLine("Area is = " + 2 * (this.Height * this.Width));
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(22.44, 55.66);

            //instance of delegate
            //Area_Delegate AD = new Area_Delegate(rect.Area);
            //Perimeter_Delegate PD = new Perimeter_Delegate(rect.Perimeter);

            Rectangle_Delegate RD = new Rectangle_Delegate(rect.Area);

            //Calling method using another instance of delegate
            // Rectangle_Delegate RD1 = new Rectangle_Delegate(rect.Perimeter);

            RD += rect.Perimeter;

            //Calling a method using delegate instance
            RD();
            //RD1();


            Console.ReadKey();
        }
    }
}
