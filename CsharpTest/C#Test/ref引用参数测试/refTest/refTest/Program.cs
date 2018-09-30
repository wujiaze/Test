using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refTest
{
    class Program
    {
        public struct MyStruct
        {
            public int x;
            public int y;
            public MyStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public class MyClass
        {
            public int x;

            public MyClass(int x)
            {
                this.x = x;
            }
        }

        public static void IntRef(int value)    // 用Int 来表示基础类型
        {
            value++;
        }
        public static void IntRef(ref int value)
        {
            value++;
        }

        public static void StructRef(MyStruct value) // 自定义的结构体
        {
            value.x++;
            value.y++;
        }
        public static void StructRef(ref MyStruct value)
        {
            value.x++;
            value.y++;
        }
        public static void ClassRef(MyClass value) // 自定义的类
        {
            value.x++;
        }
        public static void ClassRef(ref MyClass value)
        {
            value.x++;
        }
        public static void Class2Ref(List<int> value)   // 引用类型
        {
            value = new List<int>();
            value.Add(1);
        }
        public static void Class2Ref(ref List<int> value)   // 引用类型
        {
            value = new List<int>();
            value.Add(1);
        }

        static void Main(string[] args)
        {
            // Int测试说明：ref 参数可以使 值类型具有引用类型的特性
            // 测试1
            int x = 0;
            IntRef(x);
            Console.WriteLine(x);
            // 测试2
            int y = 0;
            IntRef(ref y);
            Console.WriteLine(y);

            // Struct测试说明：ref 参数可以 使结构体具有引用类型的特性
            MyStruct ms1 = new MyStruct(0, 0);
            StructRef(ms1);
            Console.WriteLine("x: " + ms1.x + "y: " + ms1.y);
            MyStruct ms2 = new MyStruct(0, 0);
            StructRef(ref ms2);
            Console.WriteLine("x: " + ms2.x + "y: " + ms2.y);

            // Class第一种测试说明: 有无 ref 参数，对于引用类型，效果是一样的
            MyClass mc1 = new MyClass(0);
            ClassRef(mc1);
            Console.WriteLine(mc1.x);
            MyClass mc2 = new MyClass(0);
            ClassRef(ref mc2);
            Console.WriteLine(mc2.x);

            // Calss第二种测试说明：
            // 结合第一种测试可知，引用类型可以修改引用指向的内存数据
            // 但是，无法修改方法外的引用类型原来的引用
            // 此时，可以通过 ref 参数来实现，这是 ref 第二种作用
            List<int> intList1 = new List<int>();
            intList1.Add(0);
            Class2Ref(intList1);
            Console.WriteLine("list1: " + intList1[0]);

            List<int> intList2 = new List<int>();
            intList2.Add(0);
            Class2Ref(ref intList2);
            Console.WriteLine("list2: " + intList2[0]);


            Console.WriteLine("----------------");
            Dictionary<int, int> _idct = new Dictionary<int, int>();
            _idct.Add(0, 0);
            _idct[0]++;
            Console.WriteLine(_idct[0]);

            Console.WriteLine("----------------");
            List<byte> byelist = new List<byte>();
            byelist.Add(10); byelist.Add(11); byelist.Add(12);
            Class2Ref(byelist);
            Console.WriteLine(byelist[0]);

            Console.WriteLine("-----------");
            int ap = 10;
            Class2Ref(ap);
            Console.WriteLine(ap);
            Class2Ref(ref ap);
            Console.WriteLine(ap);

            Console.WriteLine("---------------");
            int[] ss = new int[] { 1, 2, 3 };
            Class2Ref(ss);
            Console.WriteLine(ss[0]);
            Class2Ref(ref ss);
            Console.WriteLine(ss[0]);

            Console.ReadLine();
        }
        public static void Class2Ref(List<byte> value)
        {
            value.Clear();
            value.Add(15);
        }
        public static void Class2Ref(int value)
        {
            value = 15;
        }
        public static void Class2Ref(ref int value)
        {
            value = 15;
        }
        public static void Class2Ref(int[] value)
        {
            value = new int[] { 12 };
        }
        public static void Class2Ref(ref int[] value)
        {
            value = new int[] { 12 };
        }
    }

}
