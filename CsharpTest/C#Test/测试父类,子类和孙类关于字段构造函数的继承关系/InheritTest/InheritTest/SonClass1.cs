using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class SonClass1:FatherClassOne
    {
        public Dictionary<int,int> _dic = new Dictionary<int, int>();

        public SonClass1()
        {
        }
    }
}
