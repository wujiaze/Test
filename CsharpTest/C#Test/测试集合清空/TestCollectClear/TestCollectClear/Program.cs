using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollectClear
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idList = new List<int>();
            idList.Add(1);
            idList.Add(2);
            idList.Add(3);
            List<int> nextlist = new List<int>();
            foreach (int i in idList)
            {
                nextlist.Add(i);
            }
            idList.Clear();
            foreach (int i in nextlist)
            {
                Console.WriteLine(i);
            }

            List<Program> pList = new List<Program>();
            pList.Add(new Program());
            List<Program> newxtPlist = pList;
            pList.Clear();                              // 测试说明：要保存Clear之前的数据，不能通过赋值 原列表的引用，需要重新建立list内部的对象引用
            foreach (Program program in newxtPlist)
            {
                Console.WriteLine(program);
            }

            List<int> sortList = new List<int>();
            sortList.Add(8);
            sortList.Add(1);
            sortList.Sort(MySort);
            foreach (int i in sortList)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }

        private static int MySort(int x, int y)
        {
            if (x > y)
                return 1;
            else
                return -1;
        }
    }
}
