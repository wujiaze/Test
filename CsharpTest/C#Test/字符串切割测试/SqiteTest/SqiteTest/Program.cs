using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // 测试表明：
            // 1、切割字符串时，若是最后一位，则还是切割成2个字符串，最后一个是空字符串(不是null)
            string str1 = "aaaa#11";
            string[] strArr1 = str1.Split('#');
            Console.WriteLine("strArr1.Length: "+ strArr1.Length);
            for (int i = 0; i < strArr1.Length; i++)
            {
                Console.WriteLine(i + "  ： " + strArr1[i]);
            }
            string str2 = "bbbb#";
            string[] strArr2 = str2.Split('#');
            Console.WriteLine("strArr2.Length: "+ strArr2.Length);
            for (int i = 0; i < strArr2.Length; i++)
            {
                Console.WriteLine(i + ":"+ strArr2[i]);
            }


            // StringSplitOptions.RemoveEmptyEntries :表示去除空字符串  默认是 StringSplitOptions.None
            string str3 = "cccc#";
            char[] temp1 = new[] { '#' };
            string[] strArr3 = str3.Split(temp1, 2, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("strArr3.Length: " + strArr3.Length);
            for (int i = 0; i < strArr3.Length; i++)
            {
                Console.WriteLine( i + "  ： " + strArr3[i]);
            }
            string str4 = "dddd#";
            char[] temp2 = new[] { '#' };
            string[] strArr4 = str4.Split(temp2, 2, StringSplitOptions.None);
            Console.WriteLine("strArr4.Length: " + strArr4.Length);
            for (int i = 0; i < strArr4.Length; i++)
            {
                Console.WriteLine(i + "  ： " + strArr4[i]);
            }

            // 指定数量：则从头开始计算
            string str5 = "eeee#ffff#gggg#hhhh#";
            char[] temp3 = new[] { '#' };
            string[] strArr5 = str5.Split(temp3, 2);
            Console.WriteLine("strArr5.Length: " + strArr5.Length);
            for (int i = 0; i < strArr5.Length; i++)
            {
                Console.WriteLine(i + "  ： " + strArr5[i]);
            }

            Console.WriteLine("--------st6---------");
            string str6 = "sef33";
            string[] strArr6 = str6.Split('%');
            for (int i = 0; i < strArr6.Length; i++)
            {
                Console.WriteLine(i + "  ： " + strArr6[i]);
            }

            Console.WriteLine("-------str7-----");
            string str8 = String.Empty;
            string[] strArr8 = str8.Split('%');
            // 测试表明：null是无法被切割的
            string str7 = null;
            string[] strArr7 = str7.Split('%');
           
            Console.ReadLine();
        }
    } 
}
