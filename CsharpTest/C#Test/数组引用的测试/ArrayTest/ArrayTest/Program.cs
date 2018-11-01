using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes = new byte[] { 100 };
            ChangeByte(bytes);
            Console.WriteLine(bytes[0]);
            Console.Read();
        }

        private static void ChangeByte(byte[] bytes)
        {
            bytes[0] = 10;
        }
    }
}
