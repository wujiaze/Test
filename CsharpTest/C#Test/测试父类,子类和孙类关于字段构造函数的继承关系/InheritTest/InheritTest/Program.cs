using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // 测试结果表明： new 一个孙类，执行顺序：孙类的所有字段，父类的所有字段，基类的所有字段，基类的构造函数，父类的构造函数，孙类的构造函数
            // 即一个 孙类对象，创建了一系列新的内存对象
            SonClass1 son1 = new SonClass1();
            SonClass2 son2 = new SonClass2();
            son1.AddList("1");
            son1.AddList("1");
            son2.AddList("1");
        }
    }
}
