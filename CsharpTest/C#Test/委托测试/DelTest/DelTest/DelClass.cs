using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelTest
{
    public class DelClass
    {
        public delegate bool MyDel(int num, uint id);

        public static void MyMed(MyDel mydel,uint p)
        {
            mydel(1,2);

        }
    }
}
