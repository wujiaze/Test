using System;  

/*
 *  总结：
 *  多维数组：遍历，推荐使用foreach
 *           一定要使用for时，需要知道每一维的长度
 *  交错数组：遍历，foreach 和 for 都可以
 */
namespace RectArrayLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            // 矩形数组
            int[,] intArr1 = new int[2, 3]  // 2行3列多维数组
            {
                 { 10, 1, 8 },
                 { 12, 3, 8 }
            };
            Console.WriteLine("数组的维度： " + intArr1.Rank);    //矩形数组的秩/行数/维度
            for (int i = 0; i < intArr1.Rank; i++)
            {
                Console.WriteLine("维度" + i + "的长度： " + intArr1.GetLength(i));//每一个维度(秩)的长度
            }
            Console.WriteLine("数组整体的长度： " + intArr1.Length);  // 整个矩形数组的长度

            /* 多维数组的遍历 */
            // 方法1
            foreach (int i in intArr1)
            {
                Console.WriteLine("遍历： " + i);
            }
            // 方法2
            for (int j = 0; j < intArr1.GetLength(0); j++)
            {
                for (int k = 0; k < intArr1.GetLength(1); k++)
                {
                    Console.WriteLine(intArr1[j, k]);
                }
            }

            Console.WriteLine("交错数组");
            // 交错数组:一个数组的元素都是数组
            int[][] intArr2 = new int[3][]
            {
                new int[]  { 1,2,3},
                new int[]  { 4,5},
                new int[]  { 6,7,8,9}
            };
            foreach (int[] ints in intArr2)
            {
                foreach (int i in ints)
                {
                    Console.WriteLine("1交错数组遍历： " + i);
                }
            }

            for (int i = 0; i < intArr2.Length; i++)
            {
                for (int j = 0; j < intArr2[i].Length; j++)
                {
                    Console.WriteLine("2交错数组遍历： " + intArr2[i][j]);
                }
            }

            Console.WriteLine("交错和多维");
            /*交错和多维*/
            int[][,] intArr3 = new int[3][,]// 一维数组，每个元素是 多维数组
            {
                new int[2,3]{{1,2,3},{4,5,6}},
                new int[3,2]{{7,8},{9,10},{11,12}},
                new int[1,4]{{13,14,15,16}},
            };
            for (int i = 0; i < intArr3.Length; i++)
            {
                foreach (int i1 in intArr3[i])
                {
                    Console.WriteLine("交错和多维1 遍历： "+ i1);
                }
            }

            int[,][] intArray4 = new int[3, 2][]// 多维数组，每个元素是一维数组
            {
                {new int[1]{1},new int[2]{2,3}},
                {new int[3]{4,5,6},new int[4]{7,8,9,10}},
                {new int[2]{11,12},new int[1]{13}}
            };
            foreach (int[] ints in intArray4)
            {
                for (int i = 0; i < ints.Length; i++)
                {
                    Console.WriteLine("交错和多维2 遍历： "+ints[i]);
                }
            }
            Console.Read();

        }

    }
}
