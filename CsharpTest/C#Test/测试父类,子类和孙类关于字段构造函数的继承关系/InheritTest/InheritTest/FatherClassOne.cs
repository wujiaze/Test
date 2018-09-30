using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class FatherClassOne:BaseClass
    {
        public Dictionary<int,int> _dic = new Dictionary<int, int>();

        protected int x = 0;
        public FatherClassOne()
        {

        }
    }
}
