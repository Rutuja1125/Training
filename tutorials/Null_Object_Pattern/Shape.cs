using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object_Pattern
{
    public class Shape : Ishape
    {
        public Shape() { }
        public abstract void Draw();
        
    }
}
