using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrivate
{
    class Program
    {
        private int a = 0;

        public Program()
        {
            a = 0;
        }
        public int A
        {
            get { return a; }
        }

        public int b = 5;
        static void Main(string[] args)
        {
            /*  测试说明：子类的引用中包含父类的private成员的引用
             */
            SonProgram son = new SonProgram();
            Console.WriteLine(son.A);
            Console.WriteLine(son.b);
            Console.Read();

        }
    }

    class SonProgram : Program
    {
        public SonProgram()
        {
        }
    }
}
