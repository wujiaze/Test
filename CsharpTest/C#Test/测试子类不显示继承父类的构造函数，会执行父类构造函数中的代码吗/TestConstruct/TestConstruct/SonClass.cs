using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConstruct
{
    public class SonClass:FatherClass
    {
        private static volatile SonClass _instance;
        public static readonly object _lockobj = new object();
        public static SonClass Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lockobj)
                    {
                        if (_instance == null)
                        {
                            _instance = new SonClass("--------");
                        }
                    }
                }
                return _instance;
            }
        }

        /* 构造函数 */
        // 测试说明：不显示的写 base(xxx) 则默认继承父类的默认构造函数
        protected SonClass()
        {
            Console.WriteLine("子类的构造函数语句");
        }
        // 测试说明：显示写出  base(xxx) ，则继承指定的父类构造函数
        // 并且将参数传入父类，先执行父类的构造函数的语句
        protected SonClass(string name):base(name)
        {
            Console.WriteLine("子类的构造函数语句"+ name);
        }

        /* 静态构造函数 */
        // 测试说明：调用子类的静态成员，会先调用父类的静态构造函数，再调用子类的静态构造函数
        static SonClass()
        {
            Console.WriteLine("子类的静态构造函数");
        }


        /* 方法 */
        // 测试说明: 虚方法
        // 添加 base 则先执行父类的虚方法中的语句，在执行子类的语句，并且一般把 base 放在最前面
        // 不添加 base 则不执行父类虚方法中的语句，直接执行子类的语句
        public override void Show()
        {
            base.Show();
            Console.WriteLine("子类重写父类虚方法");
        }

        public override void Over()
        {
            Console.WriteLine("子类不继承父类的base语句");
        }

      
    }
}
