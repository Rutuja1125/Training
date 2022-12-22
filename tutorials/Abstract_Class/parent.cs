using System;


namespace Abstract_Class
{
    public abstract class parent
    {
        static int home;
        public abstract void Greet();
        protected void Property(int home)
        {
            Console.WriteLine("Homes to be inherited = " + home);
        }
    }
    public class Child1:parent
    {
        public override void Greet()
        {
            Console.WriteLine("Good Morning");
        }
        static void Main() 
        {
            Child1 c1 = new Child1();
            c1.Greet(); //abstrct method method must be implemented first
            c1.Property(2);
            parent p=c1;//parent class variable
            p.Greet();
            Console.ReadKey();
        }
    }
}
