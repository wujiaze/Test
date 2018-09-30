using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestReWrite
{
    class FatherClass:MotherClass
    {
        /* 普通方法 */
        public void Normal()
        {
            Console.WriteLine("FatherClass  普通方法");
        }

        /* 虚方法 */
        public virtual void TestVirtual()
        {
            Console.WriteLine("FatherClass 中的 virtual 方法");
        }
        /* 抽象方法 */
        public override void TestAbstract()
        {
            Console.WriteLine("FatherClass 中的 抽象方法");
        }
    }
}
