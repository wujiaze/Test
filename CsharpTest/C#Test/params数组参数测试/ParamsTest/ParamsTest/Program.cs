using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsTest
{
    class Program
    {
        // 测试说明：params 参数可以是多个数组元素，也可以是整个数组
        // 另外注意：params 参数只能放在最后,且只有一个
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2, 3));
            int[] arr = new[] {1, 2, 3};
            Console.WriteLine(Add(arr));
            Console.Read();
        }
        public static int Add(params int[] arr)
        {
            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                x += arr[i];
            }
            return x;
        }
    }
}
