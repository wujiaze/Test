using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestNewList
{
    class Program
    {
        public Dictionary<string,string> s =new Dictionary<string, string>();

        static void Main(string[] args)
        {
            // 测试1：说明这种方式也可以给字典添加值，并且可以修改值
            Program pp =new Program();
            Console.WriteLine(pp.s.Count);
            pp.s["1"] = "2";
            Console.WriteLine(pp.s.Count);
            Console.WriteLine(pp.s["1"]);
            pp.s["1"] = "5";
            Console.WriteLine(pp.s["1"]);
            Console.WriteLine("-------------------------------------");
            // 测试说明：new List<string>(list1) 这种方式是完全开辟了一块新的空间，新内存跟原内存 除了内容相同，引用完全不同，是一种深度复制
            List<string> list1 =new List<string>();
            list1.Add("1");
            Console.WriteLine("list1  " + list1[0]);
            List<string> list2 =new List<string>(list1);
            list2[0] = "3";
            Console.WriteLine("list2  " + list2[0]);
            Console.WriteLine("list1  "+list1[0]);
            Console.ReadLine();
        }
    }
}
