

using System;

namespace ByteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // 实验1：byte 和 Byte 是一样的，并且取值范围是 [0,255]
            Console.WriteLine("实验1");
            byte x = 255;
            Byte y = 255;
            bool isEquals = x.Equals(y);
            Console.WriteLine(isEquals);

            // 实验2 : UInt16是16位，所以即使数字很小，它还是占两个字节
            Console.WriteLine("实验2");
            UInt16 y1 = 15;
            Byte[] y_byte = BitConverter.GetBytes(y1);
            Console.WriteLine(y_byte.Length);
            for (int i = 0; i < y_byte.Length; i++)
            {
                Console.WriteLine(y_byte[i]);
            }

            // 实验3 : Byte 强制转换成 Uint16 时， Unit16 是16位，即使是8位的Byte赋值给Uint16，还是2个字节

            Console.WriteLine("实验3");
            Byte x2 = 255;
            UInt16 y2 = x2;
            Byte[] y2_byte = BitConverter.GetBytes(y2);
            Console.WriteLine(y2_byte.Length);
            for (int i = 0; i < y2_byte.Length; i++)
            {
                Console.WriteLine(y2_byte[i]);
            }

            // 实验4 : 当Uint16 强制转换成 Byte 时的两种情况，还是1个字节
            Console.WriteLine("实验4.1");
            UInt16 y3 = 100;
            Byte x3 = (Byte)y3;
            Console.WriteLine("x3" + x3);  // Uint16 小于255时， x3=100 ,是byte类型
            Console.WriteLine("实验4.2");
            UInt16 y4 = 256;
            Byte x4 = (Byte)y4;
            Console.WriteLine("x4" + x4);  // Uint16 大于255时，x4 =1 ，是byte类型

            int u = -0;
            ushort p = (ushort)u;
            Console.WriteLine(p);

            // 实验5 :Uint16 的258 相当于 0000 0001 0000 0010 转换到byte[] 就是一个 0000 0001 ，一个0000 0010 即打印出来是1,2  Byte[0]= 2 ,Byte[1]=1,低位在前，高位在后
            Console.WriteLine("实验5");
            UInt16 po = 258;
            Byte[] ll = BitConverter.GetBytes(po);
            Console.WriteLine("ll.Length" + ll.Length);
            for (int i = 0; i < ll.Length; i++)
            {
                Console.WriteLine(ll[i]);
            }
            Console.Read();


        }
    }
}
