using System;
using System.IO;
namespace CsharpPathTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *      File 类 支持的路径表示
             *      特别注意:路径中的斜杠要统一，虽然这里正反都可以
             *                                但是 1、有的格式下，路径会出错
             *                                     2、解析路径时，比较麻烦
             *                                 所以路径推荐统一
             */
            string path7 = @"D:\Desktop\编程学习总结\ProgramSummary\Unity总结\Unity_WWW和WWWForm类\WWWLearn\Assets\StreamingAssets/1.txt";
            ResdFile(path7, "方法7");  // 一般C#中推荐
            // 方法2: 路径全部为 一般斜杠
            string path8 = @"D:/Desktop/编程学习总结/ProgramSummary/Unity总结/Unity_WWW和WWWForm类/WWWLearn/Assets/StreamingAssets/1.txt";
            ResdFile(path8, "方法8");  // Unity中推荐

            Console.Read();
        }
        private static void ResdFile(string path, string str)
        {
            Console.WriteLine(path);
            string txt = File.ReadAllText(path);
            Console.WriteLine(str + "      " + path + "    " + txt);
        }
    }
}
