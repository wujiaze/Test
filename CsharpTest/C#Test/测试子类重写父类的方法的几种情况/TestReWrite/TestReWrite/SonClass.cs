using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestReWrite
{
    class SonClass:FatherClass
    {
        public new void Normal()
        {
            Console.WriteLine("SonClass 普通方法");
        }


        public override void TestVirtual()
        {
            Console.WriteLine("SonClass 中的 virtual 方法");
        }

        public override void TestAbstract()
        {
            Console.WriteLine("SonClass 中的 Abstract 方法");
        }

        public void OnlySon()
        {
            Console.WriteLine("Sonclass 独有的方法");
        }

        public  void Normal(string str)
        {
            Console.WriteLine("Sonclass Normal 重载 独有方法");
        }
    }
}
