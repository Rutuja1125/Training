using System;

namespace Introduction_to_Class
{
    class Fourth
    { 
        //Class field
        string History ="Tina";
        string eng ;
        //Default values to class field
        //public Fourth() : this("Tina","Rita")
        //    {
        //    }
       // Constructor to use class field
        public Fourth(string Hist ,string Eng) 
        {
            this.History = Hist; 
            this.eng= Eng;
        }
        //static method
        public static void FourthData(int RollNo,string name)
        {
            Console.WriteLine("Name =" +name +" RollNo = "+RollNo);
        }
        //Class Method that uses class field which is a instance method
        public void SubMiss()
        {
            Console.WriteLine("Class Fourth History Miss = "+this.History);
            Console.WriteLine("English Miss =" + eng);

        }

    }
    
    internal class Program
    {
        static void Main()
        {
            
           Fourth.FourthData(22, "A");
            Fourth.FourthData(23, "B");
            Fourth.FourthData(24, "C");
            Fourth F4 = new Fourth("Tina","Rita");           
            F4.SubMiss();
            Console.ReadKey();
        }
        
    }
}