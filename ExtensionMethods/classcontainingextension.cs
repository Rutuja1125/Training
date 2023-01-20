using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class classcontainingextension
    {
        public static void ExtensionMethod1(this ClassTobeExtended extend)
        {
            Console.WriteLine("This is Extension method 1");
        }
    }
    public class DeclareClass
    {
        public static void Main()
        {
            ClassTobeExtended extend = new ClassTobeExtended();
            extend.ExtensionMethod1();
        }
    }

}
