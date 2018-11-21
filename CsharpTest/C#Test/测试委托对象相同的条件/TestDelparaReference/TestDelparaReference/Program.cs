using System;

namespace TestDelparaReference
{
    class Program
    {
        /*
            *  MSDN上解释：判断两个委托对象相等，指向同一块内存
            *      前提：同一个委托类型
            *
            *          委托对象只有一个方法
            *              条件1：方法是同一个类的同一个静态方法
            *              条件2：方法是同一个实例对象的实例方法
            *          委托对象有多个方法
            *              满足以上两个条件
            *              条件3：方法列表的顺序要相等
            */
        static void Main(string[] args)
        {
            // 测试说明:同一个方法，赋值给不同的委托对象，都是同一个引用
            Program p1 = new Program();
            Action a0 = new Action(p1.Do);
            Action b0 = new Action(p1.Do);
            Console.WriteLine(a0 == b0);
            // 快捷写法
            Action a1 = p1.Do;
            Action b1 = p1.Do;
            Action c1 = p1.Do2;
            p1.Reference(p1.Do, p1.Do2);
            p1.Reference(p1.Do, p1.Do);
            Console.WriteLine(a1 == b1);
            Console.WriteLine(a1 == c1);
            Console.Read();
        }

        public void Reference(Action myaction, Action b)
        {
            Action a1 = myaction;
            Action b1 = b;
            Console.WriteLine(a1 == b1);
        }

        public void Do()
        {

        }

        public void Do2()
        {

        }
    }
}
