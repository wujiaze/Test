using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承测试
{
    class GrandSonClass:SonClass
    {
        public SonClass son = new SonClass();
        GrandSonClass ss = new GrandSonClass();
        public void Test()
        {
            // 父类中的 Protected 方法只能  由继承类在继承类中使用，父类也不能在继承类中使用
            ss.Fa();
            son.Fa();
        }
    }
}
