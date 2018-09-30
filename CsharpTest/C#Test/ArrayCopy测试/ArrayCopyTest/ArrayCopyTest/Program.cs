using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopyTest
{
    // 根据测试得知：任何数组都是引用类型，这个概念很重要
    class Program
    {
        private Byte mb;
        private UInt16 mu;
        private Byte[] mi;
        public Program(Byte b, UInt16 u, int i)
        {
            mb = b;
            mu = u;
            mi = new byte[i];
            for (int j = 0; j < i; j++)
            {
                mi[j] = (byte)'k';
            }
        }

        public int CountByte(Byte[] buffer)
        {
            Byte[] bb = new byte[1] { mb };
            Byte[] bu = BitConverter.GetBytes(mu);
            int i = 0;
            Array.Copy(bb, 0, buffer, i, bb.Length);
            i += bb.Length;
            Array.Copy(bu, 0, buffer, i, bu.Length);
            i += bu.Length;
            Array.Copy(mi, 0, buffer, i, mi.Length);
            i += mi.Length;
            return i;
        }

        public int fff(int xx)
        {
            xx = 10;
            return xx;
        }

        static void Main(string[] args)
        {
            Program pg = new Program(8, 18, 2);
            Byte[] bytes = new byte[2 + 3];
            int index = pg.CountByte(bytes);
            Console.WriteLine(index);
            for (int i = 0; i < bytes.Length; i++)
            {
                Console.WriteLine(bytes[i]);
            }
            int f = 5;
            int index2 = pg.fff(f);
            Console.WriteLine(f);
            Console.WriteLine(index2);
            Console.Read();
        }
    }
}
