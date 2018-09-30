using System;
using System.Collections.Generic;
using System.Text;

namespace TestCollectionRemove
{
    class Program
    {
        public List<string> testList = new List<string>();
        public List<string> sdfds = new List<string>();
        public Dictionary<string, string> testDic = new Dictionary<string, string>();
        public Dictionary<int, string> intDict = new Dictionary<int, string>();
        public Stack<string> testStack = new Stack<string>();
        public Queue<string> testQueue = new Queue<string>();
        static void Main(string[] args)
        {
            /* 测试说明： 在使用枚举器时(foreach)，无法对集合进行删除、增加等改变枚举时集合的操作 */
            /* 测试说明:  List/Dictionary 使用for循环时,如果要增加/删除元素，都一定要从尾部开始遍历 */
            /* 测试说明： 遍历List、字典和队列时，都是先加入的先遍历 。栈是后加入先遍历*/
            Program program = new Program();
            // 测试说明：空的集合遍历，不会报错
            foreach (var item in program.testList)
            {
                Console.WriteLine(item);
            }
            /* 列表 */
            program.testList.Add("1");
            program.testList.Add("2");
            program.testList.Add("3");
            program.testList.Add("4");
            program.testList.Add("5");
            foreach (string item in program.testList)
            {
                //Console.WriteLine(item);
                //if (item == "2")
                //{
                //    program.testList.Remove(item);
                //}
            }
            for (int i = 0; i < 10; i++)
            {
                program.testList.Add(i + ";");
            }
            program.sdfds.Add("1;");
            program.sdfds.Add("9;");

            for (int i = program.testList.Count - 1; i >= 0; i--)           
            {
                for (int j = 0; j < program.sdfds.Count; j++)
                {
                    if (program.testList[i] == program.sdfds[j])
                    {
                        program.testList.Add(9 + ";");              // 每当增加或减少，会立即改变 program.testList.Count 的值，这里是从尾部遍历，不会影响遍历结果
                    }                                               // 如果是从头部遍历，就会出现问题（比如：增加：多遍历了一次，无限循环，删除:少遍历了几次）
                }
            }
            /* 栈 */
            program.testStack.Push("1");
            program.testStack.Push("2");
            program.testStack.Push("3");
            program.testStack.Push("4");
            program.testStack.Push("5");
            while (program.testStack.Count > 0)
            {
                program.testStack.Pop();
            }
            foreach (var item in program.testStack)
            {
                //Console.WriteLine(item);
                program.testStack.Pop();
            }
            /* 队列 */
            program.testQueue.Enqueue("1");
            program.testQueue.Enqueue("2");
            program.testQueue.Enqueue("3");
            program.testQueue.Enqueue("4");
            program.testQueue.Enqueue("5");
            //while (program.testQueue.Count > 0)
            //{
            //    program.testQueue.Dequeue();
            //}
            foreach (var item in program.testQueue)
            {
                //Console.WriteLine(item);
                //program.testQueue.Dequeue();
            }
            /* 字典 */
            Console.WriteLine("-----字典------");
            program.testDic.Add("1", "11");
            program.testDic.Add("2", "22");
            program.testDic.Add("3", "33");
            program.testDic.Add("4", "44");
            program.testDic.Add("5", "55");
            //while (program.testDic.Count > 0)
            //{
            //    program.testDic.Remove("1");
            //}
            program.intDict.Add(1, "11");
            program.intDict.Add(2, "22");
            program.intDict.Add(3, "11");
            program.intDict.Add(4, "22");
            program.intDict.Add(5, "55");
            for (int i = program.testDic.Count; i >= 1; i--)
            {
                if (program.testDic[i.ToString()] == program.intDict[i])
                {
                    program.testDic.Remove(i.ToString());
                }
            }
            //for (int i = 1; i <= program.testDic.Count; i++)
            //{
            //    if (program.testDic[i.ToString()] == program.intDict[i])
            //    {
            //        program.testDic.Remove(i.ToString());
            //    }
            //}
            foreach (var item in program.testDic)
            {
                Console.WriteLine(item.Key);
                //program.testDic.Remove(item.Key);
                //program.testDic.Add("3", "33");
            }
            Console.ReadLine();
        }
    }
}
