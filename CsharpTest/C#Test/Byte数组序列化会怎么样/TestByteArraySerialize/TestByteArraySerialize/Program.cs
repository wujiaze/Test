using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TestByteArraySerialize
{
    // 测试说明：c#序列化 byte源数组 之后得到的byte数组，跟原数组是不一样的
    class Program
    {
        private static byte[] EnCodeObj(object value)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // c#序列化
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, value);
                // 二进制数组 
                byte[] valueBytes = new byte[ms.Length];
                Buffer.BlockCopy(ms.GetBuffer(), 0, valueBytes, 0, (int)ms.Length);
                return valueBytes;
            }
        }

        private static object DeCodeObj(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                BinaryFormatter bf = new BinaryFormatter();
                object value = bf.Deserialize(ms);
                return value;
            }
        }

        static void Main(string[] args)
        {
            byte[] source = new byte[]{1,2,3,4,5};
            byte[] destination = EnCodeObj(source);
            foreach (byte b in destination)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("------------------------------------");
            byte[] fina = DeCodeObj(destination) as byte[];
            foreach (byte b in fina)
            {
                Console.WriteLine(b);
            }
            Console.ReadLine();
        }
    }
}
