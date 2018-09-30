using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestStaticChange
{
    class SonClass:FatherClass
    {
        // 测试说明: 子类拥有父类的静态字段，并且值不相同时，需要使用 new 关键字来覆盖
        // 不同点： 1、静态量可以在 静态构造函数中 赋值
        //public static string name = "sonclass";
        public new static string Name = "sonclass";
        // const 表现得跟 静态量 一样，只是在内存中没有固定位置（随编译器决定）
        // 不同点： 1、 必须赋值
        //         2、 可以用在本地常量和全局常量
        public new const string Type = "sontype";
        // readonly 也表现的跟 const 一样
        // 不同点:1、有固定存储位置
        //        2、readonly 既可以修饰静态量 也可以修饰实例变量
        //        3、readonly 修饰的值，可以在语句中声明，也可以在构造函数中声明（静态量，在静态构造函数中声明）
        //        4、readonly 修饰的值，可以在不同的构造函数中，有不同的声明
        public new static readonly string Age = "son :18";

        /* 属性 */
        // 测试说明： 返回相同的类型(这里指接口)的对象时，需要用 new 关键字来覆盖
        private static SonClass _instace = null;
        private static readonly object _lockobj = new object();
        public new static IClass Instance
        {
            get
            {
                if (_instace == null)
                {
                    lock (_lockobj)
                    {
                        if (_instace == null)
                        {
                            _instace = new SonClass();
                        }
                    }
                }
                return _instace;
            }
        }


        static SonClass() {
            Name = "ss";
        }
    }
}
