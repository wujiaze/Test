using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class BaseClass
    {
        private List<string> _baseList = new List<string>();
        internal string str = "44";

        public BaseClass()
        {

        }

        public void AddList(string str)
        {
            if(_baseList.Contains(str))
                return;
            _baseList.Add(str);
        }
    }
}
