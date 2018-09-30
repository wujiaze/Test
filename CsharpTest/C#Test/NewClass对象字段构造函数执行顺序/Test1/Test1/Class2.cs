using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Class2
    {
        public Class1 c1 = new Class1();
        public int x = 9;
        public int X {
            get { return x; }
            set { x = 11; }
        }

        public Class2()
        {
            x = 10;
        }
    }
}
