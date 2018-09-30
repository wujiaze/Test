using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTcp粘包
{
    class Program
    {
        // 这就是 字符串流 的使用，本质是字节流。 这种方法的缺点是只能适用于简单的协议，不能对对象进行使用
        // 测试说明：解码时，是从头开始逐一解码，所以后面的缺失byte，不会影响整体的准确性
        // 即表示，不必知道数据的长度，直接采用 Encoding 方法解码，得到 定义的特殊符号，即表示得到设置的消息
        static void Main(string[] args)
        {
            byte[] b1 = Encoding.UTF8.GetBytes("model%1#");
            byte[] b2 = Encoding.UTF8.GetBytes("你还好啊");
            byte[] b3 = Encoding.UTF8.GetBytes("model%3#");
            byte[] b4 = Encoding.UTF8.GetBytes("model%4#");
            byte[] b5 = Encoding.UTF8.GetBytes("model%5#");
            byte[] b6 = Encoding.UTF8.GetBytes("complete#");
            byte[] b7 = Encoding.UTF8.GetBytes("map%1#");

            int lose = 1;

            byte[] temp = new byte[b1.Length + b2.Length - lose];
            Array.Copy(b1, temp, b1.Length);
            Array.Copy(b2, 0, temp, b1.Length, b2.Length - lose);
            string str = Encoding.UTF8.GetString(temp);
            Console.WriteLine(str);
            Console.Read();
        }
    }
}
