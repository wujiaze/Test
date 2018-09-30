using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newObject
{
    class Program
    {
        private List<bool> boolList = new List<bool>();

        public Program()
        {
            Console.WriteLine(boolList==null);
            Console.WriteLine(boolList2 == null);
        }

        private static List<bool> boolList2 = new List<bool>();
        public static void MO()
        {
            Console.WriteLine(boolList2 == null);
        }

        //  测试说明： 字段实例化自身，会在构造函数之前
        //            静态字段随着类的加载而加载，也在构造函数之前
        static void Main(string[] args)
        {
            Program p1 = new Program();
            //Program.MO();
            Console.ReadLine();
        }
    }
}
