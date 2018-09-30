using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorTest
{
    class Program
    {
        // 补码：负数的时候使用 ,符号位不变，其余位取反+1
        // sbyte 中 0000 0000 为0 ，1000 0000 为-128
        static void Main(string[] args)
        {
            // 位非运算符 ~
            // 实验1:12 ：0000 1100 正数直接取反 1111 0011 
            // 负数还需要求补码：电路设计的要求 。首位不变，其余求反再加1,1000 1100>1000 1101 结果为-13
            sbyte y = 12;
            sbyte a;
            a = (sbyte)~y;
            Console.WriteLine(a);

            // 实验2：-25：1001 1001 负数补码再取反，取反 1110 0110 加1：1110 0111 ，补码再全部取反： 0001 1000 得24
            sbyte x = -25;
            a = (sbyte)~x;
            Console.WriteLine(a);


            // 移位运算符 右移>> 首位是1是，增加的都是1
            // 实验1 ：66： 0100 0010  右移 0000 1000 =8
            sbyte i = 66;
            sbyte p = (sbyte)(i >> 3);
            Console.WriteLine(p);

            // 实验2  -1 ：1000 0001 
            // 由于是负数，采用补码计算
            // -1的补码 ： 1111 1111  右移3位 又因为是负数，增加的位都是1 所以结果是 1111 1111 
            // 之后计算 1111 1111 是谁的补码，就可以得到-1右移3位的值了
            // 很明显 1111 1111 的补码就是 -1 ，所以结果是-1
            sbyte k = -1;
            p = (sbyte)(k >> 3);
            Console.WriteLine(p);

            // 实验3： -60 :1011 1100  补码 1100 0100 右移 1111 1000
            // 计算 1111 1000是谁的补码   先-1 ：1111 0111 再取反 1000 1000 为-8
            sbyte u = -60;
            p = (sbyte)(u >> 3);
            Console.WriteLine(p);

            // 实验4 ：-128 : 1000 0000  比较特殊直接移动：右移3位就是 0001 0000 结果为-16
            sbyte q = -128;
            p = (sbyte)(q >> 3);
            Console.WriteLine(p);

            // 移位运算符  左移 <<
            // 实验1 ：66： 0100 0010  左移 0001 0000 =16
            sbyte w = 66;
            p = (sbyte)(w << 3);
            Console.WriteLine(p);

            // 实验2：-1 : 1000 0001 补码 1111 1111 左移 1111 1000
            // 计算1111 1000是谁的补码： 1111 0111 结果 1000 1000 为-8
            sbyte e = -1;
            p = (sbyte)(e << 3);
            Console.WriteLine(p);

            // 实验3： -60 :1011 1100  补码 1100 0100 左移 0010 0000 左移之后不是负数，所以直接计算的32
            sbyte r = -60;
            p = (sbyte)(r << 3);
            Console.WriteLine(p);

            // 实验4 ：-128 : 1000 0000  比较特殊，直接移动：左移3位 0000 0000 为 0
            sbyte t = -128;
            p = (sbyte)(t << 3);
            Console.WriteLine(p);
            Console.Read();
        }
    }
}
