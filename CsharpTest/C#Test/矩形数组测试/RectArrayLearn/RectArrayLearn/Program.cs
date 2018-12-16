using System;

namespace RectArrayLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intArr1 = new int[2, 3] { { 10, 1, 8 }, { 12, 3, 8 } };
            Console.WriteLine(intArr1.Rank);    //矩形数组的秩
            for (int i = 0; i < intArr1.Rank; i++)
            {
                Console.WriteLine(intArr1.GetLength(i));//每一个维度(秩)的长度

            }
            Console.WriteLine(intArr1.Length);  // 整个矩形数组的长度

            // 只有2维
            for (int j = 0; j < intArr1.GetLength(0); j++)
            {
                for (int k = 0; k < intArr1.GetLength(1); k++)
                {
                    Console.WriteLine(intArr1[j, k]);
                }
            }
            Console.Read();
        }
    }
}
