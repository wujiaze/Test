using System;
using System.Collections.Generic;
using System.Text;

namespace TestArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] tmp = new double[3]; // 设定一维数组的初始大小
            double[] tmpa = new double[] { 1, 2, 3, 4 };
            double[] tmpb = new double[] { 2, 3, 4, 5 };
            //double[] tmpRes = tmpa + tmpb;  测试说明 数组之间无法相加,只能遍历相加

            /* 二维数组 */
            double[,] erweiTmp1 = new double[3,3]; // 设定二维数组的初始大小
            erweiTmp1[0, 0] = 9; // 赋值
            double[,] erweiTmp2 = new double[3, 3]; // 设定二维数组的初始大小
            //erweiTmp1 + erweiTmp2   测试说明 二维数组之间无法相加,只能遍历相加

            /* 交错数组 */
            double[][] tmplista = new double[2][];  // 表示 有2个double[] 子数组 的 double[] 数组
            double[][] tmplista2 = new double[2][];
            //tmplista + tmplista2   测试说明 二维数组之间无法相加,只能遍历相加

            tmplista[0] = tmpa;
            tmplista[1] = tmpb;
            for (int i = 0; i < tmplista.Length; i++)
            {
                foreach (double item in tmplista[i])
                {
                    Console.WriteLine(item);
                }
            }
            
            Console.ReadLine();
        }
    }
}
