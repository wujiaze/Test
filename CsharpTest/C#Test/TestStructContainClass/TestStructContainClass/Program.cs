using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStructContainClass
{
    public struct MyStruct
    {
        public int x;
        public Program p1;

        public MyStruct(int x, Program p1)
        {
            this.x = x;
            this.p1 = p1;
        }
    }
    /* 测试说明： 结构体中的引用类型，始终指向同一个堆内存*/
    public class Program
    {
        public int IsOK;

        static void Main(string[] args)
        {
            Program p = new Program(){IsOK = 1};
            MyStruct s1 = new MyStruct(10,p);

            p.Test(s1);
            Console.WriteLine(p.IsOK);
            Console.Read();
        }

        public void Test(MyStruct myStruct)
        {
            myStruct.p1.IsOK = 5;
        }
    }
}
