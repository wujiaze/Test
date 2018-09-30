using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 测试表明：创建类的实例时，先执行字段，再执行构造函数(不执行属性和方法)
            Class2 c2 = new Class2();
            Class2 c3 = new Class2();
            Console.WriteLine(c2.c1.Equals(c3.c1));
            Console.WriteLine(c2.x);
            Console.WriteLine("11111");
            Console.ReadLine();
        }
    }
}
